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
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech.AudioFormat;
using System.Net;
using Microsoft.DirectX.AudioVideoPlayback;
using WMPLib;
using System.Media;





namespace mpdenme
{
    public partial class Form1 : Form

    {
        SpeechRecognitionEngine speechRecognitionEngine = null;
        //SpeechRecognizer CAN = new SpeechRecognizer();
        SpeechSynthesizer CAN = new SpeechSynthesizer();
        WMPLib.WindowsMediaPlayer WindowsMediaPlayer = new WMPLib.WindowsMediaPlayer();
        public static String Oprax = Environment.UserName;
        


        string[] files, paths;



        public Form1()
        {
            InitializeComponent();
            //RadioBtn.Click += new EventHandler(RadioBtn_Click);
            try
            {
                speechRecognitionEngine = CreateSpeechEngine("en-US");
               // speechRecognitionEngine.AudioLevelUpdated += new EventHandler<SpeechRecognizedEventArgs>(engine_AudioLevelUpdate);
                speechRecognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);
                LoadGrammarAndCommands();
                speechRecognitionEngine.SetInputToDefaultAudioDevice();
                speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception)
            {
                CAN.SpeakAsync("");
            }
        }

            private void LoadGrammarAndCommands()
            {
            try
            {
                Choices texts = new Choices();
                string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "\\MediaPlayerCommand.txt");
                texts.Add(lines);
                Grammar wordList = new Grammar(new GrammarBuilder(texts));
                speechRecognitionEngine.LoadGrammar(wordList);
                

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        

        private void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = (e.Result.Text);


            switch (speech)
            {
                case "open playlist":
                case "add playlist":
                    CAN.Speak("choose , music file from your drivers");
                    BrowseBtn.PerformClick();
                    break;
                case "minimize":
                case "hide media player":
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Minimized;
                    TopMost = false;
                    break;
                case "show  media player":
                case "show media player again":
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Normal;
                    TopMost = true;
                    break;
                case "play":
                    button3.PerformClick();
                    break;
                case "fast forward":
                    button5.PerformClick();
                    break;
                case "fast reverse":
                    button1.PerformClick();
                    break;
                case "pause":
                    button4.PerformClick();
                    break;
                case "previous":
                    button2.PerformClick();
                    break;
                case "next":
                    button6.PerformClick();
                    break;
                case "mute":
                    button8.PerformClick();
                    break;
                case "exit media player":
                    button10.PerformClick();
                    break;

            }
        }

