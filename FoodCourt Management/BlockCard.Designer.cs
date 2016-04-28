namespace FoodCourt_Management
{
    partial class BlockCard
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
            this.CardNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.blockButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.unblockButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // CardNo
            // 
            this.CardNo.Depth = 0;
            this.CardNo.Hint = "Card number";
            this.CardNo.Location = new System.Drawing.Point(222, 91);
            this.CardNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardNo.Name = "CardNo";
            this.CardNo.PasswordChar = '\0';
            this.CardNo.SelectedText = "";
            this.CardNo.SelectionLength = 0;
            this.CardNo.SelectionStart = 0;
            this.CardNo.Size = new System.Drawing.Size(109, 23);
            this.CardNo.TabIndex = 0;
            this.CardNo.UseSystemPasswordChar = false;
            // 
            // blockButton
            // 
            this.blockButton.AutoSize = true;
            this.blockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.blockButton.Depth = 0;
            this.blockButton.Location = new System.Drawing.Point(213, 155);
            this.blockButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.blockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.blockButton.Name = "blockButton";
            this.blockButton.Primary = false;
            this.blockButton.Size = new System.Drawing.Size(55, 36);
            this.blockButton.TabIndex = 1;
            this.blockButton.Text = "Block";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // unblockButton
            // 
            this.unblockButton.AutoSize = true;
            this.unblockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unblockButton.Depth = 0;
            this.unblockButton.Location = new System.Drawing.Point(276, 155);
            this.unblockButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.unblockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.unblockButton.Name = "unblockButton";
            this.unblockButton.Primary = false;
            this.unblockButton.Size = new System.Drawing.Size(74, 36);
            this.unblockButton.TabIndex = 2;
            this.unblockButton.Text = "Unblock";
            this.unblockButton.UseVisualStyleBackColor = true;
            this.unblockButton.Click += new System.EventHandler(this.unblockButton_Click);
            // 
            // BlockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 401);
            this.Controls.Add(this.unblockButton);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.CardNo);
            this.Name = "BlockCard";
            this.Text = "BlockCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField CardNo;
        private MaterialSkin.Controls.MaterialFlatButton blockButton;
        private MaterialSkin.Controls.MaterialFlatButton unblockButton;
    }
}