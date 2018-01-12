using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace speak
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss;
        public Form1()
        {
            InitializeComponent();
        }
        Boolean flag=false;
        static SpeechRecognitionEngine engine;
        private void Form1_Load(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
        }

         void engine_SpeechRecognized (object ob, SpeechRecognizedEventArgs e)
        {
            richTextBox1.Text= e.Result.Text;   
        }
        private void buttonKonus_Click(object sender, EventArgs e)
        {
                flag = true;
                buttonKonus.Text = "Running";
                engine = new SpeechRecognitionEngine();
                engine.SetInputToDefaultAudioDevice();
                Grammar g = new DictationGrammar();
                engine.LoadGrammar(g);
                engine.RecognizeAsync(RecognizeMode.Multiple);
                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);
                Console.ReadLine();
      
        }


        //TextToSpeech
        private void buttonread_Click(object sender, EventArgs e)
        {
            ss.Rate = trackBarSpeed.Value;
            ss.Volume = trackBarVolume.Value;
            ss.SpeakAsync(richTextBox2.Text);
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            ss.Pause();
        }

        private void buttonCont_Click(object sender, EventArgs e)
        {
            ss.Resume();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Rate = trackBarSpeed.Value;
            ss.Volume = trackBarVolume.Value;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WAwe Files| *.wav";
            sfd.ShowDialog();
            ss.SetOutputToWaveFile(sfd.FileName);
            ss.Speak(richTextBox2.Text);
            ss.SetOutputToDefaultAudioDevice();
           // richTextBox2.Show("Recording Completed", "T2S");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
