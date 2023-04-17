
namespace _xox_app
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
            this.txtbox = new System.Windows.Forms.TextBox();
            this.Score = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.StartResetButton = new System.Windows.Forms.Button();
            this.ScoreResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(19, 18);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(268, 22);
            this.txtbox.TabIndex = 0;
            this.txtbox.Text = "Student Number";
            this.txtbox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(310, 20);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(49, 17);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 88);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(131, 129);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "-";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(149, 88);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(131, 129);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "-";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(286, 88);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(131, 129);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "-";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(286, 223);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(131, 129);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "-";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(149, 223);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(131, 129);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "-";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 223);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(131, 129);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "-";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(286, 358);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(131, 129);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "-";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(149, 358);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(131, 129);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "-";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 358);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(131, 129);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "-";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // StartResetButton
            // 
            this.StartResetButton.BackColor = System.Drawing.Color.DarkGray;
            this.StartResetButton.Enabled = false;
            this.StartResetButton.Location = new System.Drawing.Point(149, 507);
            this.StartResetButton.Name = "StartResetButton";
            this.StartResetButton.Size = new System.Drawing.Size(131, 49);
            this.StartResetButton.TabIndex = 11;
            this.StartResetButton.Text = "START GAME";
            this.StartResetButton.UseVisualStyleBackColor = false;
            this.StartResetButton.Click += new System.EventHandler(this.StartResetButton_Click);
            // 
            // ScoreResult
            // 
            this.ScoreResult.AutoSize = true;
            this.ScoreResult.Location = new System.Drawing.Point(365, 20);
            this.ScoreResult.Name = "ScoreResult";
            this.ScoreResult.Size = new System.Drawing.Size(0, 17);
            this.ScoreResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(433, 568);
            this.Controls.Add(this.ScoreResult);
            this.Controls.Add(this.StartResetButton);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.txtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button StartResetButton;
        private System.Windows.Forms.Label ScoreResult;
    }
}

