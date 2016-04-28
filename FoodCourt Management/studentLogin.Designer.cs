namespace FoodCourt_Management
{
    partial class studentLogin
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
            this.renotb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.submitbutton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // renotb
            // 
            this.renotb.Depth = 0;
            this.renotb.Hint = "Registration number";
            this.renotb.Location = new System.Drawing.Point(64, 53);
            this.renotb.MouseState = MaterialSkin.MouseState.HOVER;
            this.renotb.Name = "renotb";
            this.renotb.PasswordChar = '\0';
            this.renotb.SelectedText = "";
            this.renotb.SelectionLength = 0;
            this.renotb.SelectionStart = 0;
            this.renotb.Size = new System.Drawing.Size(142, 23);
            this.renotb.TabIndex = 0;
            this.renotb.UseSystemPasswordChar = false;
            // 
            // submitbutton
            // 
            this.submitbutton.AutoSize = true;
            this.submitbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitbutton.Depth = 0;
            this.submitbutton.Location = new System.Drawing.Point(144, 140);
            this.submitbutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Primary = false;
            this.submitbutton.Size = new System.Drawing.Size(62, 36);
            this.submitbutton.TabIndex = 1;
            this.submitbutton.Text = "submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // studentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.renotb);
            this.Name = "studentLogin";
            this.Text = "studentLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField renotb;
        private MaterialSkin.Controls.MaterialFlatButton submitbutton;
    }
}