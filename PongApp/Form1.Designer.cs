namespace PongApp
{
    partial class PongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongForm));
            this.ballObject = new System.Windows.Forms.PictureBox();
            this.paddle1 = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scoreLable = new System.Windows.Forms.Label();
            this.infoLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ballObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            this.SuspendLayout();
            // 
            // ballObject
            // 
            this.ballObject.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.ballObject, "ballObject");
            this.ballObject.Name = "ballObject";
            this.ballObject.TabStop = false;
            // 
            // paddle1
            // 
            this.paddle1.BackColor = System.Drawing.Color.DarkCyan;
            resources.ApplyResources(this.paddle1, "paddle1");
            this.paddle1.Name = "paddle1";
            this.paddle1.TabStop = false;
            // 
            // paddle2
            // 
            this.paddle2.BackColor = System.Drawing.Color.DarkCyan;
            resources.ApplyResources(this.paddle2, "paddle2");
            this.paddle2.Name = "paddle2";
            this.paddle2.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLable
            // 
            resources.ApplyResources(this.scoreLable, "scoreLable");
            this.scoreLable.ForeColor = System.Drawing.Color.Cyan;
            this.scoreLable.Name = "scoreLable";
            // 
            // infoLable
            // 
            resources.ApplyResources(this.infoLable, "infoLable");
            this.infoLable.ForeColor = System.Drawing.Color.Cyan;
            this.infoLable.Name = "infoLable";
            // 
            // PongForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.infoLable);
            this.Controls.Add(this.scoreLable);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.paddle1);
            this.Controls.Add(this.ballObject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PongForm";
            this.ShowIcon = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ballObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ballObject;
        private System.Windows.Forms.PictureBox paddle1;
        private System.Windows.Forms.PictureBox paddle2;
        private System.Windows.Forms.Label scoreLable;
        private System.Windows.Forms.Label infoLable;
        private System.Windows.Forms.Timer timer;
    }
}

