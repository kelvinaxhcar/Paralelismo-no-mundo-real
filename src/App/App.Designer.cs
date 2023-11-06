namespace App
{
    partial class App
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
            buttonExecutar = new Button();
            richTextBox = new RichTextBox();
            labeltempo = new Label();
            labelTempoFinal = new Label();
            SuspendLayout();
            // 
            // buttonExecutar
            // 
            buttonExecutar.Location = new Point(533, 237);
            buttonExecutar.Name = "buttonExecutar";
            buttonExecutar.Size = new Size(75, 23);
            buttonExecutar.TabIndex = 0;
            buttonExecutar.Text = "Executar";
            buttonExecutar.UseVisualStyleBackColor = true;
            buttonExecutar.Click += AoClicarEmExecutar;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 12);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(596, 213);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            // 
            // labeltempo
            // 
            labeltempo.AutoSize = true;
            labeltempo.Location = new Point(12, 245);
            labeltempo.Name = "labeltempo";
            labeltempo.Size = new Size(43, 15);
            labeltempo.TabIndex = 2;
            labeltempo.Text = "Tempo\r\n";
            labeltempo.Click += label1_Click;
            // 
            // labelTempoFinal
            // 
            labelTempoFinal.AutoSize = true;
            labelTempoFinal.Location = new Point(74, 245);
            labelTempoFinal.Name = "labelTempoFinal";
            labelTempoFinal.Size = new Size(0, 15);
            labelTempoFinal.TabIndex = 3;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 275);
            Controls.Add(labelTempoFinal);
            Controls.Add(labeltempo);
            Controls.Add(richTextBox);
            Controls.Add(buttonExecutar);
            Name = "App";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExecutar;
        private RichTextBox richTextBox;
        private Label labeltempo;
        private Label labelTempoFinal;
    }
}