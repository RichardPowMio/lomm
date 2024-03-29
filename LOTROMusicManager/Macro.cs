﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;


//====================================================================
// These classes organize "macros", which are collections of "actions"
// An action can be pressing a key, sending text to a channel, or 
// executing a Lotro "command" (as per LotroCommands.cs)
namespace LotroMusicManager
{
    [Serializable()]
    [XmlInclude(typeof(MacroActionKey))]             // Remember, kids, Good OO design == Bad C#!
    [XmlInclude(typeof(MacroActionSay))]             // Therefore, let's just make the base class
    [XmlInclude(typeof(MacroActionSlashCommand))]    // have to know about its specializations.
    [XmlInclude(typeof(MacroActionKeyBinding))]
    abstract public class MacroAction
    {
        public enum ActionType {UNKNOWN, 
                                KEY,
                                COMMAND,
                                SAY};
        //--------------------------------------------------------------------
        public ActionType Type      {get; set;}
        public String     ErrorText {get; set;}
        
        public abstract bool  Execute();
        public virtual  bool  Edit(){return false;}
        public virtual  String Describe()     {return Enum.GetName(typeof(ActionType), Type);}
        public virtual  String DescribeType() {return Enum.GetName(typeof(ActionType), Type);}
        public override string ToString()     {return Describe();}

    }

    [Serializable()]
    public class MacroActionSay : MacroAction
    {//====================================================================
        private static Random _rand = new Random();
        public Channel OutputChannel;

    #region Channel handling
        public enum Channel
        {
            Say,
            Fellowship,
            Raid,
            Local,
            RP,
            UserChannel1,
            UserChannel2,
            UserChannel3,
            LFF,
            Kinship,
            KinOfficers,
            Tribe,
            TribeOfficers
        };
        [Serializable()]
        public class ChannelCommand
        {   //--------------------------------------------------------------------
            // Nested data bag to make the Channels array
            public Channel Channel {get; set;}
            public String  Command {get; set;}
            public String  Name    {get; set;}
            public ChannelCommand(Channel channel, String command, String name)
            {
                Channel = channel;
                Command = command;
                Name = name;
                return;
            }
        }
        public static ChannelCommand[] Channels =     
        {
        #region Channels
		    new ChannelCommand(Channel.Fellowship,    "f",      "Fellowship"),
            new ChannelCommand(Channel.Say,           "say",    "Say"),
            new ChannelCommand(Channel.Raid,          "ra",     "Raid"),
            new ChannelCommand(Channel.Local,         "region", "Regional"),
            new ChannelCommand(Channel.RP,            "rpc",    "Role Playing"),
            new ChannelCommand(Channel.UserChannel1,  "1",      "User channel 1"),
            new ChannelCommand(Channel.UserChannel2,  "2",      "User channel 2"),
            new ChannelCommand(Channel.UserChannel3,  "3",      "User channel 3"),
            new ChannelCommand(Channel.LFF,           "lff",    "Looking For Fellowship"),
            new ChannelCommand(Channel.Kinship,       "k",      "Kinship"),
            new ChannelCommand(Channel.KinOfficers,   "ko",     "Kinship Officers"),
            new ChannelCommand(Channel.Tribe,         "t",      "Tribe"),
            new ChannelCommand(Channel.TribeOfficers, "to",     "Tribe Officers")
	    #endregion        
        };   
    #endregion

    #region Weighted odds handling
        [Serializable()]
        public class WeightedText
        {   //--------------------------------------------------------------------
            // Data bag to handle weighted odds of showing a line
            public int    Weight {get; set;}
            public String Text   {get; set;}
            public WeightedText(int weight, String text) { Weight = weight; Text = text; return; }
            public WeightedText(String text) { Weight = 1; Text = text; return; }
            public WeightedText() { Weight = 1; Text = String.Empty; }
        }
        public List<WeightedText> Lines { get; set; }
    #endregion    
    
        public MacroActionSay()
        {   //====================================================================
            Type = ActionType.SAY;
            Lines    = new List<WeightedText>();
            OutputChannel = Channel.Say;
            return;
        }
        public MacroActionSay(Channel channel)
        {   //--------------------------------------------------------------------
            Type = ActionType.SAY;
            Lines    = new List<WeightedText>();
            OutputChannel = channel;
            return;
        }
        public MacroActionSay(Channel channel, String strText)
        {   //--------------------------------------------------------------------
            Type = ActionType.SAY;
            Lines    = new List<WeightedText>();
            OutputChannel = channel;
            Lines.Add(new WeightedText(strText));
            return;
        }

