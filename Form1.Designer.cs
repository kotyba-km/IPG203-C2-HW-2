namespace IPG203_C2_HW
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
            this.choiceEmployee = new System.Windows.Forms.Button();
            this.choiceBoss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose an Option";
            // 
            // choiceEmployee
            // 
            this.choiceEmployee.BackColor = System.Drawing.SystemColors.Highlight;
            this.choiceEmployee.Font = new System.Drawing.Font("Swis721 BlkCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.choiceEmployee.Location = new System.Drawing.Point(303, 154);
            this.choiceEmployee.Name = "choiceEmployee";
            this.choiceEmployee.Size = new System.Drawing.Size(233, 59);
            this.choiceEmployee.TabIndex = 1;
            this.choiceEmployee.Text = "Employee";
            this.choiceEmployee.UseVisualStyleBackColor = false;
            this.choiceEmployee.Click += new System.EventHandler(this.choiceEmployee_Click);
            // 
            // choiceBoss
            // 
            this.choiceBoss.BackColor = System.Drawing.SystemColors.Highlight;
            this.choiceBoss.Font = new System.Drawing.Font("Swis721 BlkCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceBoss.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.choiceBoss.Location = new System.Drawing.Point(303, 238);
            this.choiceBoss.Name = "choiceBoss";
            this.choiceBoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.choiceBoss.Size = new System.Drawing.Size(233, 59);
            this.choiceBoss.TabIndex = 2;
            this.choiceBoss.Text = "Boss";
            this.choiceBoss.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choiceBoss);
            this.Controls.Add(this.choiceEmployee);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choiceEmployee;
        private System.Windows.Forms.Button choiceBoss;
    }
}

