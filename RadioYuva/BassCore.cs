using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Wma;
using Un4seen.Bass.AddOn.Tags;
using System.Windows.Forms;

namespace RadioYuva
{
     class BassCore
     {
          public int channel;
          public String state = "stopped";


          // trying
          private TAG_INFO _tagInfo;
          private SYNCPROC mySync;
          bool isWMA;
          public String status;
          public String title;
          

          public String currentState
          {
               get { return state; }
               set { state = value; }
          }

          public void setUpBass()
          {
               Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
               channel = Bass.BASS_StreamCreateURL("http://174.37.16.73:1725", 0,
               BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);

               if (channel == 0)
               {
                    title = "OFFLINE";

               }
               else
               {
                    title = "ready";
               }
               
          }



          public void createAndPlayStream()
          {

               title = "connecting...";

               try
               {

                    if (channel == 0)
                    {
                         setUpBass();
                    }


                    //try end
                    if (channel != 0)
                    {

                         if (currentState == "paused")
                         {
                              Bass.BASS_Start();
                         }

                         else
                         {
                              Bass.BASS_ChannelPlay(channel, true);
                         }
                    }
               }
               catch (ArgumentNullException e)
               {
                    title = "OFFLINE";
               }
          }
               public void pauseStream()
               {
                    Bass.BASS_Pause();
               }

               public void stopStream()
               {
              
                    Bass.BASS_Stop();
                    Bass.BASS_Free();
                    channel = 0;
               
               }
               public void refreshStream()
               {
                    Bass.BASS_Stop();
                    Bass.BASS_Free();
                    channel = 0;
                    createAndPlayStream();
               }


               public void bufferAndTitle() { 
          
               //try
                    if (channel != 0)
                    {
                         _tagInfo = new TAG_INFO("http://174.37.16.73:1725");
                         BASS_CHANNELINFO info = Bass.BASS_ChannelGetInfo(channel);
                         if (info.ctype == BASSChannelType.BASS_CTYPE_STREAM_WMA)
                              isWMA = true;
                         // ok, do some pre-buffering...
                         status = ""; // don't need any default values e.g. 100%
                         if (!isWMA)
                         {
                              // display buffering for MP3, OGG...
                              while (true)
                              {
                                   long len = Bass.BASS_StreamGetFilePosition(channel, BASSStreamFilePosition.BASS_FILEPOS_END);
                                   if (len == -1)
                                        break; // typical for WMA streams
                                   // percentage of buffer filled
                                   float progress = (
                                        Bass.BASS_StreamGetFilePosition(channel, BASSStreamFilePosition.BASS_FILEPOS_DOWNLOAD) -
                                        Bass.BASS_StreamGetFilePosition(channel, BASSStreamFilePosition.BASS_FILEPOS_CURRENT)
                                        ) * 100f / len;

                                   if (progress > 75f)
                                   {
                                        break; // over 75% full, enough
                                   }

                                   status = String.Format("{0}%", progress);
                              }
                         }
                         else
                         {
                              // display buffering for WMA...
                              while (true)
                              {
                                   long len = Bass.BASS_StreamGetFilePosition(channel, BASSStreamFilePosition.BASS_FILEPOS_WMA_BUFFER);
                                   if (len == -1L)
                                        break;
                                   // percentage of buffer filled
                                   if (len > 75L)
                                   {
                                        break; // over 75% full, enough
                                   }

                                   status = String.Format("{0}%", len);
                              }
                         }


                         // Titles from the Shoutcast player is retrieved here.

                         string[] icy = Bass.BASS_ChannelGetTagsICY(channel);
                         //if (icy == null)
                         //{
                         //     // try http...
                         //     icy = Bass.BASS_ChannelGetTagsHTTP(channel);
                         //}
                         //if (icy != null)
                         //{
                         //     foreach (string tag in icy)
                         //     {
                         //          title += "ICY: " + tag + Environment.NewLine;
                         //     }
                         //}
                         // get the initial meta data (streamed title...)

                         icy = Bass.BASS_ChannelGetTagsMETA(channel);
                         if (icy != null)
                         {
                              foreach (string tag in icy)
                              {
                                   title = tag;
                              }
                         }
                         else
                         {
                              // an ogg stream meta can be obtained here
                              icy = Bass.BASS_ChannelGetTagsOGG(channel);
                              if (icy != null)
                              {
                                   foreach (string tag in icy)
                                   {
                                        title = tag;
                                   }
                              }
                         }

                    } // channel != 0 check end here.
                    else
                    {
                              title = "OFFLINE";
                    }
          
          
               } // bufferAnd Title

     }
}
