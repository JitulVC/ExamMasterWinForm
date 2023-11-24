using System;
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
    public partial class TakeExamForm : Form
    {
        private DateTime startTime;
        private System.Timers.Timer progressTimer = new System.Timers.Timer(1000);
        public TakeExamForm()
        {
            InitializeComponent();
            this.progressTimer.Elapsed += progressTimer_Elapsed;
            this.progressTimer.SynchronizingObject = this;
            this.startTime = DateTime.Now;
            this.progressTimer.Start();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFinalizeExam_Click(object sender, EventArgs e)
        {
            TakeExamReviewForm takeExamReviewForm = new TakeExamReviewForm();
            takeExamReviewForm.FormClosed += new FormClosedEventHandler(childFormClosed);
            takeExamReviewForm.Show();
        }

        private void childFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void progressTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimeSpan timeWorking = DateTime.Now.Subtract(this.startTime);

            this.labelTimer.Text = timeWorking.ToString(@"hh\:mm\:ss");
        }

    }
}
