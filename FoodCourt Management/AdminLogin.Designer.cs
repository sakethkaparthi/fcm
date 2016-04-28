namespace FoodCourt_Management
{
    partial class AdminLogin
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
            this.userNameTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // userNameTb
            // 
            this.userNameTb.Depth = 0;
            this.userNameTb.Hint = "ID";
            this.userNameTb.Location = new System.Drawing.Point(107, 48);
            this.userNameTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.PasswordChar = '\0';
            this.userNameTb.SelectedText = "";
            this.userNameTb.SelectionLength = 0;
            this.userNameTb.SelectionStart = 0;
            this.userNameTb.Size = new System.Drawing.Size(75, 23);
            this.userNameTb.TabIndex = 0;
            this.userNameTb.UseSystemPasswordChar = false;
            // 
            // passwordTb
            // 
            this.passwordTb.Depth = 0;
            this.passwordTb.Hint = "password";
            this.passwordTb.Location = new System.Drawing.Point(107, 115);
            this.passwordTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.SelectedText = "";
            this.passwordTb.SelectionLength = 0;
            this.passwordTb.SelectionStart = 0;
            this.passwordTb.Size = new System.Drawing.Size(75, 23);
            this.passwordTb.TabIndex = 1;
            this.passwordTb.Text = "materialSingleLineTextField2";
            this.passwordTb.UseSystemPasswordChar = false;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(107, 172);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = false;
            this.loginButton.Size = new System.Drawing.Size(52, 36);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.userNameTb);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField userNameTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTb;
        private MaterialSkin.Controls.MaterialFlatButton loginButton;
    }
}