namespace KanaPractice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guessbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.maintextbox = new System.Windows.Forms.TextBox();
            this.entrytextbox = new System.Windows.Forms.TextBox();
            this.resultlabel = new System.Windows.Forms.Label();
            this.hiraganaButton = new System.Windows.Forms.RadioButton();
            this.katakanabutton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // guessbutton
            // 
            this.guessbutton.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.guessbutton.Location = new System.Drawing.Point(12, 226);
            this.guessbutton.Name = "guessbutton";
            this.guessbutton.Size = new System.Drawing.Size(75, 23);
            this.guessbutton.TabIndex = 2;
            this.guessbutton.Text = "Guess";
            this.guessbutton.UseVisualStyleBackColor = true;
            this.guessbutton.Click += new System.EventHandler(this.guessbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exitbutton.Location = new System.Drawing.Point(197, 226);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.welcomelabel.Location = new System.Drawing.Point(12, 9);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(253, 19);
            this.welcomelabel.TabIndex = 2;
            this.welcomelabel.Text = "Welcome to Kana Practice!";
            // 
            // maintextbox
            // 
            this.maintextbox.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maintextbox.Location = new System.Drawing.Point(12, 54);
            this.maintextbox.Multiline = true;
            this.maintextbox.Name = "maintextbox";
            this.maintextbox.Size = new System.Drawing.Size(260, 127);
            this.maintextbox.TabIndex = 3;
            // 
            // entrytextbox
            // 
            this.entrytextbox.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrytextbox.Location = new System.Drawing.Point(12, 200);
            this.entrytextbox.Name = "entrytextbox";
            this.entrytextbox.Size = new System.Drawing.Size(260, 20);
            this.entrytextbox.TabIndex = 1;
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultlabel.Location = new System.Drawing.Point(13, 184);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(217, 13);
            this.resultlabel.TabIndex = 5;
            this.resultlabel.Text = "Right Answers: 0    Wrong Answers: 0";
            // 
            // hiraganaButton
            // 
            this.hiraganaButton.AutoSize = true;
            this.hiraganaButton.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiraganaButton.Location = new System.Drawing.Point(63, 31);
            this.hiraganaButton.Name = "hiraganaButton";
            this.hiraganaButton.Size = new System.Drawing.Size(72, 17);
            this.hiraganaButton.TabIndex = 6;
            this.hiraganaButton.TabStop = true;
            this.hiraganaButton.Text = "Hiragana";
            this.hiraganaButton.UseVisualStyleBackColor = true;
            this.hiraganaButton.CheckedChanged += new System.EventHandler(this.hiraganaButton_CheckedChanged);
            // 
            // katakanabutton
            // 
            this.katakanabutton.AutoSize = true;
            this.katakanabutton.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.katakanabutton.Location = new System.Drawing.Point(141, 31);
            this.katakanabutton.Name = "katakanabutton";
            this.katakanabutton.Size = new System.Drawing.Size(75, 17);
            this.katakanabutton.TabIndex = 7;
            this.katakanabutton.TabStop = true;
            this.katakanabutton.Text = "Katakana";
            this.katakanabutton.UseVisualStyleBackColor = true;
            this.katakanabutton.CheckedChanged += new System.EventHandler(this.katakanabutton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.katakanabutton);
            this.Controls.Add(this.hiraganaButton);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.entrytextbox);
            this.Controls.Add(this.maintextbox);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.guessbutton);
            this.Name = "Form1";
            this.Text = "Kana Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.TextBox maintextbox;
        private System.Windows.Forms.TextBox entrytextbox;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.RadioButton hiraganaButton;
        private System.Windows.Forms.RadioButton katakanabutton;
    }
}

