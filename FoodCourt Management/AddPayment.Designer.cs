namespace FoodCourt_Management
{
    partial class AddPayment
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
            this.amountTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sidTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sumbitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // amountTb
            // 
            this.amountTb.Depth = 0;
            this.amountTb.Hint = "Amount";
            this.amountTb.Location = new System.Drawing.Point(276, 140);
            this.amountTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.amountTb.Name = "amountTb";
            this.amountTb.PasswordChar = '\0';
            this.amountTb.SelectedText = "";
            this.amountTb.SelectionLength = 0;
            this.amountTb.SelectionStart = 0;
            this.amountTb.Size = new System.Drawing.Size(75, 23);
            this.amountTb.TabIndex = 0;
            this.amountTb.UseSystemPasswordChar = false;
            // 
            // sidTb
            // 
            this.sidTb.Depth = 0;
            this.sidTb.Hint = "Reg. no";
            this.sidTb.Location = new System.Drawing.Point(441, 139);
            this.sidTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.sidTb.Name = "sidTb";
            this.sidTb.PasswordChar = '\0';
            this.sidTb.SelectedText = "";
            this.sidTb.SelectionLength = 0;
            this.sidTb.SelectionStart = 0;
            this.sidTb.Size = new System.Drawing.Size(75, 23);
            this.sidTb.TabIndex = 1;
            this.sidTb.UseSystemPasswordChar = false;
            // 
            // sumbitButton
            // 
            this.sumbitButton.AutoSize = true;
            this.sumbitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sumbitButton.Depth = 0;
            this.sumbitButton.Location = new System.Drawing.Point(354, 218);
            this.sumbitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sumbitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sumbitButton.Name = "sumbitButton";
            this.sumbitButton.Primary = false;
            this.sumbitButton.Size = new System.Drawing.Size(72, 36);
            this.sumbitButton.TabIndex = 2;
            this.sumbitButton.Text = "Confirm";
            this.sumbitButton.UseVisualStyleBackColor = true;
            this.sumbitButton.Click += new System.EventHandler(this.sumbitButton_Click);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 487);
            this.Controls.Add(this.sumbitButton);
            this.Controls.Add(this.sidTb);
            this.Controls.Add(this.amountTb);
            this.Name = "AddPayment";
            this.Text = "AddPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField amountTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField sidTb;
        private MaterialSkin.Controls.MaterialFlatButton sumbitButton;
    }
}