namespace TelePhone_Number
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
            this.txtAN = new System.Windows.Forms.TextBox();
            this.txtnumberonly = new System.Windows.Forms.TextBox();
            this.btnconverttoonly = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alphanumeric Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numeric Only";
            // 
            // txtAN
            // 
            this.txtAN.Location = new System.Drawing.Point(199, 69);
            this.txtAN.Name = "txtAN";
            this.txtAN.Size = new System.Drawing.Size(162, 20);
            this.txtAN.TabIndex = 2;
            // 
            // txtnumberonly
            // 
            this.txtnumberonly.Location = new System.Drawing.Point(199, 115);
            this.txtnumberonly.Name = "txtnumberonly";
            this.txtnumberonly.ReadOnly = true;
            this.txtnumberonly.Size = new System.Drawing.Size(162, 20);
            this.txtnumberonly.TabIndex = 3;
            // 
            // btnconverttoonly
            // 
            this.btnconverttoonly.Location = new System.Drawing.Point(109, 177);
            this.btnconverttoonly.Name = "btnconverttoonly";
            this.btnconverttoonly.Size = new System.Drawing.Size(101, 43);
            this.btnconverttoonly.TabIndex = 4;
            this.btnconverttoonly.Text = "&Convert to Numerice Only";
            this.btnconverttoonly.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(278, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 365);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnconverttoonly);
            this.Controls.Add(this.txtnumberonly);
            this.Controls.Add(this.txtAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAN;
        private System.Windows.Forms.TextBox txtnumberonly;
        private System.Windows.Forms.Button btnconverttoonly;
        private System.Windows.Forms.Button btnExit;
    }
}

