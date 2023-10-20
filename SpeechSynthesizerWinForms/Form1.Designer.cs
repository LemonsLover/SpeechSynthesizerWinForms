namespace SpeechSynthesizerWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Execute = new Button();
            richTextBox_input = new RichTextBox();
            comboBox_instVoices = new ComboBox();
            SuspendLayout();
            // 
            // button_Execute
            // 
            button_Execute.Location = new Point(12, 258);
            button_Execute.Name = "button_Execute";
            button_Execute.Size = new Size(257, 54);
            button_Execute.TabIndex = 0;
            button_Execute.Text = "Execute";
            button_Execute.UseVisualStyleBackColor = true;
            button_Execute.Click += button_Execute_Click;
            // 
            // richTextBox_input
            // 
            richTextBox_input.Location = new Point(12, 12);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(257, 211);
            richTextBox_input.TabIndex = 1;
            richTextBox_input.Text = "Press 'Execute' to execute, duhh.";
            // 
            // comboBox_instVoices
            // 
            comboBox_instVoices.FormattingEnabled = true;
            comboBox_instVoices.Location = new Point(12, 229);
            comboBox_instVoices.Name = "comboBox_instVoices";
            comboBox_instVoices.Size = new Size(257, 23);
            comboBox_instVoices.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 326);
            Controls.Add(comboBox_instVoices);
            Controls.Add(richTextBox_input);
            Controls.Add(button_Execute);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Execute;
        private RichTextBox richTextBox_input;
        private ComboBox comboBox_instVoices;
    }
}