        public override string Describe()
        {   //====================================================================
            String strRet = "Say";
            String strChannel = Enum.GetName(typeof(Channel), OutputChannel);
            switch (Lines.Count)
            {
                default:
                    // More than one line
                    strRet = "To " + strChannel + ": (one thing from a list of " + Lines.Count + ")";
                    break;

                case 1:
                    strRet = "To " + strChannel + ": " + Lines[0].Text;
                     break;

                case 0:
                    strRet = "Say nothing to channel " + strChannel;
                    break;
            }
            return strRet;
        }
        public override string DescribeType()
        {   //--------------------------------------------------------------------
            return Enum.GetName(typeof(Channel), OutputChannel);
        }

        public int Add(WeightedText wt)
        {   //--------------------------------------------------------------------
            Lines.Add(wt);
            return Lines.Count;
        }

        public override bool Edit()
        {   //====================================================================
            FormActionEditSay frm = new FormActionEditSay(this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Lines = frm.Lines;
                OutputChannel = frm.Channel;
            }
            return true;
        }

        public override bool Execute()
        {   //--------------------------------------------------------------------
            if (null == Lines || Lines.Count == 0) return false;

            String str = Lines[0].Text;;
            
            if (Lines.Count > 1)
            {
                int nTotal = 0;
                foreach (WeightedText wt in Lines) nTotal += wt.Weight;
                
                // Okay...
                // Let's say we have 5 entries with weights 
                //  {1, 3, 2, 4, 4}
                // So they break the roll space into:
                //  {1, 4, 6, 10, 14}
                // e.g, if we roll a 7, we want the next-to-last
                int nPickedNumber  = _rand.Next(1, nTotal + 1); // For some stupid reason, the max is exclusive and the min is inclusive
                int nRunningTally  = 0;
                
                for (int i = 0; i < Lines.Count; i += 1)
                {
                    nRunningTally     += Lines[i].Weight;
                    if (nPickedNumber <= nRunningTally) {str = Lines[i].Text; break;}
                }
            }

            String strCommand = "say";
            foreach (ChannelCommand cc in Channels) 
            {
                if (cc.Channel == OutputChannel) {strCommand = cc.Command; break;}
            }
            //RemoteController.ExecuteFunction("START_COMMAND");
            RemoteController.SendText("/" + strCommand + " " + str); 
            return true;
        }
    }

    [Serializable()]
    public class MacroActionKey : MacroAction
    {   //====================================================================
        public SDK.VK Key       {get; set;}
        public bool   Shift     {get; set;}
        public bool   Control   {get; set;}
        public bool   Alt       {get; set;}
        public bool   Windows   {get; set;}
        
        public MacroActionKey()
        {
            Key = SDK.VK.unknown_vk;
            return;
        }
        public MacroActionKey(SDK.VK vk)
        {   //--------------------------------------------------------------------
            Key = vk;
            Shift = Control = Alt = Windows = false;
        }

        public MacroActionKey(SDK.VK vk, BuckyBits bits)
        {   //--------------------------------------------------------------------
            Key     = vk;
            Shift   = bits.Shift;
            Alt     = bits.Alt;
            Control = bits.Control;
            Windows = bits.Windows;
        }
        public override string Describe()
        {   //====================================================================
            String strRet = "Press ";
            Boolean bBucky = false;
                if (Shift)              {strRet += "SHIFT";   bBucky = true;}
                if (Control && bBucky)  {strRet += "+";}
                if (Control)            {strRet += "CONTROL"; bBucky = true;}
                if (Alt && bBucky)      {strRet += "+";}
                if (Alt)                {strRet += "ALT";     bBucky = true;}
                if (bBucky)             {strRet += " ";}
            
            String strKey = Enum.GetName(typeof(SDK.VK), Key);
            if (strKey.StartsWith("KEY_")) strKey = strKey.Substring(4);
            
            strRet += strKey;
            return strRet;
        }
        public override bool Edit()
        {   //====================================================================
            FormActionEditKey faek = new FormActionEditKey(this);
            if (DialogResult.OK == faek.ShowDialog())
            {
                Key     = faek.Key;
                Shift   = faek.Shift;
                Control = faek.Control;
                Alt     = faek.Alt;
                return true;
            }
            return false;
        }
        public override bool Execute()
        {   //====================================================================
            if (SDK.VK.unknown_vk == Key) return false;

            BuckyBits bits = new BuckyBits();
                bits.Shift = Shift;
                bits.Control = Control;
                bits.Alt = Alt;
                bits.Windows = Windows;

            RemoteController.SendKey(Key, bits);
            return true;
        }
    }

