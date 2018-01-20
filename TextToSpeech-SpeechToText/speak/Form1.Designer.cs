namespace speak
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonKonus = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.buttonread = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonCont = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(334, 249);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonKonus
            // 
            this.buttonKonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKonus.Location = new System.Drawing.Point(20, 347);
            this.buttonKonus.Name = "buttonKonus";
            this.buttonKonus.Size = new System.Drawing.Size(164, 45);
            this.buttonKonus.TabIndex = 1;
            this.buttonKonus.Text = "Start";
            this.buttonKonus.UseVisualStyleBackColor = true;
            this.buttonKonus.Click += new System.EventHandler(this.buttonKonus_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox2.Location = new System.Drawing.Point(13, 68);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(334, 249);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Enter your text";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.LargeChange = 10;
            this.trackBarVolume.Location = new System.Drawing.Point(111, 323);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(357, 69);
            this.trackBarVolume.SmallChange = 5;
            this.trackBarVolume.TabIndex = 3;
            this.trackBarVolume.Value = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "TEXT TO SPEECH";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 2;
            this.trackBarSpeed.Location = new System.Drawing.Point(111, 375);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(357, 69);
            this.trackBarSpeed.TabIndex = 6;
            this.trackBarSpeed.Value = 1;
            // 
            // buttonread
            // 
            this.buttonread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonread.Location = new System.Drawing.Point(353, 68);
            this.buttonread.Name = "buttonread";
            this.buttonread.Size = new System.Drawing.Size(115, 46);
            this.buttonread.TabIndex = 7;
            this.buttonread.Text = "Read";
            this.buttonread.UseVisualStyleBackColor = true;
            this.buttonread.Click += new System.EventHandler(this.buttonread_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPause.Location = new System.Drawing.Point(353, 120);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(115, 41);
            this.buttonPause.TabIndex = 8;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonCont
            // 
            this.buttonCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCont.Location = new System.Drawing.Point(353, 167);
            this.buttonCont.Name = "buttonCont";
            this.buttonCont.Size = new System.Drawing.Size(115, 51);
            this.buttonCont.TabIndex = 9;
            this.buttonCont.Text = "Continue";
            this.buttonCont.UseVisualStyleBackColor = true;
            this.buttonCont.Click += new System.EventHandler(this.buttonCont_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRecord.Location = new System.Drawing.Point(353, 224);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(115, 44);
            this.buttonRecord.TabIndex = 10;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(353, 274);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(115, 43);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SPEECH TO TEXT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.buttonKonus);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 450);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(190, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.trackBarSpeed);
            this.panel2.Controls.Add(this.trackBarVolume);
            this.panel2.Controls.Add(this.buttonread);
            this.panel2.Controls.Add(this.buttonRecord);
            this.panel2.Controls.Add(this.buttonPause);
            this.panel2.Controls.Add(this.buttonCont);
            this.panel2.Location = new System.Drawing.Point(412, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 450);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Volume:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(910, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button buttonKonus;
        public System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.TrackBar trackBarVolume;
        public System.Windows.Forms.TrackBar trackBarSpeed;
        public System.Windows.Forms.Button buttonread;
        public System.Windows.Forms.Button buttonPause;
        public System.Windows.Forms.Button buttonCont;
        public System.Windows.Forms.Button buttonRecord;
        public System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.Button button1;
    }
}

