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
            textBoxQuestion = new TextBox();
            textBoxAnswer = new TextBox();
            pictureBox1 = new PictureBox();
            buttonWoP = new Button();
            buttonClear = new Button();
            buttonSend = new Button();
            buttonLoadPicture = new Button();
            buttonPaste = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Location = new Point(12, 12);
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(313, 140);
            textBoxQuestion.TabIndex = 0;
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(12, 169);
            textBoxAnswer.Multiline = true;
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(313, 140);
            textBoxAnswer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(344, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 426);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonWoP
            // 
            buttonWoP.Location = new Point(12, 328);
            buttonWoP.Name = "buttonWoP";
            buttonWoP.Size = new Size(166, 23);
            buttonWoP.TabIndex = 3;
            buttonWoP.Text = "Zapytaj co jest na obrazku?";
            buttonWoP.UseVisualStyleBackColor = true;
            buttonWoP.Click += buttonWoP_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(12, 368);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(166, 23);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Wyczyść";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(12, 406);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(166, 23);
            buttonSend.TabIndex = 5;
            buttonSend.Text = "Wyślij";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonLoadPicture
            // 
            buttonLoadPicture.Location = new Point(184, 328);
            buttonLoadPicture.Name = "buttonLoadPicture";
            buttonLoadPicture.Size = new Size(141, 23);
            buttonLoadPicture.TabIndex = 6;
            buttonLoadPicture.Text = "Wczytaj obrazek";
            buttonLoadPicture.UseVisualStyleBackColor = true;
            buttonLoadPicture.Click += buttonLoadPicture_Click;
            // 
            // buttonPaste
            // 
            buttonPaste.Location = new Point(184, 368);
            buttonPaste.Name = "buttonPaste";
            buttonPaste.Size = new Size(141, 23);
            buttonPaste.TabIndex = 7;
            buttonPaste.Text = "Wklej";
            buttonPaste.UseVisualStyleBackColor = true;
            buttonPaste.Click += buttonPaste_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPaste);
            Controls.Add(buttonLoadPicture);
            Controls.Add(buttonSend);
            Controls.Add(buttonClear);
            Controls.Add(buttonWoP);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxAnswer);
            Controls.Add(textBoxQuestion);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxQuestion;
        private TextBox textBoxAnswer;
        private PictureBox pictureBox1;
        private Button buttonWoP;
        private Button buttonClear;
        private Button buttonSend;
        private Button buttonLoadPicture;
        private Button buttonPaste;
    }
}
