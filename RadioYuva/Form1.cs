using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Un4seen.Bass;


namespace RadioYuva
{
     public partial class Form1 : Form
     {
         
          ToolTip tTip = new ToolTip();
          BassCore bc = new BassCore();
          
          public Form1()
          {
               String email = "gsaxam@gmail.com";
               String regKey = "2X15282216152222";
               BassNet.Registration(email, regKey);

               // setup bass for first use
               bc.setUpBass();
               
               
               InitializeComponent();

               if (bc.state != null)
               {
                    title.Text = bc.title;
               }
          }

          private void Form1_Load(object sender, EventArgs e)
          {
              
          }

          
          private void playButton_Click(object sender, EventArgs e)
          {
               
               bc.createAndPlayStream();
               setDefVolume();
               if (bc.channel != 0)
               {
                    changeState(bc.currentState);
                    bc.bufferAndTitle();
                    updateMeta();
               }
               
          }


          private void pauseButton_Click(object sender, EventArgs e)
          {
               
               bc.pauseStream();
               changeState(bc.currentState);
          }

           private void stopButton_Click(object sender, EventArgs e)
          {
               bc.stopStream();
               label1.Text = bc.currentState = "stopped by user";
               changeState(bc.currentState);

                
          }
           private void refreshButton_Click(object sender, EventArgs e)
           {
                bc.refreshStream();
                setDefVolume();
                playButton.Hide();
                pauseButton.Show();
           }
          public void changeState(String state)
          {
               if (state == "stopped") 
               {
                    playButton.Hide();
                    pauseButton.Show();
                    refreshButton.Show();
                    refreshOffButton.Hide();
                    label1.Text = bc.currentState = "playing";
                    
               }
               else if (state == "playing")
               {
                    pauseButton.Hide();
                    playButton.Show();
                    refreshButton.Hide();
                    refreshOffButton.Show();
                    label1.Text = bc.currentState = "paused";
                   
               }
               else if (state == "paused")
               {
                    playButton.Hide();
                    pauseButton.Show();
                    refreshButton.Show();
                    refreshOffButton.Hide();
                    label1.Text = bc.currentState = "playing";
                  
               }
               else if (state == "stopped by user")
               {
                    playButton.Show();
                    pauseButton.Hide();
                    refreshButton.Hide();
                    refreshOffButton.Show();
                    label1.Text = bc.currentState = "stopped";

               }
               else if (state == "OFFLINE")
               {
                    playButton.Show();
                    pauseButton.Hide();
                    refreshButton.Hide();
                    refreshOffButton.Show();
                    label1.Text = bc.currentState = "stopped";

               }
          }

          public void setDefVolume()
          {
               Bass.BASS_ChannelSetAttribute(bc.channel, BASSAttribute.BASS_ATTRIB_VOL, trackBar.Value / (float)10);
          }

          private void trackBar_Scroll(object sender, EventArgs e)
          {
               Bass.BASS_ChannelSetAttribute(bc.channel, BASSAttribute.BASS_ATTRIB_VOL, trackBar.Value / (float)10);

               tTip.SetToolTip(trackBar, (trackBar.Value*10)+"%".ToString());
          }

          private void button1_Click_1(object sender, EventArgs e)
          {
               
               float vol = Bass.BASS_GetVolume();
               //Bass.BASS_ChannelSetAttribute(vol * 100);

          }

          public void updateMeta()
          {
               //string preTitle = bc.title.Substring(bc.title.IndexOf(':', bc.title.LastIndexOf(";")));
               title.Text = "";
               statusBar.Text = bc.status;
               if (bc.channel != 0)
               {
                    string preTitle = bc.title.Substring(13);
                    if (preTitle.Length != 0)
                    {
                         title.Text = preTitle.Substring(0, (preTitle.Length) - 2);
                    }
               }
          }

          private void title_Click(object sender, EventArgs e)
          {

          }

          private void richTextBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void timer1_Tick(object sender, EventArgs e)
          {
               // when stopped the stream is releases and will return exception on title update.
               if (bc.channel != 0 && bc.state != "stopped") 
               {
                    bc.bufferAndTitle();
                    updateMeta();
                    //MessageBox.Show("10 secs");
               }
               else
               {
                    title.Text = "Not Available";
                    bc.state = "OFFLINE";
                    bc.stopStream();
                    changeState(bc.currentState);
               }
          }

          private void statusBar_Click(object sender, EventArgs e)
          {

          }

          private void pictureBox1_Click(object sender, EventArgs e)
          {
               if (aboutBox.Visible == true)
               {
                    aboutBox.Hide();
               }
               else
               {
                    aboutBox.Show();
               }


          }
          
          

         

          
     }

          
}
