namespace Student_Population
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
            this.txtnumberofToday = new System.Windows.Forms.TextBox();
            this.txtnumberofyears = new System.Windows.Forms.TextBox();
            this.txtannualrate = new System.Windows.Forms.TextBox();
            this.txtprojectedstudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnpsp = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumberofToday
            // 
            this.txtnumberofToday.Location = new System.Drawing.Point(347, 60);
            this.txtnumberofToday.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumberofToday.Name = "txtnumberofToday";
            this.txtnumberofToday.Size = new System.Drawing.Size(253, 22);
            this.txtnumberofToday.TabIndex = 0;
            this.txtnumberofToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtnumberofyears
            // 
            this.txtnumberofyears.Location = new System.Drawing.Point(347, 181);
            this.txtnumberofyears.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumberofyears.Name = "txtnumberofyears";
            this.txtnumberofyears.Size = new System.Drawing.Size(253, 22);
            this.txtnumberofyears.TabIndex = 1;
            this.txtnumberofyears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtannualrate
            // 
            this.txtannualrate.Location = new System.Drawing.Point(347, 118);
            this.txtannualrate.Margin = new System.Windows.Forms.Padding(4);
            this.txtannualrate.Name = "txtannualrate";
            this.txtannualrate.Size = new System.Drawing.Size(253, 22);
            this.txtannualrate.TabIndex = 2;
            this.txtannualrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtprojectedstudent
            // 
            this.txtprojectedstudent.Location = new System.Drawing.Point(347, 246);
            this.txtprojectedstudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtprojectedstudent.Name = "txtprojectedstudent";
            this.txtprojectedstudent.ReadOnly = true;
            this.txtprojectedstudent.Size = new System.Drawing.Size(253, 22);
            this.txtprojectedstudent.TabIndex = 3;
            this.txtprojectedstudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of students today";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Annual growth rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Projected number of students";
            // 
            // btnpsp
            // 
            this.btnpsp.Location = new System.Drawing.Point(136, 326);
            this.btnpsp.Name = "btnpsp";
            this.btnpsp.Size = new System.Drawing.Size(128, 53);
            this.btnpsp.TabIndex = 8;
            this.btnpsp.Text = "&Project Student Population";
            this.btnpsp.UseVisualStyleBackColor = true;
            this.btnpsp.Click += new System.EventHandler(this.btnpsp_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(347, 326);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(128, 53);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 437);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnpsp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprojectedstudent);
            this.Controls.Add(this.txtannualrate);
            this.Controls.Add(this.txtnumberofyears);
            this.Controls.Add(this.txtnumberofToday);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumberofToday;
        private System.Windows.Forms.TextBox txtnumberofyears;
        private System.Windows.Forms.TextBox txtannualrate;
        private System.Windows.Forms.TextBox txtprojectedstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnpsp;
        private System.Windows.Forms.Button btnexit;
    }
}

