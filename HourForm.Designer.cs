namespace HourLogger
{
    partial class HourForm
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
            this.UpDownInputHours = new System.Windows.Forms.NumericUpDown();
            this.textboxHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInputHours = new System.Windows.Forms.Button();
            this.buttonStartEndWork = new System.Windows.Forms.Button();
            this.textBoxLoggedHours = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownInputHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours Worked This Week:";
            // 
            // UpDownInputHours
            // 
            this.UpDownInputHours.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpDownInputHours.Location = new System.Drawing.Point(12, 252);
            this.UpDownInputHours.Name = "UpDownInputHours";
            this.UpDownInputHours.Size = new System.Drawing.Size(270, 39);
            this.UpDownInputHours.TabIndex = 1;
            // 
            // textboxHours
            // 
            this.textboxHours.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxHours.Location = new System.Drawing.Point(12, 46);
            this.textboxHours.Name = "textboxHours";
            this.textboxHours.ReadOnly = true;
            this.textboxHours.Size = new System.Drawing.Size(289, 39);
            this.textboxHours.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hours Worked Recently:";
            // 
            // buttonInputHours
            // 
            this.buttonInputHours.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInputHours.Location = new System.Drawing.Point(12, 297);
            this.buttonInputHours.Name = "buttonInputHours";
            this.buttonInputHours.Size = new System.Drawing.Size(150, 49);
            this.buttonInputHours.TabIndex = 4;
            this.buttonInputHours.Text = "Confirm";
            this.buttonInputHours.UseVisualStyleBackColor = true;
            // 
            // buttonStartEndWork
            // 
            this.buttonStartEndWork.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartEndWork.Location = new System.Drawing.Point(12, 91);
            this.buttonStartEndWork.Name = "buttonStartEndWork";
            this.buttonStartEndWork.Size = new System.Drawing.Size(289, 76);
            this.buttonStartEndWork.TabIndex = 5;
            this.buttonStartEndWork.Text = "Starting Work?";
            this.buttonStartEndWork.UseVisualStyleBackColor = true;
            this.buttonStartEndWork.Click += new System.EventHandler(this.buttonStartEndWork_Click);
            // 
            // textBoxLoggedHours
            // 
            this.textBoxLoggedHours.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoggedHours.Location = new System.Drawing.Point(12, 173);
            this.textBoxLoggedHours.Name = "textBoxLoggedHours";
            this.textBoxLoggedHours.ReadOnly = true;
            this.textBoxLoggedHours.Size = new System.Drawing.Size(289, 39);
            this.textBoxLoggedHours.TabIndex = 6;
            // 
            // HourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLoggedHours);
            this.Controls.Add(this.buttonStartEndWork);
            this.Controls.Add(this.buttonInputHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxHours);
            this.Controls.Add(this.UpDownInputHours);
            this.Controls.Add(this.label1);
            this.Name = "HourForm";
            this.Text = "HourForm";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownInputHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown UpDownInputHours;
        private TextBox textboxHours;
        private Label label2;
        private Button buttonInputHours;
        private Button buttonStartEndWork;
        private TextBox textBoxLoggedHours;
    }
}