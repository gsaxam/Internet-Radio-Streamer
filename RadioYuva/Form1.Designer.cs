namespace RadioYuva
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
               this.pauseButton = new System.Windows.Forms.PictureBox();
               this.playButton = new System.Windows.Forms.PictureBox();
               this.stopButton = new System.Windows.Forms.PictureBox();
               this.refreshButton = new System.Windows.Forms.PictureBox();
               this.refreshOffButton = new System.Windows.Forms.PictureBox();
               this.trackBar = new System.Windows.Forms.TrackBar();
               this.statusBar = new System.Windows.Forms.Label();
               this.title = new System.Windows.Forms.Label();
               this.timer1 = new System.Windows.Forms.Timer(this.components);
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.aboutBox = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.stopButton)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.refreshOffButton)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.aboutBox)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(224, 193);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(56, 14);
               this.label1.TabIndex = 3;
               this.label1.Text = "stopped";
               // 
               // pauseButton
               // 
               this.pauseButton.BackColor = System.Drawing.Color.Transparent;
               this.pauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
               this.pauseButton.Image = global::RadioYuva.Properties.Resources.pause;
               this.pauseButton.Location = new System.Drawing.Point(239, 264);
               this.pauseButton.Name = "pauseButton";
               this.pauseButton.Size = new System.Drawing.Size(27, 23);
               this.pauseButton.TabIndex = 2;
               this.pauseButton.TabStop = false;
               this.pauseButton.Visible = false;
               this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
               // 
               // playButton
               // 
               this.playButton.BackColor = System.Drawing.Color.Transparent;
               this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
               this.playButton.Image = global::RadioYuva.Properties.Resources.round_play_glow;
               this.playButton.Location = new System.Drawing.Point(218, 244);
               this.playButton.Name = "playButton";
               this.playButton.Size = new System.Drawing.Size(72, 72);
               this.playButton.TabIndex = 1;
               this.playButton.TabStop = false;
               this.playButton.Click += new System.EventHandler(this.playButton_Click);
               // 
               // stopButton
               // 
               this.stopButton.BackColor = System.Drawing.Color.Transparent;
               this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
               this.stopButton.Image = global::RadioYuva.Properties.Resources.stop;
               this.stopButton.Location = new System.Drawing.Point(181, 266);
               this.stopButton.Name = "stopButton";
               this.stopButton.Size = new System.Drawing.Size(22, 21);
               this.stopButton.TabIndex = 8;
               this.stopButton.TabStop = false;
               this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
               // 
               // refreshButton
               // 
               this.refreshButton.BackColor = System.Drawing.Color.Transparent;
               this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
               this.refreshButton.Image = global::RadioYuva.Properties.Resources.refresh;
               this.refreshButton.Location = new System.Drawing.Point(303, 263);
               this.refreshButton.Name = "refreshButton";
               this.refreshButton.Size = new System.Drawing.Size(22, 29);
               this.refreshButton.TabIndex = 9;
               this.refreshButton.TabStop = false;
               this.refreshButton.Visible = false;
               this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
               // 
               // refreshOffButton
               // 
               this.refreshOffButton.BackColor = System.Drawing.Color.Transparent;
               this.refreshOffButton.Cursor = System.Windows.Forms.Cursors.Default;
               this.refreshOffButton.Image = global::RadioYuva.Properties.Resources.refresh_off;
               this.refreshOffButton.Location = new System.Drawing.Point(303, 263);
               this.refreshOffButton.Name = "refreshOffButton";
               this.refreshOffButton.Size = new System.Drawing.Size(23, 29);
               this.refreshOffButton.TabIndex = 10;
               this.refreshOffButton.TabStop = false;
               // 
               // trackBar
               // 
               this.trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.trackBar.Location = new System.Drawing.Point(103, 236);
               this.trackBar.Name = "trackBar";
               this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
               this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
               this.trackBar.Size = new System.Drawing.Size(45, 74);
               this.trackBar.TabIndex = 11;
               this.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
               this.trackBar.Value = 3;
               this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
               // 
               // statusBar
               // 
               this.statusBar.AutoSize = true;
               this.statusBar.BackColor = System.Drawing.Color.Transparent;
               this.statusBar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.statusBar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
               this.statusBar.Location = new System.Drawing.Point(288, 194);
               this.statusBar.Name = "statusBar";
               this.statusBar.Size = new System.Drawing.Size(0, 14);
               this.statusBar.TabIndex = 13;
               this.statusBar.Click += new System.EventHandler(this.statusBar_Click);
               // 
               // title
               // 
               this.title.AutoEllipsis = true;
               this.title.BackColor = System.Drawing.Color.Transparent;
               this.title.ForeColor = System.Drawing.Color.DarkSlateGray;
               this.title.Location = new System.Drawing.Point(136, 210);
               this.title.Name = "title";
               this.title.Size = new System.Drawing.Size(232, 16);
               this.title.TabIndex = 14;
               this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.title.Click += new System.EventHandler(this.title_Click);
               // 
               // timer1
               // 
               this.timer1.Enabled = true;
               this.timer1.Interval = 10000;
               this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
               this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
               this.pictureBox1.Image = global::RadioYuva.Properties.Resources.info;
               this.pictureBox1.Location = new System.Drawing.Point(485, 294);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(19, 20);
               this.pictureBox1.TabIndex = 15;
               this.pictureBox1.TabStop = false;
               this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
               // 
               // aboutBox
               // 
               this.aboutBox.BackColor = System.Drawing.Color.Transparent;
               this.aboutBox.Image = global::RadioYuva.Properties.Resources.about;
               this.aboutBox.Location = new System.Drawing.Point(173, 94);
               this.aboutBox.Name = "aboutBox";
               this.aboutBox.Size = new System.Drawing.Size(248, 92);
               this.aboutBox.TabIndex = 16;
               this.aboutBox.TabStop = false;
               this.aboutBox.Visible = false;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightSkyBlue;
               this.BackgroundImage = global::RadioYuva.Properties.Resources.layout;
               this.ClientSize = new System.Drawing.Size(504, 313);
               this.Controls.Add(this.aboutBox);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.title);
               this.Controls.Add(this.statusBar);
               this.Controls.Add(this.trackBar);
               this.Controls.Add(this.refreshButton);
               this.Controls.Add(this.stopButton);
               this.Controls.Add(this.pauseButton);
               this.Controls.Add(this.playButton);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.refreshOffButton);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
               this.MaximizeBox = false;
               this.Name = "Form1";
               this.Text = "Radio Yuva";
               this.Load += new System.EventHandler(this.Form1_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.stopButton)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.refreshOffButton)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.aboutBox)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.PictureBox pauseButton;
          private System.Windows.Forms.PictureBox playButton;
          private System.Windows.Forms.PictureBox stopButton;
          private System.Windows.Forms.PictureBox refreshButton;
          private System.Windows.Forms.PictureBox refreshOffButton;
          private System.Windows.Forms.TrackBar trackBar;
          private System.Windows.Forms.Label statusBar;
          private System.Windows.Forms.Label title;
          private System.Windows.Forms.Timer timer1;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.PictureBox aboutBox;
     }
}

