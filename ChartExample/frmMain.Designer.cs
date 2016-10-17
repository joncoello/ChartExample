namespace ChartExample {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctlChartControl1 = new ChartExample.ChartControl.ctlChartControl();
            this.SuspendLayout();
            // 
            // ctlChartControl1
            // 
            this.ctlChartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlChartControl1.Location = new System.Drawing.Point(0, 0);
            this.ctlChartControl1.Name = "ctlChartControl1";
            this.ctlChartControl1.Size = new System.Drawing.Size(454, 400);
            this.ctlChartControl1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 400);
            this.Controls.Add(this.ctlChartControl1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl.ctlChartControl ctlChartControl1;
    }
}

