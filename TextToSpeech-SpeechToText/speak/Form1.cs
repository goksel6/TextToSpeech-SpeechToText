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
        //static SpeechRecognitionEngine engine;
        SpeechManager speechManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            speechManager = SpeechManager.Instance(this);
        }

        private void buttonKonus_Click(object sender, EventArgs e)
        {
            speechManager.Speak();
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
            speechManager.Record();
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
