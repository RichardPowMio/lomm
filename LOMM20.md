Yet another 2.0 preview, this one of beta 2, which is hopefully a few days away (but probably a week, given my real-life schedule).

I still really want feedback on all of this. Thank you for the comments so far!

This preview is all about macros!

Sections in the preview:
  * Icons
  * Creating and Editing Macros
  * Editing Actions in a Macro
  * Floating Toolbars - how you access macros


---

## Icons ##
First a non-macro thing: icons. I got really sick of not having icons in the menus, on the buttons, etc., and I found a great icon set whose license works for LOMM, so we now have icons in most places:

![http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMenus1.jpg](http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMenus1.jpg)

## Macros - Creating and Editing ##
So, we have macros now. These completely replace the emotes menus from prior versions and are far more powerful.

Macros are managed from a screen called the Macro Manager, because calling it Fred seemed silly.

![http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMacroEditing1.jpg](http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMacroEditing1.jpg)

Within this screen you can create, delete, or rename macros and you can assign any image as the macro's icon (I'm hoping to have some images available, but we'll see).

Each macro consists of one or more actions.

![http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMacroEditing2.jpg](http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMacroEditing2.jpg)

## Editing Actions in a Macro ##
The various types of actions have their own editors (sorry for the mid-90's cascading dialogs UI design; I realized I was thrashing on UI design instead of getting out a release so I went with something old-school and easy).

For example, sending text out (saying something in /say or /f, doing a slash emote, etc.) looks like this:

![http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMacroEditing3.jpg](http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMacroEditing3.jpg)

In this example, the macro will do 4 things:
```
  - Press button 10 on bar 1 (as if you pressed the "0" key)
 - Say "Healing ;target for ~650 in 2 seconds" to the fellowship channel. ";target" is a special LOTRO shortcut that 
   inserts the name of the current target (player name, monster type, item name, etc.)
 - Say some in-character text (more on this below)
 - Return to the thing selected before whatever currently is selected (in this case, to allow the minstrel to target 
   an opponent for ballads after healing a fellowship member)
```

So, about that weird table in the 'Edit "Say" Action' dialog....

Each line of the table is something it could say. The "weight" is how often it says it, relative to the other lines. If there is only one line (the most common case), weight doesn't matter. In this case, however, we have 11 lines. The line with the asterisk isn't "really" a line... the asterisk means you use that line to create a new choice.

When the action runs, it will pick exactly one of those lines. If you add up the numbers, you get 50 (ten "ones" and a fourty). So, each of the first 10 lines will be said 1 time in 50 (2%). The last line (40/50 chance) doesn't have any text: it will not say anything (meaning that 80% of the time the macro _doesn't_ spam the area with role-playing "flavor text").

These lines can have any combination of weights (well, keep them below a few thousand, please). The whole action is sent to one channel (/say in the image above... it's in the upper-left corner of the dialog), but the line can use slash commands to change the output channel as desired. It can also send a slash command to do an emote or change settings or do anything else you can do on the command line.

Of course, a lot of slash commands appear in the actions menu on their own (with special options editor... see examples below), but you need to use the Say action to make a random choice.

Some commands have special options and use a dialog to help make it easier to configure. For example, Captain and Loremaster pets have modes and commands.

![http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMacroEditing4.jpg](http://lomm.googlecode.com/svn/trunk/Screenshots/BetaMacroEditing4.jpg)

## Toolbars ##

So this is all well and good, but it's useless without a way to run the macros. The answer to that is toolbars.

![http://lomm.googlecode.com/svn/trunk/Screenshots/BetaToolbar1.jpg](http://lomm.googlecode.com/svn/trunk/Screenshots/BetaToolbar1.jpg)

![http://lomm.googlecode.com/svn/trunk/Screenshots/BetaToolbar2.jpg](http://lomm.googlecode.com/svn/trunk/Screenshots/BetaToolbar2.jpg)

These floating toolbars sit on top of your Lotro screen (or wherever you want) and you add macros to them as buttons. Each of these two examples have three macros on them: one with an image and two without. If all three had images, the toolbars would be considerably smaller. Toolbars can have any macro (and a macro can be on multiple toolbars) and they can have separator bars (to help you group macros); in addition, there are two special items that aren't ready to show: a drop-down list of macros (so you can put a bunch of rarely-used macros on one toolbar) and a drop-down list of "favorite" ABC files, allowing you to play your common songs (such as flourishes and the like!) without heading back to the main LOMM screen.

To get things started, I'm planning to include a bunch of prebuilt macros that you can add from a menu, some as examples and some just to make life easier (for the role play emotes, bestowals, etc.) If you have any ideas for these, let me know.

I want to include a way to convert a macro to text so people can share them (actually, there is a way, but it's a block of verbose and ugly XML), but I don't know if that will happen.

Any thoughts?