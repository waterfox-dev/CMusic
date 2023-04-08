using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Navigation;

namespace CMusic.Utils
{
    class MusicLoader
    {
        public static Tuple<MediaPlayer, TagLib.File>? openAudio()
        { 
            MediaPlayer mediaPlayer = new MediaPlayer();   
            OpenFileDialog openFileDialog = new OpenFileDialog();
            TagLib.File tagFile;

            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

            if(openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
                tagFile = TagLib.File.Create(openFileDialog.FileName);
                return new Tuple<MediaPlayer, TagLib.File>(mediaPlayer, item2: tagFile);
            }

            return null;           
        }
    }
}
