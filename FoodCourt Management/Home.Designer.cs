namespace FoodCourt_Management
{
    partial class Home
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
            this.studreg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.empreg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.feedback = new MaterialSkin.Controls.MaterialRaisedButton();
            this.studetail = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // studreg
            // 
            this.studreg.Depth = 0;
            this.studreg.Location = new System.Drawing.Point(107, 135);
            this.studreg.MouseState = MaterialSkin.MouseState.HOVER;
            this.studreg.Name = "studreg";
            this.studreg.Primary = true;
            this.studreg.Size = new System.Drawing.Size(113, 37);
            this.studreg.TabIndex = 0;
            this.studreg.Text = "Student Registration";
            this.studreg.UseVisualStyleBackColor = true;
            this.studreg.Click += new System.EventHandler(this.studreg_Click);
            // 
            // empreg
            // 
            this.empreg.Depth = 0;
            this.empreg.Location = new System.Drawing.Point(323, 135);
            this.empreg.MouseState = MaterialSkin.MouseState.HOVER;
            this.empreg.Name = "empreg";
            this.empreg.Primary = true;
            this.empreg.Size = new System.Drawing.Size(143, 36);
            this.empreg.TabIndex = 1;
            this.empreg.Text = "Employee regirstration";
            this.empreg.UseVisualStyleBackColor = true;
            this.empreg.Click += new System.EventHandler(this.empreg_Click);
            // 
            // feedback
            // 
            this.feedback.Depth = 0;
            this.feedback.Location = new System.Drawing.Point(107, 242);
            this.feedback.MouseState = MaterialSkin.MouseState.HOVER;
            this.feedback.Name = "feedback";
            this.feedback.Primary = true;
            this.feedback.Size = new System.Drawing.Size(113, 35);
            this.feedback.TabIndex = 2;
            this.feedback.Text = "Submit feedback";
            this.feedback.UseVisualStyleBackColor = true;
            this.feedback.Click += new System.EventHandler(this.feedback_Click);
            // 
            // studetail
            // 
            this.studetail.Depth = 0;
            this.studetail.Location = new System.Drawing.Point(323, 242);
            this.studetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.studetail.Name = "studetail";
            this.studetail.Primary = true;
            this.studetail.Size = new System.Drawing.Size(143, 35);
            this.studetail.TabIndex = 3;
            this.studetail.Text = "Student Details";
            this.studetail.UseVisualStyleBackColor = true;
            this.studetail.Click += new System.EventHandler(this.studetail_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodCourt_Management.Properties.Resources.colorful_abstract_backgrounds_design_aqua_blue_color_abstract_background_design_79051;
            this.ClientSize = new System.Drawing.Size(589, 477);
            this.Controls.Add(this.studetail);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.empreg);
            this.Controls.Add(this.studreg);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton studreg;
        private MaterialSkin.Controls.MaterialRaisedButton empreg;
        private MaterialSkin.Controls.MaterialRaisedButton feedback;
        private MaterialSkin.Controls.MaterialRaisedButton studetail;
    }
}