    private SpeechRecognitionEngine CreateSpeechEngine(string preferredCulture)
    {
        foreach (RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())
        {
            if (config.Culture.ToString() == preferredCulture)
            {
                speechRecognitionEngine = new SpeechRecognitionEngine(config);
                break;
            }
        }
        if (speechRecognitionEngine == null)
        {
            MessageBox.Show("The desired culture is not installed on this machine the speech-engine will continue using"
                + SpeechRecognitionEngine.InstalledRecognizers()[0].Culture.ToString() + "as the default culture .",
                "culture" + preferredCulture + "not found");
            speechRecognitionEngine = new SpeechRecognitionEngine(SpeechRecognitionEngine.InstalledRecognizers()[0]);

        }
        return speechRecognitionEngine;

        throw new NotImplementedException();
    }

       
        

            

        
        
        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CanMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (PlayList.SelectedIndex == 0)
                {
                    PlayList.SelectedIndex = 0;
                    PlayList.Update();
                }
                else
                {
                    CanMP.Ctlcontrols.previous();
                    PlayList.SelectedIndex -= 1;
                    PlayList.Update();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CanMP.Ctlcontrols.fastReverse();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            PlayList.SelectedIndex = 0;
            CanMP.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(CanMP.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                CanMP.Ctlcontrols.play();
            }
            else
            {
                CanMP.Ctlcontrols.pause();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CanMP.Ctlcontrols.fastForward();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(CanMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if(PlayList.SelectedIndex < (PlayList.Items.Count - 1))
                {
                    CanMP.Ctlcontrols.next();
                    PlayList.SelectedIndex += 1;
                    PlayList.Update();
                }
                else
                {
                    PlayList.SelectedIndex = 0;
                    PlayList.Update();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BrowseBtn.PerformClick();
        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
           CanMP.URL = paths[PlayList.SelectedIndex]; //hata var!!!!!
            
           


        }

        private void CanMP_Enter(object sender, EventArgs e)
        {


            


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CanMP.uiMode = "None";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            CanMP.settings.volume = trackBar1.Value;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(CanMP.settings.volume == 100)
            {
                CanMP.settings.volume = 0;
            }
            else
            {
                CanMP.settings.volume = 100;
            }
        }

        private void RadioBtn_Click(object sender, EventArgs e)
        {
        //    PlayList.Items.Add("AlemFm");
        //    PlayList.Items.Add("ASpor");
        //    PlayList.Items.Add("Virgin");
            //string adres = "https://muzikliste.blogspot.com/p/radyo-url-adresleri.html";
            //WebRequest istek = HttpWebRequest.Create(adres);
            //WebResponse cevap;
            //cevap = istek.GetResponse();
            //StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream());
            //string gelen = donenbilgiler.ReadToEnd();
            //int radyo = gelen.IndexOf("<td> http://46.20.7.125/listen.pls </td>");

            CanMP.URL = "http://turkmedya.radyotvonline.com/turkmedya/alemfm.stream/playlist.m3u8";
            PlayList.Items.Add("AlemFm");
            //
            //string CanMP.URL = string.Empty;
            //switch (PlayList.SelectedIndex)
            //{
            //    case 0:
            //       CanMP.URL = "http://turkmedya.radyotvonline.com/turkmedya/alemfm.stream/playlist.m3u8";
            //            break;
            //    case 1:
            //        URL = "http://trkvz-radyo.ercdn.net/rdaspor/rdaspor_1.m3u8";
            //            break;
            //    case 2:
            //        URL = "http://sc-virgin.mncdn.net:80/";
            //            break;
            //}


            //if (!URL.Equals("")) CanMP.URL = URL;





        }

        private void LiveTVBtn_Click(object sender, EventArgs e)
        {
            CanMP.URL = " https://blutv-beta.akamaized.net/kanaldhd/kanaldhd.smil/playlist.m3u8  ";
        }

        private void SongsBtn_Click(object sender, EventArgs e)
        {
            string Oprax = System.Environment.UserName;
            OpenFileDialog music = new OpenFileDialog();
            music.InitialDirectory = @"C:\Users\Oprax\muzikler";
            music.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv,mkv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|All files|*.*";
            music.Multiselect = true;
            if (music.ShowDialog() == DialogResult.OK)
            {

                files = music.SafeFileNames;
                paths = music.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    PlayList.Items.Add(files[i]);
                }
            }
                

        }

        private void AlbumsBtn_Click(object sender, EventArgs e)
        {
            string Oprax = System.Environment.UserName;
            OpenFileDialog albums = new OpenFileDialog();
            albums.InitialDirectory = @"C:\Users\Oprax\albums";
            albums.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv,mkv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|All files|*.*";
            albums.Multiselect = true;
            if (albums.ShowDialog() == DialogResult.OK)
            {

                files = albums.SafeFileNames;
                paths = albums.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    PlayList.Items.Add(files[i]);
                }
            }

        }

        private void ArtistBtn_Click(object sender, EventArgs e)
        {
            string Oprax = System.Environment.UserName;
            OpenFileDialog artist = new OpenFileDialog();
            artist.InitialDirectory = @"C:\Users\Oprax\artist";
            artist.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv,mkv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|All files|*.*";
            artist.Multiselect = true;
            if (artist.ShowDialog() == DialogResult.OK)
            {

                files = artist.SafeFileNames;
                paths = artist.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    PlayList.Items.Add(files[i]);
                }
            }
        }

        private void FilesBtn_Click(object sender, EventArgs e)
        {
            string Oprax = System.Environment.UserName;
            OpenFileDialog yf = new OpenFileDialog();
            yf.InitialDirectory = @"C:\Users\Oprax\yourfiles";
            yf.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv,mkv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|All files|*.*";
            yf.Multiselect = true;
            if (yf.ShowDialog() == DialogResult.OK)
            {

                files = yf.SafeFileNames;
                paths = yf.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    PlayList.Items.Add(files[i]);
                }
            }

        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            string Oprax = System.Environment.UserName;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Oprax";
            
            ofd.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv,mkv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg;*.mkv|all files|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int i = 0; i < files.Length; i++)
                {
                    PlayList.Items.Add(files[i]);
                }
            }
        }
    }
}
