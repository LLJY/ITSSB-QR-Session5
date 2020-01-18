namespace Session5
{
    partial class AssignSeating
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skill_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.assignedcomp_label = new System.Windows.Forms.Label();
            this.unassigned_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seat6 = new System.Windows.Forms.Button();
            this.seat5 = new System.Windows.Forms.Button();
            this.seat4 = new System.Windows.Forms.Button();
            this.seat3 = new System.Windows.Forms.Button();
            this.seat2 = new System.Windows.Forms.Button();
            this.seat1 = new System.Windows.Forms.Button();
            this.unassigned_listbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.seat8 = new System.Windows.Forms.Button();
            this.seat7 = new System.Windows.Forms.Button();
            this.swap_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assign Seating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skill :";
            // 
            // skill_combo
            // 
            this.skill_combo.FormattingEnabled = true;
            this.skill_combo.Location = new System.Drawing.Point(321, 38);
            this.skill_combo.Name = "skill_combo";
            this.skill_combo.Size = new System.Drawing.Size(154, 21);
            this.skill_combo.TabIndex = 4;
            this.skill_combo.SelectedIndexChanged += new System.EventHandler(this.Skill_combo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Skill :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(586, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Skill :";
            // 
            // assignedcomp_label
            // 
            this.assignedcomp_label.AutoSize = true;
            this.assignedcomp_label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedcomp_label.Location = new System.Drawing.Point(61, 94);
            this.assignedcomp_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assignedcomp_label.Name = "assignedcomp_label";
            this.assignedcomp_label.Size = new System.Drawing.Size(46, 17);
            this.assignedcomp_label.TabIndex = 7;
            this.assignedcomp_label.Text = "Skill :";
            // 
            // unassigned_label
            // 
            this.unassigned_label.AutoSize = true;
            this.unassigned_label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unassigned_label.Location = new System.Drawing.Point(636, 94);
            this.unassigned_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unassigned_label.Name = "unassigned_label";
            this.unassigned_label.Size = new System.Drawing.Size(46, 17);
            this.unassigned_label.TabIndex = 8;
            this.unassigned_label.Text = "Skill :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seat7);
            this.groupBox1.Controls.Add(this.seat8);
            this.groupBox1.Controls.Add(this.seat6);
            this.groupBox1.Controls.Add(this.seat5);
            this.groupBox1.Controls.Add(this.seat4);
            this.groupBox1.Controls.Add(this.seat3);
            this.groupBox1.Controls.Add(this.seat2);
            this.groupBox1.Controls.Add(this.seat1);
            this.groupBox1.Location = new System.Drawing.Point(14, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 295);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // seat6
            // 
            this.seat6.Location = new System.Drawing.Point(214, 159);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(64, 64);
            this.seat6.TabIndex = 5;
            this.seat6.Text = "6";
            this.seat6.UseVisualStyleBackColor = true;
            this.seat6.Click += new System.EventHandler(this.Seat6_Click);
            // 
            // seat5
            // 
            this.seat5.Location = new System.Drawing.Point(6, 159);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(64, 64);
            this.seat5.TabIndex = 4;
            this.seat5.Text = "5";
            this.seat5.UseVisualStyleBackColor = true;
            this.seat5.Click += new System.EventHandler(this.Seat5_Click);
            // 
            // seat4
            // 
            this.seat4.Location = new System.Drawing.Point(214, 89);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(64, 64);
            this.seat4.TabIndex = 3;
            this.seat4.Text = "4";
            this.seat4.UseVisualStyleBackColor = true;
            this.seat4.Click += new System.EventHandler(this.Seat4_Click);
            // 
            // seat3
            // 
            this.seat3.Location = new System.Drawing.Point(6, 89);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(64, 64);
            this.seat3.TabIndex = 2;
            this.seat3.Text = "3";
            this.seat3.UseVisualStyleBackColor = true;
            this.seat3.Click += new System.EventHandler(this.Seat3_Click);
            // 
            // seat2
            // 
            this.seat2.Location = new System.Drawing.Point(214, 19);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(64, 64);
            this.seat2.TabIndex = 1;
            this.seat2.Text = "2";
            this.seat2.UseVisualStyleBackColor = true;
            this.seat2.Click += new System.EventHandler(this.Seat2_Click);
            // 
            // seat1
            // 
            this.seat1.Location = new System.Drawing.Point(6, 19);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(64, 64);
            this.seat1.TabIndex = 0;
            this.seat1.Text = "1";
            this.seat1.UseVisualStyleBackColor = true;
            this.seat1.Click += new System.EventHandler(this.Seat1_Click);
            // 
            // unassigned_listbox
            // 
            this.unassigned_listbox.FormattingEnabled = true;
            this.unassigned_listbox.Location = new System.Drawing.Point(544, 146);
            this.unassigned_listbox.Name = "unassigned_listbox";
            this.unassigned_listbox.Size = new System.Drawing.Size(221, 121);
            this.unassigned_listbox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "Randomly Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 57);
            this.button2.TabIndex = 12;
            this.button2.Text = "Manually Assign";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 57);
            this.button3.TabIndex = 13;
            this.button3.Text = "Swap Seats";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 57);
            this.button4.TabIndex = 14;
            this.button4.Text = "Confirm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(621, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Unassigned";
            // 
            // seat8
            // 
            this.seat8.Location = new System.Drawing.Point(214, 225);
            this.seat8.Name = "seat8";
            this.seat8.Size = new System.Drawing.Size(64, 64);
            this.seat8.TabIndex = 6;
            this.seat8.Text = "8";
            this.seat8.UseVisualStyleBackColor = true;
            this.seat8.Click += new System.EventHandler(this.Seat8_Click);
            // 
            // seat7
            // 
            this.seat7.Location = new System.Drawing.Point(6, 229);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(64, 64);
            this.seat7.TabIndex = 7;
            this.seat7.Text = "7";
            this.seat7.UseVisualStyleBackColor = true;
            this.seat7.Click += new System.EventHandler(this.Seat7_Click);
            // 
            // swap_button
            // 
            this.swap_button.Location = new System.Drawing.Point(374, 339);
            this.swap_button.Name = "swap_button";
            this.swap_button.Size = new System.Drawing.Size(101, 57);
            this.swap_button.TabIndex = 16;
            this.swap_button.Text = "Swap";
            this.swap_button.UseVisualStyleBackColor = true;
            this.swap_button.Click += new System.EventHandler(this.Swap_button_Click);
            // 
            // AssignSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swap_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unassigned_listbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.unassigned_label);
            this.Controls.Add(this.assignedcomp_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skill_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignSeating";
            this.Text = "AssignSeating";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox skill_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label assignedcomp_label;
        private System.Windows.Forms.Label unassigned_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button seat4;
        private System.Windows.Forms.Button seat3;
        private System.Windows.Forms.Button seat2;
        private System.Windows.Forms.Button seat1;
        private System.Windows.Forms.Button seat5;
        private System.Windows.Forms.Button seat6;
        private System.Windows.Forms.ListBox unassigned_listbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button seat7;
        private System.Windows.Forms.Button seat8;
        private System.Windows.Forms.Button swap_button;
    }
}