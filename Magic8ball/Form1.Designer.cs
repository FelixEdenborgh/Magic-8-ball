namespace Magic8ball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tellMeButton = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.awnserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tellMeButton
            // 
            this.tellMeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tellMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellMeButton.ForeColor = System.Drawing.Color.White;
            this.tellMeButton.Location = new System.Drawing.Point(23, 1015);
            this.tellMeButton.Name = "tellMeButton";
            this.tellMeButton.Size = new System.Drawing.Size(283, 49);
            this.tellMeButton.TabIndex = 0;
            this.tellMeButton.Text = "Tell me!";
            this.tellMeButton.UseVisualStyleBackColor = false;
            this.tellMeButton.Click += new System.EventHandler(this.tellMeButton_Click);
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBox.Location = new System.Drawing.Point(23, 965);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(283, 44);
            this.questionBox.TabIndex = 1;
            // 
            // awnserLabel
            // 
            this.awnserLabel.BackColor = System.Drawing.Color.Transparent;
            this.awnserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awnserLabel.ForeColor = System.Drawing.Color.White;
            this.awnserLabel.Location = new System.Drawing.Point(829, 401);
            this.awnserLabel.Name = "awnserLabel";
            this.awnserLabel.Size = new System.Drawing.Size(261, 117);
            this.awnserLabel.TabIndex = 2;
            this.awnserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1787, 1101);
            this.Controls.Add(this.awnserLabel);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.tellMeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tellMeButton;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Label awnserLabel;
    }
}

