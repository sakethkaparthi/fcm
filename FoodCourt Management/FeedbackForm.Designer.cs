namespace FoodCourt_Management
{
    partial class FeedbackForm
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
            this.idtb = new System.Windows.Forms.TextBox();
            this.feedbacktb = new System.Windows.Forms.RichTextBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ratingtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(102, 92);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(113, 20);
            this.idtb.TabIndex = 0;
            // 
            // feedbacktb
            // 
            this.feedbacktb.Location = new System.Drawing.Point(102, 192);
            this.feedbacktb.Name = "feedbacktb";
            this.feedbacktb.Size = new System.Drawing.Size(363, 96);
            this.feedbacktb.TabIndex = 1;
            this.feedbacktb.Text = "";
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(390, 375);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(75, 23);
            this.submitbutton.TabIndex = 2;
            this.submitbutton.Text = "submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Feedback";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rating";
            // 
            // ratingtb
            // 
            this.ratingtb.Location = new System.Drawing.Point(102, 142);
            this.ratingtb.Name = "ratingtb";
            this.ratingtb.Size = new System.Drawing.Size(113, 20);
            this.ratingtb.TabIndex = 6;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 499);
            this.Controls.Add(this.ratingtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.feedbacktb);
            this.Controls.Add(this.idtb);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.RichTextBox feedbacktb;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ratingtb;
    }
}