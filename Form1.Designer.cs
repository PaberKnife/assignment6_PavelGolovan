namespace assignment6_PavelGolovan
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
            this.userLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Garamond", 19F, System.Drawing.FontStyle.Bold);
            this.userLabel.Location = new System.Drawing.Point(191, 18);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(65, 29);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "You:";
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("Garamond", 19F, System.Drawing.FontStyle.Bold);
            this.computerLabel.Location = new System.Drawing.Point(427, 18);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(131, 29);
            this.computerLabel.TabIndex = 1;
            this.computerLabel.Text = "Computer:";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Garamond", 19F);
            this.clearButton.Location = new System.Drawing.Point(12, 487);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 39);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Restart";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Garamond", 19F);
            this.exitButton.Location = new System.Drawing.Point(601, 487);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 39);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Font = new System.Drawing.Font("Garamond", 19F);
            this.rockButton.Location = new System.Drawing.Point(200, 328);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(101, 39);
            this.rockButton.TabIndex = 6;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Font = new System.Drawing.Font("Garamond", 19F);
            this.paperButton.Location = new System.Drawing.Point(307, 328);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(101, 39);
            this.paperButton.TabIndex = 7;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorsButton
            // 
            this.scissorsButton.Font = new System.Drawing.Font("Garamond", 19F);
            this.scissorsButton.Location = new System.Drawing.Point(414, 328);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(101, 39);
            this.scissorsButton.TabIndex = 8;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Font = new System.Drawing.Font("Garamond", 19F, System.Drawing.FontStyle.Bold);
            this.resultLabel.Location = new System.Drawing.Point(223, 395);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(269, 64);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.computerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.computerPictureBox.Location = new System.Drawing.Point(365, 59);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(254, 254);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerPictureBox.TabIndex = 5;
            this.computerPictureBox.TabStop = false;
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userPictureBox.Location = new System.Drawing.Point(96, 59);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(254, 254);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 2;
            this.userPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 538);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.userLabel);
            this.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

