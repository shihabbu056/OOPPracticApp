namespace OOPPracticApp.Screens
{
    partial class VehicleForm
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
            this.textBoxVehicleName = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRegNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMinSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAvgSpeed = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Name :";
            // 
            // textBoxVehicleName
            // 
            this.textBoxVehicleName.Location = new System.Drawing.Point(259, 43);
            this.textBoxVehicleName.Name = "textBoxVehicleName";
            this.textBoxVehicleName.Size = new System.Drawing.Size(214, 20);
            this.textBoxVehicleName.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(504, 224);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reg No :";
            // 
            // textBoxRegNo
            // 
            this.textBoxRegNo.Location = new System.Drawing.Point(259, 86);
            this.textBoxRegNo.Name = "textBoxRegNo";
            this.textBoxRegNo.Size = new System.Drawing.Size(214, 20);
            this.textBoxRegNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Speed :";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(259, 140);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(147, 20);
            this.textBoxSpeed.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Min Speed :";
            // 
            // textBoxMinSpeed
            // 
            this.textBoxMinSpeed.Location = new System.Drawing.Point(259, 227);
            this.textBoxMinSpeed.Name = "textBoxMinSpeed";
            this.textBoxMinSpeed.ReadOnly = true;
            this.textBoxMinSpeed.Size = new System.Drawing.Size(214, 20);
            this.textBoxMinSpeed.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max Speed :";
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(259, 267);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.ReadOnly = true;
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(214, 20);
            this.textBoxMaxSpeed.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Avg Speed :";
            // 
            // textBoxAvgSpeed
            // 
            this.textBoxAvgSpeed.Location = new System.Drawing.Point(259, 304);
            this.textBoxAvgSpeed.Name = "textBoxAvgSpeed";
            this.textBoxAvgSpeed.ReadOnly = true;
            this.textBoxAvgSpeed.Size = new System.Drawing.Size(214, 20);
            this.textBoxAvgSpeed.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(504, 83);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kilo/Hr";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(504, 138);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 382);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxAvgSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRegNo);
            this.Controls.Add(this.textBoxMinSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVehicleName);
            this.Controls.Add(this.label1);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVehicleName;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRegNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMinSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAvgSpeed;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEnter;
    }
}