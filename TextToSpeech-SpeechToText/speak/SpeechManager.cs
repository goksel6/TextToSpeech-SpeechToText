using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace speak
{
   public class SpeechManager 
    {
        static SpeechRecognitionEngine engine;
        static Form1 form1;
        private static SpeechManager instance;

        private SpeechManager(Form1 f)
        {
            form1 = f;
        }
        public static SpeechManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SpeechManager(form1);
                }
                return instance;
            }
        }
        

        void engine_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
        {
            form1.richTextBox1.Text = e.Result.Text;
        }

        public void Speak()
        {
            form1.buttonKonus.Text = "Running";
            engine = new SpeechRecognitionEngine();
            engine.SetInputToDefaultAudioDevice();
            Grammar g = new DictationGrammar();
            engine.LoadGrammar(g);
            engine.RecognizeAsync(RecognizeMode.Multiple);
            engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);
            Console.ReadLine();
        }
        public void Record()
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Rate = form1.trackBarSpeed.Value;
            ss.Volume = form1.trackBarVolume.Value;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WAwe Files| *.wav";
            sfd.ShowDialog();
            ss.SetOutputToWaveFile(sfd.FileName);
            ss.Speak(form1.richTextBox2.Text);
            ss.SetOutputToDefaultAudioDevice();
        }
    }
}
    

