namespace OOPPracticApp.Screens
{
    partial class RefrigeratorForm
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
            this.textBoxMaximumWeightItCanTake = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfItems = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWeightKGUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCurrentWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRemainingWeight = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum weight it can take :";
            // 
            // textBoxMaximumWeightItCanTake
            // 
            this.textBoxMaximumWeightItCanTake.Location = new System.Drawing.Point(282, 52);
            this.textBoxMaximumWeightItCanTake.Name = "textBoxMaximumWeightItCanTake";
            this.textBoxMaximumWeightItCanTake.Size = new System.Drawing.Size(342, 20);
            this.textBoxMaximumWeightItCanTake.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(638, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of items :";
            // 
            // textBoxNumberOfItems
            // 
            this.textBoxNumberOfItems.Location = new System.Drawing.Point(282, 125);
            this.textBoxNumberOfItems.Name = "textBoxNumberOfItems";
            this.textBoxNumberOfItems.Size = new System.Drawing.Size(101, 20);
            this.textBoxNumberOfItems.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight (KG) / Unit :";
            // 
            // textBoxWeightKGUnit
            // 
            this.textBoxWeightKGUnit.Location = new System.Drawing.Point(518, 125);
            this.textBoxWeightKGUnit.Name = "textBoxWeightKGUnit";
            this.textBoxWeightKGUnit.Size = new System.Drawing.Size(106, 20);
            this.textBoxWeightKGUnit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current (Weight) :";
            // 
            // textBoxCurrentWeight
            // 
            this.textBoxCurrentWeight.Location = new System.Drawing.Point(282, 201);
            this.textBoxCurrentWeight.Name = "textBoxCurrentWeight";
            this.textBoxCurrentWeight.ReadOnly = true;
            this.textBoxCurrentWeight.Size = new System.Drawing.Size(245, 20);
            this.textBoxCurrentWeight.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Remaining (Weight) :";
            // 
            // textBoxRemainingWeight
            // 
            this.textBoxRemainingWeight.Location = new System.Drawing.Point(282, 250);
            this.textBoxRemainingWeight.Name = "textBoxRemainingWeight";
            this.textBoxRemainingWeight.ReadOnly = true;
            this.textBoxRemainingWeight.Size = new System.Drawing.Size(245, 20);
            this.textBoxRemainingWeight.TabIndex = 1;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(638, 123);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(150, 23);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // RefrigeratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 348);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxRemainingWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCurrentWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWeightKGUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumberOfItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaximumWeightItCanTake);
            this.Controls.Add(this.label1);
            this.Name = "RefrigeratorForm";
            this.Text = "RefrigeratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaximumWeightItCanTake;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumberOfItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWeightKGUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCurrentWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRemainingWeight;
        private System.Windows.Forms.Button buttonEnter;
    }
}