    [Serializable()]
    public class MacroActionKeyBinding : MacroAction
    {   //====================================================================
        public LotroBindingCommand Command {get; set;}
        
        public MacroActionKeyBinding()
        {
            return;
        }
        public MacroActionKeyBinding(LotroBindingCommand lbc)
        {   //--------------------------------------------------------------------
            Command = lbc;
        }
        public override string Describe()
        {   //====================================================================
            return Command.Description;
        }
        public override bool Execute()
        {   //--------------------------------------------------------------------
            if (null == Command || String.Empty == Command.MapfileName) return false;
            RemoteController.ExecuteFunction(Command.MapfileName);
            return true;
        }
    }

    [Serializable()]
    public class MacroActionSlashCommand : MacroAction
    {   //====================================================================
        public LotroSlashCommand Command     {get; set;}
        public String            Arguments   {get; set;}

        public MacroActionSlashCommand()
        {
            return;
        }
        public MacroActionSlashCommand(LotroSlashCommand lsc)
        {
            Command = lsc;
            return;
        }
        public MacroActionSlashCommand(LotroSlashCommand lsc, String args)
        {
            Command   = lsc;
            Arguments = args;
            return;
        }
        public override string Describe()
        {   //====================================================================
            String strRet = String.Empty;
            switch (Command.Type)
            {
                case LotroSlashCommand.SlashCommandType.UNKNOWN:
                default:
                    //Wha?
                    strRet = "<broken action>";
                    break;

                case LotroSlashCommand.SlashCommandType.NoArg:
                    strRet = Command.Description;
                    break;

                case LotroSlashCommand.SlashCommandType.StringArg:
                case LotroSlashCommand.SlashCommandType.ArgChoice:
                    strRet = Command.Description + ": " + Arguments;
                    break;
            }
            return strRet;            
        }
        public override bool Edit()
        {   //====================================================================
            switch (Command.Type)
            {
                default:
                case LotroSlashCommand.SlashCommandType.UNKNOWN:
                case LotroSlashCommand.SlashCommandType.NoArg:
                    // Nothing to show
                    break;

                case LotroSlashCommand.SlashCommandType.StringArg:
                    Arguments = FormInputPrompt.GetInput("Edit Slash Command Parameters", "Enter arguments for command " + Command.Command, Arguments);
                    break;

                case LotroSlashCommand.SlashCommandType.ArgChoice:
                    Arguments = FormInputChoice.GetInput("Choose Slash Command Parameters", "Select option for command " + Command.Command, Command.AllowedArgs, Arguments);
                    break;
            }
            return true;
        }
        public override bool Execute()
        {   //--------------------------------------------------------------------
            switch (Command.Type)
            {
                case LotroSlashCommand.SlashCommandType.UNKNOWN:
                    // This is an error
                    return false;

                case LotroSlashCommand.SlashCommandType.NoArg:
                    RemoteController.SendText("/" + Command.Command);
                    break;

                case LotroSlashCommand.SlashCommandType.StringArg:
                case LotroSlashCommand.SlashCommandType.ArgChoice:
                    RemoteController.SendText("/" + Command.Command + " " + Arguments);
                    break;
            }
            return true;
        }
    }

    [Serializable()]
    public class Macro
    {   //====================================================================
        public  String              Name        {get; set;}
        public  String              Description {get; set;}
        public  String              ErrorText   {get; set;}
        public  String              ID          {get {if (null == _id) _id = GetNewKey(); return _id;} set {_id = value;}} 
        public  String              ImagePath   {get; set;}
        public  List<MacroAction>   Actions     {get; set;}
        private String _id;      

        private static String GetNewKey()
        {
            
            // Make a *safe* copy of the ids... we can't touch the accessor (which the List<Macros> will do)
            List<String> lstIDs = new List<string>();
            foreach (Macro mac in Properties.Settings.Default.Macros.Items) lstIDs.Add(mac._id); 
            
            String s;
            do {s = ObjectUtils.GenerateKey(8);} while (lstIDs.Contains(s));

            return s;
        }

        public void ClearActions()                {Actions.Clear();}
        public int  AddAction(MacroAction action) {Actions.Add(action); return Actions.Count - 1;}
        
