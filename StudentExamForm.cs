﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamMaster
{
    public partial class StudentExamForm : Form
    {
        public StudentExamForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            TakeExamForm takeExamFormfrm = new TakeExamForm();
            takeExamFormfrm.Show();
        }
    }
}
