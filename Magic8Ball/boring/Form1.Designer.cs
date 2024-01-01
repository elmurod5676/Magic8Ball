
namespace boring
{
    partial class MagicEightBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicEightBall));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Black;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(12, 578);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(243, 43);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Tell me!";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionBox.Location = new System.Drawing.Point(12, 501);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(243, 71);
            this.questionBox.TabIndex = 2;
            // 
            // answerLabel
            // 
            this.answerLabel.BackColor = System.Drawing.Color.Black;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(511, 255);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(178, 52);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Questions ";
            // 
            // MagicEightBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1151, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MagicEightBall";
            this.Text = "Magic 8 Ball";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label label2;
    }
}

