﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolmanagementsystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//teacherbtn
        {
            Teacher th = new Teacher();
            th.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)//Section
        {
            Section section = new Section();
            section.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void button1_Click(object sender, EventArgs e)//Student
        {
            Student st = new Student();
            st.Show();
            

        }

        private void Exit_Click(object sender, EventArgs e)//Exit
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)//SubjectButton
        {
            Subject obj = new Subject();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)//Enrollment
        {
            Enrollment obj = new Enrollment();
            obj.Show();
            
        }
    }
}
