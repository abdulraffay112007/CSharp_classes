namespace class5_stopwatch
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
            this.label1 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.milsecond = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.resumebtn = new System.Windows.Forms.Button();
            this.restartbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stop Watch";
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.BackColor = System.Drawing.SystemColors.InfoText;
            this.hour.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hour.Location = new System.Drawing.Point(76, 150);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(57, 53);
            this.hour.TabIndex = 1;
            this.hour.Text = "00";
            this.hour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.BackColor = System.Drawing.SystemColors.InfoText;
            this.minute.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minute.Location = new System.Drawing.Point(139, 150);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(57, 53);
            this.minute.TabIndex = 2;
            this.minute.Text = "00";
            this.minute.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.BackColor = System.Drawing.SystemColors.InfoText;
            this.second.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.second.Location = new System.Drawing.Point(202, 150);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(57, 53);
            this.second.TabIndex = 3;
            this.second.Text = "00";
            this.second.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // milsecond
            // 
            this.milsecond.AutoSize = true;
            this.milsecond.BackColor = System.Drawing.SystemColors.InfoText;
            this.milsecond.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milsecond.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.milsecond.Location = new System.Drawing.Point(265, 150);
            this.milsecond.Name = "milsecond";
            this.milsecond.Size = new System.Drawing.Size(57, 53);
            this.milsecond.TabIndex = 4;
            this.milsecond.Text = "00";
            this.milsecond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.Silver;
            this.startbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.Location = new System.Drawing.Point(12, 260);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(92, 44);
            this.startbtn.TabIndex = 5;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.BackColor = System.Drawing.Color.Silver;
            this.stopbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbtn.Location = new System.Drawing.Point(110, 260);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(92, 44);
            this.stopbtn.TabIndex = 6;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = false;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // resumebtn
            // 
            this.resumebtn.BackColor = System.Drawing.Color.Silver;
            this.resumebtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumebtn.Location = new System.Drawing.Point(211, 260);
            this.resumebtn.Name = "resumebtn";
            this.resumebtn.Size = new System.Drawing.Size(92, 44);
            this.resumebtn.TabIndex = 7;
            this.resumebtn.Text = "Resume";
            this.resumebtn.UseVisualStyleBackColor = false;
            this.resumebtn.Click += new System.EventHandler(this.resumebtn_Click);
            // 
            // restartbtn
            // 
            this.restartbtn.BackColor = System.Drawing.Color.Silver;
            this.restartbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartbtn.Location = new System.Drawing.Point(309, 260);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(92, 44);
            this.restartbtn.TabIndex = 8;
            this.restartbtn.Text = "Restart";
            this.restartbtn.UseVisualStyleBackColor = false;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::class5_stopwatch.Properties.Resources.building;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 530);
            this.Controls.Add(this.restartbtn);
            this.Controls.Add(this.resumebtn);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.milsecond);
            this.Controls.Add(this.second);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label milsecond;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button resumebtn;
        private System.Windows.Forms.Button restartbtn;
        private System.Windows.Forms.Timer timer1;
    }
}

