using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3_Player
{
    public partial class Mp3_Player : Form
    {
        public Mp3_Player()
        {
            InitializeComponent();
        }

        public class MediaFile
        {
            public string FileName { get; set; }
            public string Path { get; set; }
        }

        private void Mp3_Player_Load(object sender, EventArgs e)
        {

            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";

        }

        // ********* Change Index of ListFile

        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Open media file
            MediaFile file = listFile.SelectedItem as MediaFile;
            if (file != null)
            {
                axWindowsMediaPlayer.URL = file.Path;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }


        // ********* Open Button Click

        private void open_Button(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Add file to play list
                    List<MediaFile> files = new List<MediaFile>();
                    foreach (string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    listFile.DataSource = files;
                }
            }

        }

        
    }
}
