namespace Llava
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
            textBoxAnswer = new TextBox();
            pictureBox1 = new PictureBox();
            buttonWoP = new Button();
            buttonClear = new Button();
            buttonLoadPicture = new Button();
            buttonPaste = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(14, 16);
            textBoxAnswer.Margin = new Padding(3, 4, 3, 4);
            textBoxAnswer.Multiline = true;
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(357, 291);
            textBoxAnswer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(406, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonWoP
            // 
            buttonWoP.Location = new Point(210, 336);
            buttonWoP.Margin = new Padding(3, 4, 3, 4);
            buttonWoP.Name = "buttonWoP";
            buttonWoP.Size = new Size(168, 75);
            buttonWoP.TabIndex = 3;
            buttonWoP.Text = "Zapytaj co jest na obrazku?";
            buttonWoP.UseVisualStyleBackColor = true;
            buttonWoP.Click += buttonWoP_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(14, 434);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(170, 60);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Wyczyść";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonLoadPicture
            // 
            buttonLoadPicture.Location = new Point(14, 336);
            buttonLoadPicture.Margin = new Padding(3, 4, 3, 4);
            buttonLoadPicture.Name = "buttonLoadPicture";
            buttonLoadPicture.Size = new Size(170, 75);
            buttonLoadPicture.TabIndex = 6;
            buttonLoadPicture.Text = "Wczytaj obrazek";
            buttonLoadPicture.UseVisualStyleBackColor = true;
            buttonLoadPicture.Click += buttonLoadPicture_Click;
            // 
            // buttonPaste
            // 
            buttonPaste.Location = new Point(210, 434);
            buttonPaste.Margin = new Padding(3, 4, 3, 4);
            buttonPaste.Name = "buttonPaste";
            buttonPaste.Size = new Size(168, 60);
            buttonPaste.TabIndex = 7;
            buttonPaste.Text = "Wklej";
            buttonPaste.UseVisualStyleBackColor = true;
            buttonPaste.Click += buttonPaste_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 515);
            Controls.Add(buttonPaste);
            Controls.Add(buttonLoadPicture);
            Controls.Add(buttonClear);
            Controls.Add(buttonWoP);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxAnswer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxAnswer;
        private PictureBox pictureBox1;
        private Button buttonWoP;
        private Button buttonClear;
        private Button buttonLoadPicture;
        private Button buttonPaste;
    }
}
