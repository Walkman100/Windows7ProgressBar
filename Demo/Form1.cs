using System;
using System.Drawing;
using System.Windows.Forms;



namespace VistaMenuDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Font = SystemFonts.MessageBoxFont;

            InitializeComponent();

            radNormal.Font =
                radError.Font = 
                radPaused.Font =
                radMarquee.Font = new Font(Font, FontStyle.Bold);
        }

        private void progressor_Tick(object sender, EventArgs e)
        {
            if (windows7ProgressBar.Value == 100)
                windows7ProgressBar.Value = 0;
            else
                windows7ProgressBar.Increment(1);
        }

        private void chkShowInTaskbar_CheckedChanged(object sender, EventArgs e)
        {
            windows7ProgressBar.ShowInTaskbar = chkShowInTaskbar.Checked;
        }

        private void radPaused_CheckedChanged(object sender, EventArgs e)
        {
            if (radPaused.Checked)
            {
                progressor.Enabled = false;
                windows7ProgressBar.State = wyDay.Controls.ProgressBarState.Pause;
            }
        }

        private void radMarquee_CheckedChanged(object sender, EventArgs e)
        {
            if (radMarquee.Checked)
            {
                progressor.Enabled = false;
                windows7ProgressBar.Style = ProgressBarStyle.Marquee;
            }
        }

        private void radError_CheckedChanged(object sender, EventArgs e)
        {
            if (radError.Checked)
            {
                progressor.Enabled = false;
                windows7ProgressBar.State = wyDay.Controls.ProgressBarState.Error;
            }
        }

        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            if(radNormal.Checked)
            {
                progressor.Enabled = true;
                windows7ProgressBar.State = wyDay.Controls.ProgressBarState.Normal;
            }
        }
    }
}
