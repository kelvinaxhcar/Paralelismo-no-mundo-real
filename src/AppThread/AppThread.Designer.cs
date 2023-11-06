namespace AppThread
{
    partial class AppThread
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
            labelTempoFinal = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonExecutar
            // 
            buttonExecutar.Location = new Point(606, 376);
            buttonExecutar.Name = "buttonExecutar";
            buttonExecutar.Size = new Size(94, 29);
            buttonExecutar.TabIndex = 0;
            buttonExecutar.Text = "Executar";
            buttonExecutar.UseVisualStyleBackColor = true;
            buttonExecutar.Click += AoClicarEmExecutar;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(40, 38);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(524, 297);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            // 
            // labelTempoFinal
            // 
            labelTempoFinal.AutoSize = true;
            labelTempoFinal.Location = new Point(114, 385);
            labelTempoFinal.Name = "labelTempoFinal";
            labelTempoFinal.Size = new Size(0, 20);
            labelTempoFinal.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 385);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Tempo";
            label1.Click += label1_Click;
            // 
            // AppThread
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 450);
            Controls.Add(label1);
            Controls.Add(labelTempoFinal);
            Controls.Add(richTextBox);
            Controls.Add(buttonExecutar);
            Name = "AppThread";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExecutar;
        private RichTextBox richTextBox;
        private Label labelTempoFinal;
        private Label label1;
    }
}