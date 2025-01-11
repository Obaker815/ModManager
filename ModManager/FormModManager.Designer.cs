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
            this.PanMods = new System.Windows.Forms.Panel();
            this.panInfo = new System.Windows.Forms.Panel();
            this.cbGames = new System.Windows.Forms.ComboBox();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.lblModManager = new System.Windows.Forms.Label();
            this.panInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(648, 378);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(140, 60);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            // 
            // btnPurge
            // 
            this.btnPurge.Location = new System.Drawing.Point(502, 378);
            this.btnPurge.Name = "btnPurge";
            this.btnPurge.Size = new System.Drawing.Size(140, 60);
            this.btnPurge.TabIndex = 1;
            this.btnPurge.Text = "Purge";
            this.btnPurge.UseVisualStyleBackColor = true;
            // 
            // btnDeploy
            // 
            this.btnDeploy.Location = new System.Drawing.Point(356, 378);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(140, 60);
            this.btnDeploy.TabIndex = 2;
            this.btnDeploy.Text = "Deploy";
            this.btnDeploy.UseVisualStyleBackColor = true;
            // 
            // PanMods
            // 
            this.PanMods.Location = new System.Drawing.Point(265, 13);
            this.PanMods.Name = "PanMods";
            this.PanMods.Size = new System.Drawing.Size(523, 359);
            this.PanMods.TabIndex = 3;
            // 
            // panInfo
            // 
            this.panInfo.Controls.Add(this.lblModManager);
            this.panInfo.Controls.Add(this.cbGames);
            this.panInfo.Controls.Add(this.cbProfiles);
            this.panInfo.Location = new System.Drawing.Point(13, 13);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(246, 359);
            this.panInfo.TabIndex = 4;
            // 
            // cbGames
            // 
            this.cbGames.FormattingEnabled = true;
            this.cbGames.Location = new System.Drawing.Point(3, 52);
            this.cbGames.Name = "cbGames";
            this.cbGames.Size = new System.Drawing.Size(240, 33);
            this.cbGames.TabIndex = 1;
            // 
            // cbProfiles
            // 
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.Location = new System.Drawing.Point(3, 91);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(240, 33);
            this.cbProfiles.TabIndex = 0;
            // 
            // lblModManager
            // 
            this.lblModManager.AutoSize = true;
            this.lblModManager.Font = new System.Drawing.Font("Verdana", 24F);
            this.lblModManager.Location = new System.Drawing.Point(3, 9);
            this.lblModManager.Name = "lblModManager";
            this.lblModManager.Size = new System.Drawing.Size(232, 38);
            this.lblModManager.TabIndex = 2;
            this.lblModManager.Text = "Mod Manager";
            // 
            // FormModManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.PanMods);
            this.Controls.Add(this.btnDeploy);
            this.Controls.Add(this.btnPurge);
            this.Controls.Add(this.btnStartGame);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Panel PanMods;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.ComboBox cbGames;
        private System.Windows.Forms.ComboBox cbProfiles;
        private System.Windows.Forms.Label lblModManager;
    }
}