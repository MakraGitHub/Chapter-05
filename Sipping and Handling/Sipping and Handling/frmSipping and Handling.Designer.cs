namespace Sipping_and_Handling
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtorder = new System.Windows.Forms.TextBox();
            this.txtSpping = new System.Windows.Forms.TextBox();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.txtsaletax = new System.Windows.Forms.TextBox();
            this.txtgradetotal = new System.Windows.Forms.TextBox();
            this.btncalcualtegrandetotal = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Type(P=Preferred N=non-Preferred) ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spping Costs(free for Preferred customers)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sale Tax(7%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade Total";
            // 
            // txtorder
            // 
            this.txtorder.Location = new System.Drawing.Point(408, 57);
            this.txtorder.Name = "txtorder";
            this.txtorder.Size = new System.Drawing.Size(197, 20);
            this.txtorder.TabIndex = 5;
            this.txtorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSpping
            // 
            this.txtSpping.Location = new System.Drawing.Point(408, 158);
            this.txtSpping.Name = "txtSpping";
            this.txtSpping.ReadOnly = true;
            this.txtSpping.Size = new System.Drawing.Size(197, 20);
            this.txtSpping.TabIndex = 6;
            this.txtSpping.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(408, 107);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(197, 20);
            this.txtCustomerType.TabIndex = 7;
            this.txtCustomerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsaletax
            // 
            this.txtsaletax.Location = new System.Drawing.Point(408, 207);
            this.txtsaletax.Name = "txtsaletax";
            this.txtsaletax.ReadOnly = true;
            this.txtsaletax.Size = new System.Drawing.Size(197, 20);
            this.txtsaletax.TabIndex = 8;
            this.txtsaletax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtgradetotal
            // 
            this.txtgradetotal.Location = new System.Drawing.Point(408, 258);
            this.txtgradetotal.Name = "txtgradetotal";
            this.txtgradetotal.ReadOnly = true;
            this.txtgradetotal.Size = new System.Drawing.Size(197, 20);
            this.txtgradetotal.TabIndex = 9;
            this.txtgradetotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btncalcualtegrandetotal
            // 
            this.btncalcualtegrandetotal.Location = new System.Drawing.Point(181, 326);
            this.btncalcualtegrandetotal.Name = "btncalcualtegrandetotal";
            this.btncalcualtegrandetotal.Size = new System.Drawing.Size(104, 52);
            this.btncalcualtegrandetotal.TabIndex = 1;
            this.btncalcualtegrandetotal.Text = "&Calculate Grade Total";
            this.btncalcualtegrandetotal.UseVisualStyleBackColor = true;
            this.btncalcualtegrandetotal.Click += new System.EventHandler(this.btncalcualtegrandetotal_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(408, 326);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(68, 52);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 433);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalcualtegrandetotal);
            this.Controls.Add(this.txtgradetotal);
            this.Controls.Add(this.txtsaletax);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.txtSpping);
            this.Controls.Add(this.txtorder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipping and Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtorder;
        private System.Windows.Forms.TextBox txtSpping;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.TextBox txtsaletax;
        private System.Windows.Forms.TextBox txtgradetotal;
        private System.Windows.Forms.Button btncalcualtegrandetotal;
        private System.Windows.Forms.Button btnexit;
    }
}

