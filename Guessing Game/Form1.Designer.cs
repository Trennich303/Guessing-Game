
namespace Guessing_Game
{
    partial class GuessButton
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
            this.GuessingGameTitle = new System.Windows.Forms.Label();
            this.GuessANumberLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GuessingGameTitle
            // 
            this.GuessingGameTitle.AutoSize = true;
            this.GuessingGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessingGameTitle.ForeColor = System.Drawing.Color.White;
            this.GuessingGameTitle.Location = new System.Drawing.Point(230, 45);
            this.GuessingGameTitle.Name = "GuessingGameTitle";
            this.GuessingGameTitle.Size = new System.Drawing.Size(408, 61);
            this.GuessingGameTitle.TabIndex = 1;
            this.GuessingGameTitle.Text = "Guessing Game";
            // 
            // GuessANumberLabel
            // 
            this.GuessANumberLabel.AutoSize = true;
            this.GuessANumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessANumberLabel.ForeColor = System.Drawing.Color.White;
            this.GuessANumberLabel.Location = new System.Drawing.Point(213, 162);
            this.GuessANumberLabel.Name = "GuessANumberLabel";
            this.GuessANumberLabel.Size = new System.Drawing.Size(457, 31);
            this.GuessANumberLabel.TabIndex = 2;
            this.GuessANumberLabel.Text = "Guess a Number Between 1 and 100";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(382, 271);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 31);
            this.InputTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(349, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guess";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.Color.Black;
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.ForeColor = System.Drawing.Color.White;
            this.OutputTextBox.Location = new System.Drawing.Point(349, 521);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(150, 31);
            this.OutputTextBox.TabIndex = 5;
            // 
            // GuessButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(918, 630);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.GuessANumberLabel);
            this.Controls.Add(this.GuessingGameTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GuessButton";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuessingGameTitle;
        private System.Windows.Forms.Label GuessANumberLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

