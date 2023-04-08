using CMusic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMusic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemLoad_Click(object sender, RoutedEventArgs e)
        {
            Tuple<MediaPlayer, TagLib.File> loader = MusicLoader.openAudio();
            MediaPlayer player = loader.Item1;
            TagLib.File file = loader.Item2;

            if (player != null)
            {
                player.Play();
                titleSongLabel.Content = file.Tag.Title;
            }
            else
            {
                throw new NullMediaPlayerStatement();
            }
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
    }

}
