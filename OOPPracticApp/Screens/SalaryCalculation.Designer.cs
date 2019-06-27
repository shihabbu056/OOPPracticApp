namespace OOPPracticApp.Screens
{
    partial class SalaryCalculation
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
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.buttonShowMeSalary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBasicAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHouseRent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMedicalAllowance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name :";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(240, 48);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(299, 20);
            this.textBoxEmployeeName.TabIndex = 1;
            // 
            // buttonShowMeSalary
            // 
            this.buttonShowMeSalary.Location = new System.Drawing.Point(240, 232);
            this.buttonShowMeSalary.Name = "buttonShowMeSalary";
            this.buttonShowMeSalary.Size = new System.Drawing.Size(299, 23);
            this.buttonShowMeSalary.TabIndex = 2;
            this.buttonShowMeSalary.Text = "Show My Salary";
            this.buttonShowMeSalary.UseVisualStyleBackColor = true;
            this.buttonShowMeSalary.Click += new System.EventHandler(this.buttonShowMeSalary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Basic Amount :";
            // 
            // textBoxBasicAmount
            // 
            this.textBoxBasicAmount.Location = new System.Drawing.Point(240, 93);
            this.textBoxBasicAmount.Name = "textBoxBasicAmount";
            this.textBoxBasicAmount.Size = new System.Drawing.Size(186, 20);
            this.textBoxBasicAmount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "House Rent :";
            // 
            // textBoxHouseRent
            // 
            this.textBoxHouseRent.Location = new System.Drawing.Point(240, 138);
            this.textBoxHouseRent.Name = "textBoxHouseRent";
            this.textBoxHouseRent.Size = new System.Drawing.Size(186, 20);
            this.textBoxHouseRent.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Medical Allowance :";
            // 
            // textBoxMedicalAllowance
            // 
            this.textBoxMedicalAllowance.Location = new System.Drawing.Point(240, 179);
            this.textBoxMedicalAllowance.Name = "textBoxMedicalAllowance";
            this.textBoxMedicalAllowance.Size = new System.Drawing.Size(186, 20);
            this.textBoxMedicalAllowance.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "% of Basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "% of Basic";
            // 
            // SalaryCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 379);
            this.Controls.Add(this.buttonShowMeSalary);
            this.Controls.Add(this.textBoxMedicalAllowance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHouseRent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBasicAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculation";
            this.Text = "SalaryCalculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Button buttonShowMeSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBasicAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHouseRent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMedicalAllowance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}