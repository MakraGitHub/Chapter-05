namespace Calculate_Letter_Grade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnummeric = new System.Windows.Forms.TextBox();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnCalculateLetterGrade = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeric Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Letter Grade";
            // 
            // txtnummeric
            // 
            this.txtnummeric.Location = new System.Drawing.Point(208, 63);
            this.txtnummeric.Name = "txtnummeric";
            this.txtnummeric.Size = new System.Drawing.Size(161, 20);
            this.txtnummeric.TabIndex = 2;
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(208, 112);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(161, 20);
            this.txtLetter.TabIndex = 3;
            // 
            // btnCalculateLetterGrade
            // 
            this.btnCalculateLetterGrade.Location = new System.Drawing.Point(93, 190);
            this.btnCalculateLetterGrade.Name = "btnCalculateLetterGrade";
            this.btnCalculateLetterGrade.Size = new System.Drawing.Size(120, 60);
            this.btnCalculateLetterGrade.TabIndex = 4;
            this.btnCalculateLetterGrade.Text = "&Calculate Letter Grade";
            this.btnCalculateLetterGrade.UseVisualStyleBackColor = true;
            this.btnCalculateLetterGrade.Click += new System.EventHandler(this.btnCLG_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(294, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 329);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateLetterGrade);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.txtnummeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnummeric;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnCalculateLetterGrade;
        private System.Windows.Forms.Button btnExit;
    }
}

