namespace FightClub
{
    partial class GameForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userHpLabel = new System.Windows.Forms.Label();
            this.botNameLabel = new System.Windows.Forms.Label();
            this.botHpLabel = new System.Windows.Forms.Label();
            this.userProgressBar = new System.Windows.Forms.ProgressBar();
            this.botProgressBar = new System.Windows.Forms.ProgressBar();
            this.fightButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.playerRadioButtonLegs = new System.Windows.Forms.RadioButton();
            this.playerRadioButtonBody = new System.Windows.Forms.RadioButton();
            this.playerRadioButtonHead = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playerBlockedRadioButtonBody = new System.Windows.Forms.RadioButton();
            this.playerBlockedRadioButtonLegs = new System.Windows.Forms.RadioButton();
            this.playerBlockedRadioButtonHead = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userdamageLabel = new System.Windows.Forms.Label();
            this.botdamageLabel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(87, 47);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(27, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "user";
            // 
            // userHpLabel
            // 
            this.userHpLabel.AutoSize = true;
            this.userHpLabel.Location = new System.Drawing.Point(92, 228);
            this.userHpLabel.Name = "userHpLabel";
            this.userHpLabel.Size = new System.Drawing.Size(22, 13);
            this.userHpLabel.TabIndex = 1;
            this.userHpLabel.Text = "HP";
            // 
            // botNameLabel
            // 
            this.botNameLabel.AutoSize = true;
            this.botNameLabel.Location = new System.Drawing.Point(490, 47);
            this.botNameLabel.Name = "botNameLabel";
            this.botNameLabel.Size = new System.Drawing.Size(22, 13);
            this.botNameLabel.TabIndex = 2;
            this.botNameLabel.Text = "bot";
            // 
            // botHpLabel
            // 
            this.botHpLabel.AutoSize = true;
            this.botHpLabel.Location = new System.Drawing.Point(475, 228);
            this.botHpLabel.Name = "botHpLabel";
            this.botHpLabel.Size = new System.Drawing.Size(22, 13);
            this.botHpLabel.TabIndex = 3;
            this.botHpLabel.Text = "HP";
            // 
            // userProgressBar
            // 
            this.userProgressBar.Location = new System.Drawing.Point(37, 189);
            this.userProgressBar.Name = "userProgressBar";
            this.userProgressBar.Size = new System.Drawing.Size(131, 23);
            this.userProgressBar.TabIndex = 4;
            // 
            // botProgressBar
            // 
            this.botProgressBar.Location = new System.Drawing.Point(432, 191);
            this.botProgressBar.Name = "botProgressBar";
            this.botProgressBar.Size = new System.Drawing.Size(131, 23);
            this.botProgressBar.TabIndex = 5;
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(246, 202);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(75, 23);
            this.fightButton.TabIndex = 8;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.playerRadioButtonLegs);
            this.groupBox1.Controls.Add(this.playerRadioButtonBody);
            this.groupBox1.Controls.Add(this.playerRadioButtonHead);
            this.groupBox1.Location = new System.Drawing.Point(187, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 120);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Attack";
            // 
            // playerRadioButtonLegs
            // 
            this.playerRadioButtonLegs.AutoSize = true;
            this.playerRadioButtonLegs.Location = new System.Drawing.Point(20, 86);
            this.playerRadioButtonLegs.Name = "playerRadioButtonLegs";
            this.playerRadioButtonLegs.Size = new System.Drawing.Size(48, 17);
            this.playerRadioButtonLegs.TabIndex = 8;
            this.playerRadioButtonLegs.TabStop = true;
            this.playerRadioButtonLegs.Text = "Legs";
            this.playerRadioButtonLegs.UseVisualStyleBackColor = true;
            // 
            // playerRadioButtonBody
            // 
            this.playerRadioButtonBody.AutoSize = true;
            this.playerRadioButtonBody.Location = new System.Drawing.Point(20, 63);
            this.playerRadioButtonBody.Name = "playerRadioButtonBody";
            this.playerRadioButtonBody.Size = new System.Drawing.Size(49, 17);
            this.playerRadioButtonBody.TabIndex = 7;
            this.playerRadioButtonBody.TabStop = true;
            this.playerRadioButtonBody.Text = "Body";
            this.playerRadioButtonBody.UseVisualStyleBackColor = true;
            // 
            // playerRadioButtonHead
            // 
            this.playerRadioButtonHead.AutoSize = true;
            this.playerRadioButtonHead.Location = new System.Drawing.Point(20, 40);
            this.playerRadioButtonHead.Name = "playerRadioButtonHead";
            this.playerRadioButtonHead.Size = new System.Drawing.Size(51, 17);
            this.playerRadioButtonHead.TabIndex = 6;
            this.playerRadioButtonHead.TabStop = true;
            this.playerRadioButtonHead.Text = "Head";
            this.playerRadioButtonHead.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.playerBlockedRadioButtonBody);
            this.groupBox2.Controls.Add(this.playerBlockedRadioButtonLegs);
            this.groupBox2.Controls.Add(this.playerBlockedRadioButtonHead);
            this.groupBox2.Location = new System.Drawing.Point(280, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 120);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Defense";
            // 
            // playerBlockedRadioButtonBody
            // 
            this.playerBlockedRadioButtonBody.AutoSize = true;
            this.playerBlockedRadioButtonBody.Location = new System.Drawing.Point(23, 63);
            this.playerBlockedRadioButtonBody.Name = "playerBlockedRadioButtonBody";
            this.playerBlockedRadioButtonBody.Size = new System.Drawing.Size(49, 17);
            this.playerBlockedRadioButtonBody.TabIndex = 10;
            this.playerBlockedRadioButtonBody.TabStop = true;
            this.playerBlockedRadioButtonBody.Text = "Body";
            this.playerBlockedRadioButtonBody.UseVisualStyleBackColor = true;
            // 
            // playerBlockedRadioButtonLegs
            // 
            this.playerBlockedRadioButtonLegs.AutoSize = true;
            this.playerBlockedRadioButtonLegs.Location = new System.Drawing.Point(24, 86);
            this.playerBlockedRadioButtonLegs.Name = "playerBlockedRadioButtonLegs";
            this.playerBlockedRadioButtonLegs.Size = new System.Drawing.Size(48, 17);
            this.playerBlockedRadioButtonLegs.TabIndex = 11;
            this.playerBlockedRadioButtonLegs.TabStop = true;
            this.playerBlockedRadioButtonLegs.Text = "Legs";
            this.playerBlockedRadioButtonLegs.UseVisualStyleBackColor = true;
            // 
            // playerBlockedRadioButtonHead
            // 
            this.playerBlockedRadioButtonHead.AutoSize = true;
            this.playerBlockedRadioButtonHead.Location = new System.Drawing.Point(24, 40);
            this.playerBlockedRadioButtonHead.Name = "playerBlockedRadioButtonHead";
            this.playerBlockedRadioButtonHead.Size = new System.Drawing.Size(51, 17);
            this.playerBlockedRadioButtonHead.TabIndex = 9;
            this.playerBlockedRadioButtonHead.TabStop = true;
            this.playerBlockedRadioButtonHead.Text = "Head";
            this.playerBlockedRadioButtonHead.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(168, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 134);
            this.listBox1.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Damage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Damage:";
            // 
            // userdamageLabel
            // 
            this.userdamageLabel.AutoSize = true;
            this.userdamageLabel.Location = new System.Drawing.Point(484, 284);
            this.userdamageLabel.Name = "userdamageLabel";
            this.userdamageLabel.Size = new System.Drawing.Size(13, 13);
            this.userdamageLabel.TabIndex = 24;
            this.userdamageLabel.Text = "0";
            // 
            // botdamageLabel
            // 
            this.botdamageLabel.AutoSize = true;
            this.botdamageLabel.Location = new System.Drawing.Point(92, 284);
            this.botdamageLabel.Name = "botdamageLabel";
            this.botdamageLabel.Size = new System.Drawing.Size(13, 13);
            this.botdamageLabel.TabIndex = 25;
            this.botdamageLabel.Text = "0";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(37, 319);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Save Log";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(432, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 120);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(37, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 120);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 391);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.botdamageLabel);
            this.Controls.Add(this.userdamageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botProgressBar);
            this.Controls.Add(this.userProgressBar);
            this.Controls.Add(this.botHpLabel);
            this.Controls.Add(this.botNameLabel);
            this.Controls.Add(this.userHpLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userHpLabel;
        private System.Windows.Forms.Label botNameLabel;
        private System.Windows.Forms.Label botHpLabel;
        private System.Windows.Forms.ProgressBar userProgressBar;
        private System.Windows.Forms.ProgressBar botProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton playerRadioButtonLegs;
        private System.Windows.Forms.RadioButton playerRadioButtonBody;
        private System.Windows.Forms.RadioButton playerRadioButtonHead;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton playerBlockedRadioButtonBody;
        private System.Windows.Forms.RadioButton playerBlockedRadioButtonLegs;
        private System.Windows.Forms.RadioButton playerBlockedRadioButtonHead;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userdamageLabel;
        private System.Windows.Forms.Label botdamageLabel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}