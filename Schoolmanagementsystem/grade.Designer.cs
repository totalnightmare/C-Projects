namespace Schoolmanagementsystem
{
    partial class grade
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, -2);
            label1.Name = "label1";
            label1.Size = new Size(403, 163);
            label1.TabIndex = 0;
            label1.Text = "Student Grade";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sans Serif Collection", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(95, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 475);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Grade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 7.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(101, 51);
            label2.Name = "label2";
            label2.Size = new Size(142, 54);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 110);
            label3.Name = "label3";
            label3.Size = new Size(98, 81);
            label3.TabIndex = 1;
            label3.Text = "Math";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 149);
            label4.Name = "label4";
            label4.Size = new Size(128, 81);
            label4.TabIndex = 2;
            label4.Text = "Science";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 191);
            label5.Name = "label5";
            label5.Size = new Size(127, 81);
            label5.TabIndex = 3;
            label5.Text = "Pilipino";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(101, 230);
            label6.Name = "label6";
            label6.Size = new Size(123, 81);
            label6.TabIndex = 4;
            label6.Text = "History";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(101, 272);
            label7.Name = "label7";
            label7.Size = new Size(65, 81);
            label7.TabIndex = 5;
            label7.Text = "PE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(101, 311);
            label8.Name = "label8";
            label8.Size = new Size(94, 81);
            label8.TabIndex = 6;
            label8.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(101, 353);
            label9.Name = "label9";
            label9.Size = new Size(80, 81);
            label9.TabIndex = 7;
            label9.Text = "Avg";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(101, 391);
            label10.Name = "label10";
            label10.Size = new Size(109, 81);
            label10.TabIndex = 8;
            label10.Text = "Grade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 92);
            textBox1.TabIndex = 2;
            // 
            // grade
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 675);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "grade";
            Text = "grade";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox1;
    }
}