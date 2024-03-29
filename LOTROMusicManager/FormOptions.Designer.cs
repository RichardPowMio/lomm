﻿namespace LotroMusicManager
{
    partial class FormOptions
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
            this.tabsOptions = new System.Windows.Forms.TabControl();
            this.tpgGeneral = new System.Windows.Forms.TabPage();
            this.trackToolbarOpacity = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAOT = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackMainWindowOpacity = new System.Windows.Forms.TrackBar();
            this.chkKeepLOTROFocused = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imglEmotes = new System.Windows.Forms.ImageList(this.components);
            this.chkLoadABCFilesAtStartup = new System.Windows.Forms.CheckBox();
            this.chkHighlightABC = new System.Windows.Forms.CheckBox();
            this.tabsOptions.SuspendLayout();
            this.tpgGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackToolbarOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMainWindowOpacity)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsOptions
            // 
            this.tabsOptions.Controls.Add(this.tpgGeneral);
            this.tabsOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsOptions.Location = new System.Drawing.Point(3, 3);
            this.tabsOptions.Name = "tabsOptions";
            this.tabsOptions.SelectedIndex = 0;
            this.tabsOptions.Size = new System.Drawing.Size(505, 358);
            this.tabsOptions.TabIndex = 0;
            // 
            // tpgGeneral
            // 
            this.tpgGeneral.Controls.Add(this.chkLoadABCFilesAtStartup);
            this.tpgGeneral.Controls.Add(this.trackToolbarOpacity);
            this.tpgGeneral.Controls.Add(this.label2);
            this.tpgGeneral.Controls.Add(this.chkHighlightABC);
            this.tpgGeneral.Controls.Add(this.chkAOT);
            this.tpgGeneral.Controls.Add(this.label1);
            this.tpgGeneral.Controls.Add(this.trackMainWindowOpacity);
            this.tpgGeneral.Controls.Add(this.chkKeepLOTROFocused);
            this.tpgGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpgGeneral.Name = "tpgGeneral";
            this.tpgGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpgGeneral.Size = new System.Drawing.Size(497, 332);
            this.tpgGeneral.TabIndex = 0;
            this.tpgGeneral.Text = "General";
            this.tpgGeneral.UseVisualStyleBackColor = true;
            // 
            // trackToolbarOpacity
            // 
            this.trackToolbarOpacity.BackColor = System.Drawing.SystemColors.Window;
            this.trackToolbarOpacity.LargeChange = 10;
            this.trackToolbarOpacity.Location = new System.Drawing.Point(124, 159);
            this.trackToolbarOpacity.Maximum = 100;
            this.trackToolbarOpacity.Minimum = 30;
            this.trackToolbarOpacity.Name = "trackToolbarOpacity";
            this.trackToolbarOpacity.Size = new System.Drawing.Size(336, 45);
            this.trackToolbarOpacity.SmallChange = 5;
            this.trackToolbarOpacity.TabIndex = 5;
            this.trackToolbarOpacity.TickFrequency = 10;
            this.trackToolbarOpacity.Value = 100;
            this.trackToolbarOpacity.ValueChanged += new System.EventHandler(this.OnToolbarOpacityValueChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toolbar Opacity";
            // 
            // chkAOT
            // 
            this.chkAOT.AutoSize = true;
            this.chkAOT.Location = new System.Drawing.Point(8, 19);
            this.chkAOT.Name = "chkAOT";
            this.chkAOT.Size = new System.Drawing.Size(275, 17);
            this.chkAOT.TabIndex = 0;
            this.chkAOT.Text = "Keep LOMM on top of other apps (including LOTRO)";
            this.chkAOT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main Window Opacity";
            // 
            // trackMainWindowOpacity
            // 
            this.trackMainWindowOpacity.BackColor = System.Drawing.SystemColors.Window;
            this.trackMainWindowOpacity.LargeChange = 10;
            this.trackMainWindowOpacity.Location = new System.Drawing.Point(124, 127);
            this.trackMainWindowOpacity.Maximum = 100;
            this.trackMainWindowOpacity.Minimum = 30;
            this.trackMainWindowOpacity.Name = "trackMainWindowOpacity";
            this.trackMainWindowOpacity.Size = new System.Drawing.Size(336, 45);
            this.trackMainWindowOpacity.SmallChange = 5;
            this.trackMainWindowOpacity.TabIndex = 3;
            this.trackMainWindowOpacity.TickFrequency = 10;
            this.trackMainWindowOpacity.Value = 100;
            this.trackMainWindowOpacity.ValueChanged += new System.EventHandler(this.OnMainWindowOpacityValueChange);
            // 
            // chkKeepLOTROFocused
            // 
            this.chkKeepLOTROFocused.AutoSize = true;
            this.chkKeepLOTROFocused.Checked = true;
            this.chkKeepLOTROFocused.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepLOTROFocused.Location = new System.Drawing.Point(8, 43);
            this.chkKeepLOTROFocused.Name = "chkKeepLOTROFocused";
            this.chkKeepLOTROFocused.Size = new System.Drawing.Size(375, 17);
            this.chkKeepLOTROFocused.TabIndex = 1;
            this.chkKeepLOTROFocused.Text = "Keep LOTRO sounds playing when using other programs (such as LOMM)";
            this.chkKeepLOTROFocused.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabsOptions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 400);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnOK, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 367);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(505, 30);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(427, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 24);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OnOK);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(327, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // imglEmotes
            // 
            this.imglEmotes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglEmotes.ImageSize = new System.Drawing.Size(16, 16);
            this.imglEmotes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // chkLoadABCFilesAtStartup
            // 
            this.chkLoadABCFilesAtStartup.AutoSize = true;
            this.chkLoadABCFilesAtStartup.Checked = global::LotroMusicManager.Properties.Settings.Default.LoadABCAtStartup;
            this.chkLoadABCFilesAtStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLoadABCFilesAtStartup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LotroMusicManager.Properties.Settings.Default, "LoadABCAtStartup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLoadABCFilesAtStartup.Location = new System.Drawing.Point(8, 90);
            this.chkLoadABCFilesAtStartup.Name = "chkLoadABCFilesAtStartup";
            this.chkLoadABCFilesAtStartup.Size = new System.Drawing.Size(161, 17);
            this.chkLoadABCFilesAtStartup.TabIndex = 6;
            this.chkLoadABCFilesAtStartup.Text = "Load ABC File List at Startup";
            this.chkLoadABCFilesAtStartup.UseVisualStyleBackColor = true;
            // 
            // chkHighlightABC
            // 
            this.chkHighlightABC.AutoSize = true;
            this.chkHighlightABC.Checked = global::LotroMusicManager.Properties.Settings.Default.HighlightABC;
            this.chkHighlightABC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHighlightABC.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LotroMusicManager.Properties.Settings.Default, "HighlightABC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkHighlightABC.Location = new System.Drawing.Point(8, 67);
            this.chkHighlightABC.Name = "chkHighlightABC";
            this.chkHighlightABC.Size = new System.Drawing.Size(155, 17);
            this.chkHighlightABC.TabIndex = 2;
            this.chkHighlightABC.Text = "Highlight syntax in ABC text";
            this.chkHighlightABC.UseVisualStyleBackColor = true;
            // 
            // FormOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(511, 400);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LOMM Options";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tabsOptions.ResumeLayout(false);
            this.tpgGeneral.ResumeLayout(false);
            this.tpgGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackToolbarOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMainWindowOpacity)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsOptions;
        private System.Windows.Forms.TabPage tpgGeneral;
        private System.Windows.Forms.CheckBox chkKeepLOTROFocused;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackMainWindowOpacity;
        private System.Windows.Forms.CheckBox chkAOT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ImageList imglEmotes;
        private System.Windows.Forms.CheckBox chkHighlightABC;
        private System.Windows.Forms.TrackBar trackToolbarOpacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkLoadABCFilesAtStartup;


    }
}