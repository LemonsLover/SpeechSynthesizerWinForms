using System.Speech.Synthesis;

namespace SpeechSynthesizerWinForms
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer speechSynthesizer;

        public Form1()
        {
            InitializeComponent();

            speechSynthesizer = new SpeechSynthesizer();

            comboBox_instVoices.Items.AddRange(speechSynthesizer.GetInstalledVoices().Select(iv => iv.VoiceInfo.Name).ToArray());
            comboBox_instVoices.SelectedIndex = 0;
        }

        private void button_Execute_Click(object sender, EventArgs e)
        {
            speechSynthesizer.SelectVoice(comboBox_instVoices.SelectedItem as string);

            Task.Run(() => speechSynthesizer.Speak(richTextBox_input.Text));
        }
    }
}