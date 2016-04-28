namespace FoodCourt_Management
{
    partial class AdminPanel
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
            this.bubButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.cardListButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // bubButton
            // 
            this.bubButton.AutoSize = true;
            this.bubButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bubButton.Depth = 0;
            this.bubButton.Location = new System.Drawing.Point(190, 170);
            this.bubButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bubButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bubButton.Name = "bubButton";
            this.bubButton.Primary = false;
            this.bubButton.Size = new System.Drawing.Size(162, 36);
            this.bubButton.TabIndex = 0;
            this.bubButton.Text = "block/unblock card";
            this.bubButton.UseVisualStyleBackColor = true;
            this.bubButton.Click += new System.EventHandler(this.bubButton_Click);
            // 
            // cardListButton
            // 
            this.cardListButton.AutoSize = true;
            this.cardListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cardListButton.Depth = 0;
            this.cardListButton.Location = new System.Drawing.Point(461, 170);
            this.cardListButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cardListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardListButton.Name = "cardListButton";
            this.cardListButton.Primary = false;
            this.cardListButton.Size = new System.Drawing.Size(132, 36);
            this.cardListButton.TabIndex = 1;
            this.cardListButton.Text = "All Card details";
            this.cardListButton.UseVisualStyleBackColor = true;
            this.cardListButton.Click += new System.EventHandler(this.cardListButton_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(190, 263);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(108, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "All Students";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(461, 263);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(80, 36);
            this.materialFlatButton2.TabIndex = 3;
            this.materialFlatButton2.Text = "All Staff";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(317, 74);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(107, 36);
            this.materialFlatButton3.TabIndex = 4;
            this.materialFlatButton3.Text = "Add payment";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 473);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.cardListButton);
            this.Controls.Add(this.bubButton);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton bubButton;
        private MaterialSkin.Controls.MaterialFlatButton cardListButton;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
    }
}