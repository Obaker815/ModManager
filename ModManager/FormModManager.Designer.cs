namespace ModManager
{
    partial class FormModManager
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnPurge = new System.Windows.Forms.Button();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.panMods = new System.Windows.Forms.Panel();
            this.panInfo = new System.Windows.Forms.Panel();
            this.lblModManager = new System.Windows.Forms.Label();
            this.cbGames = new System.Windows.Forms.ComboBox();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.ofdAddMod = new System.Windows.Forms.OpenFileDialog();
            this.panInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartGame.Location = new System.Drawing.Point(648, 378);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(140, 60);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = false;
            // 
            // btnPurge
            // 
            this.btnPurge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPurge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPurge.Location = new System.Drawing.Point(502, 378);
            this.btnPurge.Name = "btnPurge";
            this.btnPurge.Size = new System.Drawing.Size(140, 60);
            this.btnPurge.TabIndex = 1;
            this.btnPurge.Text = "Purge";
            this.btnPurge.UseVisualStyleBackColor = false;
            // 
            // btnDeploy
            // 
            this.btnDeploy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeploy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeploy.Location = new System.Drawing.Point(356, 378);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(140, 60);
            this.btnDeploy.TabIndex = 2;
            this.btnDeploy.Text = "Deploy";
            this.btnDeploy.UseVisualStyleBackColor = false;
            // 
            // panMods
            // 
            this.panMods.AutoScroll = true;
            this.panMods.AutoScrollMargin = new System.Drawing.Size(0, 4);
            this.panMods.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panMods.Location = new System.Drawing.Point(265, 13);
            this.panMods.Name = "panMods";
            this.panMods.Padding = new System.Windows.Forms.Padding(4);
            this.panMods.Size = new System.Drawing.Size(523, 359);
            this.panMods.TabIndex = 3;
            // 
            // panInfo
            // 
            this.panInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panInfo.Controls.Add(this.btnAddMod);
            this.panInfo.Controls.Add(this.lblModManager);
            this.panInfo.Controls.Add(this.cbGames);
            this.panInfo.Controls.Add(this.cbProfiles);
            this.panInfo.Location = new System.Drawing.Point(13, 13);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(246, 359);
            this.panInfo.TabIndex = 4;
            // 
            // lblModManager
            // 
            this.lblModManager.AutoSize = true;
            this.lblModManager.Font = new System.Drawing.Font("Verdana", 24F);
            this.lblModManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblModManager.Location = new System.Drawing.Point(3, 9);
            this.lblModManager.Name = "lblModManager";
            this.lblModManager.Size = new System.Drawing.Size(232, 38);
            this.lblModManager.TabIndex = 2;
            this.lblModManager.Text = "Mod Manager";
            // 
            // cbGames
            // 
            this.cbGames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGames.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbGames.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbGames.FormattingEnabled = true;
            this.cbGames.Location = new System.Drawing.Point(3, 52);
            this.cbGames.Name = "cbGames";
            this.cbGames.Size = new System.Drawing.Size(240, 33);
            this.cbGames.Sorted = true;
            this.cbGames.TabIndex = 1;
            this.cbGames.SelectedIndexChanged += new System.EventHandler(this.cbGames_SelectedIndexChanged);
            // 
            // cbProfiles
            // 
            this.cbProfiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProfiles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProfiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbProfiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.Location = new System.Drawing.Point(3, 91);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(240, 33);
            this.cbProfiles.Sorted = true;
            this.cbProfiles.TabIndex = 0;
            this.cbProfiles.SelectedIndexChanged += new System.EventHandler(this.cbProfiles_SelectedIndexChanged);
            // 
            // btnAddMod
            // 
            this.btnAddMod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMod.Enabled = false;
            this.btnAddMod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddMod.Location = new System.Drawing.Point(3, 306);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(240, 50);
            this.btnAddMod.TabIndex = 3;
            this.btnAddMod.Text = "Add Mod";
            this.btnAddMod.UseVisualStyleBackColor = false;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // ofdAddMod
            // 
            this.ofdAddMod.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdAddMod_FileOk);
            // 
            // FormModManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.panMods);
            this.Controls.Add(this.btnDeploy);
            this.Controls.Add(this.btnPurge);
            this.Controls.Add(this.btnStartGame);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModManager";
            this.Text = "FormModManager";
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnPurge;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.Panel panMods;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.ComboBox cbGames;
        private System.Windows.Forms.ComboBox cbProfiles;
        private System.Windows.Forms.Label lblModManager;
        private System.Windows.Forms.Button btnAddMod;
        private System.Windows.Forms.OpenFileDialog ofdAddMod;
    }
}