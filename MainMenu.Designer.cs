namespace Session5
{
    partial class MainMenu
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
            this.assign_seating = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enter_marks = new System.Windows.Forms.Button();
            this.view_results = new System.Windows.Forms.Button();
            this.analyze_results = new System.Windows.Forms.Button();
            this.calculate_bonus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assign_seating
            // 
            this.assign_seating.Location = new System.Drawing.Point(215, 65);
            this.assign_seating.Name = "assign_seating";
            this.assign_seating.Size = new System.Drawing.Size(369, 68);
            this.assign_seating.TabIndex = 0;
            this.assign_seating.Text = "Assign Seating";
            this.assign_seating.UseVisualStyleBackColor = true;
            this.assign_seating.Click += new System.EventHandler(this.assign_seating_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrator Main Menu";
            // 
            // enter_marks
            // 
            this.enter_marks.Location = new System.Drawing.Point(215, 139);
            this.enter_marks.Name = "enter_marks";
            this.enter_marks.Size = new System.Drawing.Size(369, 68);
            this.enter_marks.TabIndex = 2;
            this.enter_marks.Text = "Enter Marks";
            this.enter_marks.UseVisualStyleBackColor = true;
            this.enter_marks.Click += new System.EventHandler(this.enter_marks_Click);
            // 
            // view_results
            // 
            this.view_results.Location = new System.Drawing.Point(215, 213);
            this.view_results.Name = "view_results";
            this.view_results.Size = new System.Drawing.Size(369, 68);
            this.view_results.TabIndex = 3;
            this.view_results.Text = "View Results";
            this.view_results.UseVisualStyleBackColor = true;
            this.view_results.Click += new System.EventHandler(this.view_results_Click);
            // 
            // analyze_results
            // 
            this.analyze_results.Location = new System.Drawing.Point(215, 287);
            this.analyze_results.Name = "analyze_results";
            this.analyze_results.Size = new System.Drawing.Size(369, 68);
            this.analyze_results.TabIndex = 4;
            this.analyze_results.Text = "Analyze Results";
            this.analyze_results.UseVisualStyleBackColor = true;
            this.analyze_results.Click += new System.EventHandler(this.analyze_results_Click);
            // 
            // calculate_bonus
            // 
            this.calculate_bonus.Location = new System.Drawing.Point(215, 361);
            this.calculate_bonus.Name = "calculate_bonus";
            this.calculate_bonus.Size = new System.Drawing.Size(369, 68);
            this.calculate_bonus.TabIndex = 5;
            this.calculate_bonus.Text = "Calculate Bonus";
            this.calculate_bonus.UseVisualStyleBackColor = true;
            this.calculate_bonus.Click += new System.EventHandler(this.calculate_bonus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calculate_bonus);
            this.Controls.Add(this.analyze_results);
            this.Controls.Add(this.view_results);
            this.Controls.Add(this.enter_marks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assign_seating);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assign_seating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter_marks;
        private System.Windows.Forms.Button view_results;
        private System.Windows.Forms.Button analyze_results;
        private System.Windows.Forms.Button calculate_bonus;
        private System.Windows.Forms.Button button1;
    }
}