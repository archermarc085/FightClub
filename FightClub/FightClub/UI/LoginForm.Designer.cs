namespace FightClub
{
    partial class LoginForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.LvlBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iLvlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iLvlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(39, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Player";
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // enterButton
            // 
            this.enterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterButton.Location = new System.Drawing.Point(52, 123);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Start";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // LvlBox
            // 
            this.LvlBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LvlBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LvlBox.FormattingEnabled = true;
            this.LvlBox.Location = new System.Drawing.Point(39, 81);
            this.LvlBox.Name = "LvlBox";
            this.LvlBox.Size = new System.Drawing.Size(121, 21);
            this.LvlBox.TabIndex = 3;
            this.LvlBox.SelectedIndexChanged += new System.EventHandler(this.LvlBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select level of difficulty";
            // 
            // iLvlBindingSource
            // 
            this.iLvlBindingSource.DataSource = typeof(FightClub.ILvl);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LvlBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.nameTextBox);
            this.Name = "LoginForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iLvlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.ComboBox LvlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource iLvlBindingSource;
    }
}

