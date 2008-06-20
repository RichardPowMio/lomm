﻿namespace LotroMusicManager
{
    partial class FormToolbar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.mnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniFlip = new System.Windows.Forms.ToolStripMenuItem();
            this.mniView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAddSeparator = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mniAddDefaultItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAddMacroChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mniRemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts
            // 
            this.ts.ContextMenuStrip = this.mnu;
            this.ts.Dock = System.Windows.Forms.DockStyle.None;
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Location = new System.Drawing.Point(10, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(34, 25);
            this.ts.TabIndex = 0;
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFlip,
            this.mniView,
            this.toolStripSeparator1,
            this.mniAdd,
            this.mniRemoveItem});
            this.mnu.Name = "contextMenuStrip1";
            this.mnu.Size = new System.Drawing.Size(185, 98);
            this.mnu.Opening += new System.ComponentModel.CancelEventHandler(this.OnContextMenuOpening);
            // 
            // mniFlip
            // 
            this.mniFlip.Image = global::LotroMusicManager.Properties.Resources.arrow_branch;
            this.mniFlip.Name = "mniFlip";
            this.mniFlip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mniFlip.Size = new System.Drawing.Size(184, 22);
            this.mniFlip.Text = "Flip Direction";
            this.mniFlip.ToolTipText = "Switches the toolbar between horizontal and vertical";
            this.mniFlip.Click += new System.EventHandler(this.OnFlip);
            // 
            // mniView
            // 
            this.mniView.Name = "mniView";
            this.mniView.Size = new System.Drawing.Size(184, 22);
            this.mniView.Text = "View";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // mniAdd
            // 
            this.mniAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAddSeparator,
            this.toolStripSeparator3,
            this.mniAddDefaultItem,
            this.mniAddMacroChoice,
            this.toolStripSeparator4});
            this.mniAdd.Name = "mniAdd";
            this.mniAdd.Size = new System.Drawing.Size(184, 22);
            this.mniAdd.Text = "Add";
            // 
            // mniAddSeparator
            // 
            this.mniAddSeparator.Name = "mniAddSeparator";
            this.mniAddSeparator.Size = new System.Drawing.Size(153, 22);
            this.mniAddSeparator.Text = "Separator";
            this.mniAddSeparator.Click += new System.EventHandler(this.OnAddSeparator);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(150, 6);
            // 
            // mniAddDefaultItem
            // 
            this.mniAddDefaultItem.Image = global::LotroMusicManager.Properties.Resources.wand;
            this.mniAddDefaultItem.Name = "mniAddDefaultItem";
            this.mniAddDefaultItem.Size = new System.Drawing.Size(153, 22);
            this.mniAddDefaultItem.Text = "Default Items...";
            this.mniAddDefaultItem.Click += new System.EventHandler(this.OnAddDefaultItems);
            // 
            // mniAddMacroChoice
            // 
            this.mniAddMacroChoice.Image = global::LotroMusicManager.Properties.Resources.textfield_add;
            this.mniAddMacroChoice.Name = "mniAddMacroChoice";
            this.mniAddMacroChoice.Size = new System.Drawing.Size(153, 22);
            this.mniAddMacroChoice.Text = "Macro Selector";
            this.mniAddMacroChoice.Click += new System.EventHandler(this.OnAddMacroSelector);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(150, 6);
            // 
            // mniRemoveItem
            // 
            this.mniRemoveItem.Name = "mniRemoveItem";
            this.mniRemoveItem.Size = new System.Drawing.Size(184, 22);
            this.mniRemoveItem.Text = "Remove Item";
            this.mniRemoveItem.Click += new System.EventHandler(this.OnRemoveItem);
            // 
            // FormToolbar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 104);
            this.ContextMenuStrip = this.mnu;
            this.ControlBox = false;
            this.Controls.Add(this.ts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormToolbar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormToolbar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OnLoad);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.Activated += new System.EventHandler(this.OnActivated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.mnu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ContextMenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mniFlip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mniAdd;
        private System.Windows.Forms.ToolStripMenuItem mniAddSeparator;
        private System.Windows.Forms.ToolStripMenuItem mniRemoveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mniAddDefaultItem;
        private System.Windows.Forms.ToolStripMenuItem mniAddMacroChoice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mniView;
    }
}