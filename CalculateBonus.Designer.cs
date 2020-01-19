namespace Session5
{
    partial class CalculateBonus
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
            this.session1_dgv = new System.Windows.Forms.DataGridView();
            this.total_bonus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total_amount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.skill_combo = new System.Windows.Forms.ComboBox();
            this.name_combo = new System.Windows.Forms.ComboBox();
            this.session2_dgv = new System.Windows.Forms.DataGridView();
            this.session3_dgv = new System.Windows.Forms.DataGridView();
            this.session4_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.session1_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session3_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session4_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // session1_dgv
            // 
            this.session1_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.session1_dgv.Location = new System.Drawing.Point(13, 127);
            this.session1_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.session1_dgv.Name = "session1_dgv";
            this.session1_dgv.RowHeadersWidth = 51;
            this.session1_dgv.RowTemplate.Height = 24;
            this.session1_dgv.Size = new System.Drawing.Size(582, 63);
            this.session1_dgv.TabIndex = 0;
            // 
            // total_bonus
            // 
            this.total_bonus.AutoSize = true;
            this.total_bonus.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_bonus.Location = new System.Drawing.Point(134, 387);
            this.total_bonus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_bonus.Name = "total_bonus";
            this.total_bonus.Size = new System.Drawing.Size(41, 17);
            this.total_bonus.TabIndex = 13;
            this.total_bonus.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Bonus :";
            // 
            // total_amount
            // 
            this.total_amount.AutoSize = true;
            this.total_amount.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_amount.Location = new System.Drawing.Point(506, 387);
            this.total_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_amount.Name = "total_amount";
            this.total_amount.Size = new System.Drawing.Size(41, 17);
            this.total_amount.TabIndex = 15;
            this.total_amount.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Amount Received :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Skill :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Competitor Name :";
            // 
            // skill_combo
            // 
            this.skill_combo.FormattingEnabled = true;
            this.skill_combo.Location = new System.Drawing.Point(238, 78);
            this.skill_combo.Margin = new System.Windows.Forms.Padding(2);
            this.skill_combo.Name = "skill_combo";
            this.skill_combo.Size = new System.Drawing.Size(114, 21);
            this.skill_combo.TabIndex = 18;
            this.skill_combo.SelectedIndexChanged += new System.EventHandler(this.skill_combo_SelectedIndexChanged);
            // 
            // name_combo
            // 
            this.name_combo.FormattingEnabled = true;
            this.name_combo.Location = new System.Drawing.Point(238, 103);
            this.name_combo.Margin = new System.Windows.Forms.Padding(2);
            this.name_combo.Name = "name_combo";
            this.name_combo.Size = new System.Drawing.Size(114, 21);
            this.name_combo.TabIndex = 19;
            this.name_combo.SelectedIndexChanged += new System.EventHandler(this.name_combo_SelectedIndexChanged);
            // 
            // session2_dgv
            // 
            this.session2_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.session2_dgv.Location = new System.Drawing.Point(13, 194);
            this.session2_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.session2_dgv.Name = "session2_dgv";
            this.session2_dgv.RowHeadersWidth = 51;
            this.session2_dgv.RowTemplate.Height = 24;
            this.session2_dgv.Size = new System.Drawing.Size(582, 63);
            this.session2_dgv.TabIndex = 20;
            // 
            // session3_dgv
            // 
            this.session3_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.session3_dgv.Location = new System.Drawing.Point(13, 261);
            this.session3_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.session3_dgv.Name = "session3_dgv";
            this.session3_dgv.RowHeadersWidth = 51;
            this.session3_dgv.RowTemplate.Height = 24;
            this.session3_dgv.Size = new System.Drawing.Size(582, 54);
            this.session3_dgv.TabIndex = 21;
            // 
            // session4_dgv
            // 
            this.session4_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.session4_dgv.Location = new System.Drawing.Point(13, 319);
            this.session4_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.session4_dgv.Name = "session4_dgv";
            this.session4_dgv.RowHeadersWidth = 51;
            this.session4_dgv.RowTemplate.Height = 24;
            this.session4_dgv.Size = new System.Drawing.Size(582, 54);
            this.session4_dgv.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 31;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Calculate Bonus";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 45);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(2, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 54);
            this.panel2.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(371, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "ASEAN Skills 2020";
            // 
            // CalculateBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.session4_dgv);
            this.Controls.Add(this.session3_dgv);
            this.Controls.Add(this.session2_dgv);
            this.Controls.Add(this.name_combo);
            this.Controls.Add(this.skill_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_bonus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.session1_dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalculateBonus";
            this.Text = "CalculateBonus";
            this.Load += new System.EventHandler(this.CalculateBonus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.session1_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session3_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session4_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView session1_dgv;
        private System.Windows.Forms.Label total_bonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox skill_combo;
        private System.Windows.Forms.ComboBox name_combo;
        private System.Windows.Forms.DataGridView session2_dgv;
        private System.Windows.Forms.DataGridView session3_dgv;
        private System.Windows.Forms.DataGridView session4_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}