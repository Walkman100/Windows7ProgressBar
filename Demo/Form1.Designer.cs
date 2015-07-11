namespace VistaMenuDemo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.progressor = new System.Windows.Forms.Timer(this.components);
            this.chkShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.windows7ProgressBar = new wyDay.Controls.Windows7ProgressBar();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radError = new System.Windows.Forms.RadioButton();
            this.radPaused = new System.Windows.Forms.RadioButton();
            this.radMarquee = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressor
            // 
            this.progressor.Enabled = true;
            this.progressor.Tick += new System.EventHandler(this.progressor_Tick);
            // 
            // chkShowInTaskbar
            // 
            this.chkShowInTaskbar.AutoSize = true;
            this.chkShowInTaskbar.Checked = true;
            this.chkShowInTaskbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowInTaskbar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkShowInTaskbar.Location = new System.Drawing.Point(12, 255);
            this.chkShowInTaskbar.Name = "chkShowInTaskbar";
            this.chkShowInTaskbar.Size = new System.Drawing.Size(155, 18);
            this.chkShowInTaskbar.TabIndex = 1;
            this.chkShowInTaskbar.Text = "Show progress in Taskbar";
            this.chkShowInTaskbar.UseVisualStyleBackColor = true;
            this.chkShowInTaskbar.CheckedChanged += new System.EventHandler(this.chkShowInTaskbar_CheckedChanged);
            // 
            // windows7ProgressBar
            // 
            this.windows7ProgressBar.ContainerControl = this;
            this.windows7ProgressBar.Location = new System.Drawing.Point(12, 278);
            this.windows7ProgressBar.MarqueeAnimationSpeed = 50;
            this.windows7ProgressBar.Name = "windows7ProgressBar";
            this.windows7ProgressBar.ShowInTaskbar = true;
            this.windows7ProgressBar.Size = new System.Drawing.Size(274, 17);
            this.windows7ProgressBar.TabIndex = 0;
            this.windows7ProgressBar.Value = 65;
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Checked = true;
            this.radNormal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radNormal.Location = new System.Drawing.Point(12, 12);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(64, 18);
            this.radNormal.TabIndex = 2;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.radNormal_CheckedChanged);
            // 
            // radError
            // 
            this.radError.AutoSize = true;
            this.radError.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radError.Location = new System.Drawing.Point(12, 54);
            this.radError.Name = "radError";
            this.radError.Size = new System.Drawing.Size(53, 18);
            this.radError.TabIndex = 3;
            this.radError.Text = "Error";
            this.radError.UseVisualStyleBackColor = true;
            this.radError.CheckedChanged += new System.EventHandler(this.radError_CheckedChanged);
            // 
            // radPaused
            // 
            this.radPaused.AutoSize = true;
            this.radPaused.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radPaused.Location = new System.Drawing.Point(12, 120);
            this.radPaused.Name = "radPaused";
            this.radPaused.Size = new System.Drawing.Size(67, 18);
            this.radPaused.TabIndex = 4;
            this.radPaused.Text = "Paused";
            this.radPaused.UseVisualStyleBackColor = true;
            this.radPaused.CheckedChanged += new System.EventHandler(this.radPaused_CheckedChanged);
            // 
            // radMarquee
            // 
            this.radMarquee.AutoSize = true;
            this.radMarquee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radMarquee.Location = new System.Drawing.Point(12, 194);
            this.radMarquee.Name = "radMarquee";
            this.radMarquee.Size = new System.Drawing.Size(73, 18);
            this.radMarquee.TabIndex = 5;
            this.radMarquee.Text = "Marquee";
            this.radMarquee.UseVisualStyleBackColor = true;
            this.radMarquee.CheckedChanged += new System.EventHandler(this.radMarquee_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Show the regular old progress bar.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "This is for errors only (NOT because you think red is a super awesome color progr" +
                "ess bar)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "This is for paused progress only (NOT because you think yellow is a super awesome" +
                " color progress bar)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "For unknown task lengths.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radMarquee);
            this.Controls.Add(this.radPaused);
            this.Controls.Add(this.radError);
            this.Controls.Add(this.radNormal);
            this.Controls.Add(this.chkShowInTaskbar);
            this.Controls.Add(this.windows7ProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows7ProgressBar demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private wyDay.Controls.Windows7ProgressBar windows7ProgressBar;
        private System.Windows.Forms.Timer progressor;
        private System.Windows.Forms.CheckBox chkShowInTaskbar;
        private System.Windows.Forms.RadioButton radError;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radMarquee;
        private System.Windows.Forms.RadioButton radPaused;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}

