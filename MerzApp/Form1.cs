using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using WMPLib;

namespace MerzApp
{
    public partial class Form1 : Form
    {

        private int numOfFiles;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Function for creating playlist and playing it.
        /// </summary>
        private void startPlay()
        {
            mediaPlayer.currentPlaylist.clear();
            ListViewItem it;
            String filePath;
            IWMPMedia videoFile;
            IWMPPlaylist myPlaylist = mediaPlayer.playlistCollection.newPlaylist("playlist");
            
            Debug.WriteLine(mediaPlayer.openState);
            mediaPlayer.settings.setMode("loop", true);
            

            for (int i = 1; i<=numOfFiles; i++)
            {
                it = listOfFiles.FindItemWithText("" + i);
                filePath = it.Text;
                videoFile = mediaPlayer.newMedia(filePath);
                myPlaylist.appendItem(videoFile);
            }
            mediaPlayer.currentPlaylist = myPlaylist;
        }

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Function which is started, after the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            log.Info("App started");
        }

        /// <summary>
        /// Turn off the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// This loads data about videos from the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLoad_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            Stream stream = null;
            TextReader reader = null;
            numOfFiles = 0;

            openFile.InitialDirectory = @"c:\";
            openFile.Filter = "txt files (*.txt)|*.txt|config files (*.config)|*.config|All files *.*|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            listOfFiles.Items.Clear();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFile.OpenFile()) != null)
                    {
                        Debug.WriteLine(stream);
                        using (stream)
                        {
                            using (reader = new StreamReader(stream))
                            {
                                
                                String line = reader.ReadLine();
                                String[] splitedLine;
                                while (line!=null)
                                {
                                    numOfFiles += 1;
                                    splitedLine = line.Split('#');
                                    listOfFiles.Items.Add(splitedLine[0]).SubItems.Add(splitedLine[1]);
                                    Debug.WriteLine(line);
                                    line = reader.ReadLine();
                                    
                                }
                                startPlay();
                            }
                            reader.Close();
                        }
                        stream.Close();
                        
                    }
                }
                catch (Exception ex)
                {
                    log.Error("error while opening configuration file" + ex.Message);
                }
            }
        }

        /// <summary>
        /// Function for handling error in media.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            String currentFile = mediaPlayer.currentMedia.name;
            log.Error("error while playing file " + currentFile);   
        }

        /// <summary>
        /// Function which creates log when media is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mediaPlayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            String currentFile;
            if (mediaPlayer.openState == WMPOpenState.wmposMediaOpen)
            {
                
                currentFile = mediaPlayer.currentMedia.name;
                log.Info("started playing " + currentFile);
                labelFileName.Text = currentFile;
            }
        }

        /// <summary>
        /// Function which creates log when playlist is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mediaPlayer_PlaylistChange(object sender, AxWMPLib._WMPOCXEvents_PlaylistChangeEvent e)
        {
            log.Info("sequence changed to " + mediaPlayer.currentPlaylist.name);
        }

        /// <summary>
        /// This handles Play states for loging.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            String currentFile;
            if (mediaPlayer.playState == WMPPlayState.wmppsMediaEnded)
            {
                currentFile = mediaPlayer.currentMedia.name;
                log.Info("ended playing " + currentFile);
            }
        }

        /// <summary>
        /// changing size of components inside form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            mediaPlayer.Size = new Size(this.Size.Width - 39, this.Size.Height - 210);
            listOfFiles.Size = new Size(this.Size.Width - 39, listOfFiles.Size.Height);
        }
    }
}
