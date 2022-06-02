namespace Tic_Tac_Toe
{
    partial class formTictactoe
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
            this.components = new System.ComponentModel.Container();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.rstButton = new System.Windows.Forms.Button();
            this.txtboxScoredisplay = new System.Windows.Forms.TextBox();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.tmrAI = new System.Windows.Forms.Timer(this.components);
            this.pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlBoard.Controls.Add(this.Btn9);
            this.pnlBoard.Controls.Add(this.Btn8);
            this.pnlBoard.Controls.Add(this.Btn7);
            this.pnlBoard.Controls.Add(this.Btn6);
            this.pnlBoard.Controls.Add(this.Btn5);
            this.pnlBoard.Controls.Add(this.Btn4);
            this.pnlBoard.Controls.Add(this.Btn3);
            this.pnlBoard.Controls.Add(this.Btn2);
            this.pnlBoard.Controls.Add(this.Btn1);
            this.pnlBoard.Location = new System.Drawing.Point(17, 20);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(636, 469);
            this.pnlBoard.TabIndex = 0;
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FloralWhite;
            this.Btn1.Location = new System.Drawing.Point(27, 25);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(150, 120);
            this.Btn1.TabIndex = 0;
            this.Btn1.Tag = "play";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FloralWhite;
            this.Btn2.Location = new System.Drawing.Point(242, 25);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(150, 120);
            this.Btn2.TabIndex = 1;
            this.Btn2.Tag = "play";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FloralWhite;
            this.Btn3.Location = new System.Drawing.Point(457, 25);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(150, 120);
            this.Btn3.TabIndex = 2;
            this.Btn3.Tag = "play";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FloralWhite;
            this.Btn4.Location = new System.Drawing.Point(27, 171);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(150, 120);
            this.Btn4.TabIndex = 3;
            this.Btn4.Tag = "play";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FloralWhite;
            this.Btn5.Location = new System.Drawing.Point(242, 171);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(150, 120);
            this.Btn5.TabIndex = 4;
            this.Btn5.Tag = "play";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FloralWhite;
            this.Btn6.Location = new System.Drawing.Point(457, 171);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(150, 120);
            this.Btn6.TabIndex = 5;
            this.Btn6.Tag = "play";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FloralWhite;
            this.Btn7.Location = new System.Drawing.Point(27, 321);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(150, 120);
            this.Btn7.TabIndex = 6;
            this.Btn7.Tag = "play";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FloralWhite;
            this.Btn8.Location = new System.Drawing.Point(242, 321);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(150, 120);
            this.Btn8.TabIndex = 7;
            this.Btn8.Tag = "play";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FloralWhite;
            this.Btn9.Location = new System.Drawing.Point(457, 321);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(150, 120);
            this.Btn9.TabIndex = 8;
            this.Btn9.Tag = "play";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.buttonClick);
            // 
            // rstButton
            // 
            this.rstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstButton.Location = new System.Drawing.Point(259, 528);
            this.rstButton.Name = "rstButton";
            this.rstButton.Size = new System.Drawing.Size(150, 55);
            this.rstButton.TabIndex = 1;
            this.rstButton.Text = "Reset";
            this.rstButton.UseVisualStyleBackColor = true;
            this.rstButton.Click += new System.EventHandler(this.resetGame);
            // 
            // txtboxScoredisplay
            // 
            this.txtboxScoredisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxScoredisplay.Location = new System.Drawing.Point(770, 45);
            this.txtboxScoredisplay.Name = "txtboxScoredisplay";
            this.txtboxScoredisplay.Size = new System.Drawing.Size(77, 34);
            this.txtboxScoredisplay.TabIndex = 2;
            this.txtboxScoredisplay.Text = "Score";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(675, 140);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(24, 25);
            this.lblScore1.TabIndex = 3;
            this.lblScore1.Text = "?";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(675, 191);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(24, 25);
            this.lblScore2.TabIndex = 4;
            this.lblScore2.Text = "?";
            // 
            // tmrAI
            // 
            this.tmrAI.Interval = 250;
            this.tmrAI.Tick += new System.EventHandler(this.playAi);
            // 
            // formTictactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.bgtictac;
            this.ClientSize = new System.Drawing.Size(957, 595);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.txtboxScoredisplay);
            this.Controls.Add(this.rstButton);
            this.Controls.Add(this.pnlBoard);
            this.Name = "formTictactoe";
            this.ShowIcon = false;
            this.Tag = "play";
            this.Text = "Versus Bot";
            this.pnlBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button rstButton;
        private System.Windows.Forms.TextBox txtboxScoredisplay;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Timer tmrAI;
    }
}