        public int  RemoveAction(int nIndex)      {Actions.RemoveAt(nIndex); return Actions.Count;}        
        public int  RemoveActions(int[] aIndex)   
        {
            // Remove from bottom to top
            Array.Sort(aIndex); Array.Reverse(aIndex); 
            foreach (int i in aIndex) RemoveAction(i); 
            return Actions.Count;
        }

        public void MoveUp(int nIndex)
        {   //====================================================================
            if (0 == nIndex) return;

            MacroAction maSwap = Actions[nIndex];
            Actions[nIndex] = Actions[nIndex - 1];
            Actions[nIndex - 1] = maSwap;
            return;
        }
        public void MoveUp(int[] aIndex)
        {
            // Move higher ones first (so we don't just swap positions)
            Array.Sort(aIndex); 
            foreach (int i in aIndex) MoveUp(i);
            return;
        }
        public void MoveDown(int nIndex)
        {   //--------------------------------------------------------------------
            if (Actions.Count - 1 == nIndex) return;

            MacroAction maSwap = Actions[nIndex];
            Actions[nIndex] = Actions[nIndex + 1];
            Actions[nIndex + 1] = maSwap;
            return;
        }
        public void MoveDown(int[] aIndex)
        {
            // Move lower ones first, so we don't just swap positions
            Array.Sort(aIndex); Array.Reverse(aIndex);
            foreach (int i in aIndex) MoveDown(i);
            return;
        }

        public override string ToString() {return Name;}

        public Macro()
        {   //====================================================================
            Name = "";
            Actions = new List<MacroAction>();
            ImagePath = String.Empty;
            return;
        }
        public Macro(String name)
        {   //====================================================================
            Name = name;
            Actions = new List<MacroAction>();
            ImagePath = String.Empty;
            return;
        }

        public bool Execute()
        {   //--------------------------------------------------------------------
            ErrorText = String.Empty;
            foreach (MacroAction action in Actions)
            {
                if (!action.Execute()) 
                {
                    ErrorText = action.ErrorText;
                    return false;
                }
            }
            return true;
        }
    
        static public Macro FromID(String id)
        {   //====================================================================
            return Properties.Settings.Default.Macros.Get(id);
        }

        static public Macro FromXML(String sx)
        {   //====================================================================
            Macro mac = new Macro();
            XmlSerializer xs = new XmlSerializer(typeof(Macro));
            mac = xs.Deserialize(new StringReader(sx)) as Macro;
            if (mac != null) mac.ID = null; // Ignore the ID because it may collide with one we have in use. We'll generate a new one when we need it.
            return mac;
        }

        public String GetXML()
        {   //====================================================================
            XmlSerializer xs = new XmlSerializer(typeof(Macro));
            StringWriter sw = new StringWriter(new StringBuilder());
            xs.Serialize(sw, this);
            return sw.ToString();
        }
    }

    [Serializable()]
    public class MacroList
    {   //====================================================================
        // This is here to make it easy to put a collection of macros into the
        // project properties.
        public String Name {get; set;}
        [XmlArray()]  public List<Macro> Items {get; set;}
        public MacroList()
        {   //--------------------------------------------------------------------
            Items  = new List<Macro>(); 
            Name   = String.Empty; 
        }

        public void  Add(Macro mac)     {Items.Add(mac);} //TODO: Check for duplicates
        public void  Remove(String id)  {Macro mac = Get(id); if (null != mac) Items.Remove(mac);}
        public void  Remove(Macro mac)  {Items.Remove(mac);}
        public Macro Get(String id)     
        {
            foreach (Macro mac in Items) if (mac.ID == id) return mac;
            return null;
        }
        public Macro this[String id]    
        {   get {return Get(id);} 
            set {Macro mac = Get(id); if (null != mac) mac = value;}}

        static public MacroList FromXML(StreamReader sr)
        {   //====================================================================
            MacroList ml = new MacroList();
            XmlSerializer xs = new XmlSerializer(typeof(MacroList));
            ml = (MacroList)xs.Deserialize(sr);
            foreach (Macro m in ml.Items) m.ID = null;
            return ml;
        }

        static public MacroList FromXML(String sx)
        {   //--------------------------------------------------------------------
            MacroList ml = new MacroList();
            XmlSerializer xs = new XmlSerializer(typeof(MacroList));
            ml = (MacroList)xs.Deserialize(new StringReader(sx));
            return ml;
        }

        public String GetXML()
        {   //====================================================================
            XmlSerializer xs = new XmlSerializer(typeof(MacroList));
            StringWriter sw = new StringWriter(new StringBuilder());
            xs.Serialize(sw, this);
            return sw.ToString();
        }
    }
}
