namespace DininigPhilosophers
{
    partial class FormMain
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
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPhilosopher = new System.Windows.Forms.Label();
            this.labelStatus5 = new System.Windows.Forms.Label();
            this.labelStatus4 = new System.Windows.Forms.Label();
            this.labelStatus3 = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.labelPhilosopher5 = new System.Windows.Forms.Label();
            this.labelPhilosopher4 = new System.Windows.Forms.Label();
            this.labelPhilosopher3 = new System.Windows.Forms.Label();
            this.labelPhilosopher2 = new System.Windows.Forms.Label();
            this.labelPhilosopher1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(536, 171);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 27;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(536, 94);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 26;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(284, 53);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(85, 29);
            this.labelStatus.TabIndex = 25;
            this.labelStatus.Text = "Status";
            // 
            // labelPhilosopher
            // 
            this.labelPhilosopher.AutoSize = true;
            this.labelPhilosopher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPhilosopher.Location = new System.Drawing.Point(43, 53);
            this.labelPhilosopher.Name = "labelPhilosopher";
            this.labelPhilosopher.Size = new System.Drawing.Size(154, 29);
            this.labelPhilosopher.TabIndex = 24;
            this.labelPhilosopher.Text = "Philosopher";
            // 
            // labelStatus5
            // 
            this.labelStatus5.AutoSize = true;
            this.labelStatus5.Location = new System.Drawing.Point(296, 344);
            this.labelStatus5.Name = "labelStatus5";
            this.labelStatus5.Size = new System.Drawing.Size(54, 17);
            this.labelStatus5.TabIndex = 23;
            this.labelStatus5.Text = "label10";
            // 
            // labelStatus4
            // 
            this.labelStatus4.AutoSize = true;
            this.labelStatus4.Location = new System.Drawing.Point(296, 292);
            this.labelStatus4.Name = "labelStatus4";
            this.labelStatus4.Size = new System.Drawing.Size(46, 17);
            this.labelStatus4.TabIndex = 22;
            this.labelStatus4.Text = "label9";
            // 
            // labelStatus3
            // 
            this.labelStatus3.AutoSize = true;
            this.labelStatus3.Location = new System.Drawing.Point(296, 240);
            this.labelStatus3.Name = "labelStatus3";
            this.labelStatus3.Size = new System.Drawing.Size(46, 17);
            this.labelStatus3.TabIndex = 21;
            this.labelStatus3.Text = "label8";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Location = new System.Drawing.Point(296, 188);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(46, 17);
            this.labelStatus2.TabIndex = 20;
            this.labelStatus2.Text = "label7";
            // 
            // labelStatus1
            // 
            this.labelStatus1.AutoSize = true;
            this.labelStatus1.Location = new System.Drawing.Point(296, 136);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(46, 17);
            this.labelStatus1.TabIndex = 19;
            this.labelStatus1.Text = "label6";
            // 
            // labelPhilosopher5
            // 
            this.labelPhilosopher5.AutoSize = true;
            this.labelPhilosopher5.Location = new System.Drawing.Point(80, 344);
            this.labelPhilosopher5.Name = "labelPhilosopher5";
            this.labelPhilosopher5.Size = new System.Drawing.Size(46, 17);
            this.labelPhilosopher5.TabIndex = 18;
            this.labelPhilosopher5.Text = "label5";
            // 
            // labelPhilosopher4
            // 
            this.labelPhilosopher4.AutoSize = true;
            this.labelPhilosopher4.Location = new System.Drawing.Point(80, 292);
            this.labelPhilosopher4.Name = "labelPhilosopher4";
            this.labelPhilosopher4.Size = new System.Drawing.Size(46, 17);
            this.labelPhilosopher4.TabIndex = 17;
            this.labelPhilosopher4.Text = "label4";
            // 
            // labelPhilosopher3
            // 
            this.labelPhilosopher3.AutoSize = true;
            this.labelPhilosopher3.Location = new System.Drawing.Point(80, 240);
            this.labelPhilosopher3.Name = "labelPhilosopher3";
            this.labelPhilosopher3.Size = new System.Drawing.Size(46, 17);
            this.labelPhilosopher3.TabIndex = 16;
            this.labelPhilosopher3.Text = "label3";
            // 
            // labelPhilosopher2
            // 
            this.labelPhilosopher2.AutoSize = true;
            this.labelPhilosopher2.Location = new System.Drawing.Point(80, 188);
            this.labelPhilosopher2.Name = "labelPhilosopher2";
            this.labelPhilosopher2.Size = new System.Drawing.Size(46, 17);
            this.labelPhilosopher2.TabIndex = 15;
            this.labelPhilosopher2.Text = "label2";
            // 
            // labelPhilosopher1
            // 
            this.labelPhilosopher1.AutoSize = true;
            this.labelPhilosopher1.Location = new System.Drawing.Point(80, 136);
            this.labelPhilosopher1.Name = "labelPhilosopher1";
            this.labelPhilosopher1.Size = new System.Drawing.Size(46, 17);
            this.labelPhilosopher1.TabIndex = 14;
            this.labelPhilosopher1.Text = "label1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelPhilosopher);
            this.Controls.Add(this.labelStatus5);
            this.Controls.Add(this.labelStatus4);
            this.Controls.Add(this.labelStatus3);
            this.Controls.Add(this.labelStatus2);
            this.Controls.Add(this.labelStatus1);
            this.Controls.Add(this.labelPhilosopher5);
            this.Controls.Add(this.labelPhilosopher4);
            this.Controls.Add(this.labelPhilosopher3);
            this.Controls.Add(this.labelPhilosopher2);
            this.Controls.Add(this.labelPhilosopher1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPhilosopher;
        private System.Windows.Forms.Label labelPhilosopher5;
        private System.Windows.Forms.Label labelPhilosopher4;
        private System.Windows.Forms.Label labelPhilosopher3;
        private System.Windows.Forms.Label labelPhilosopher2;
        public System.Windows.Forms.Label labelPhilosopher1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelStatus5;
        private System.Windows.Forms.Label labelStatus4;
        private System.Windows.Forms.Label labelStatus3;
        private System.Windows.Forms.Label labelStatus2;
        private System.Windows.Forms.Label labelStatus1;
    }
}

