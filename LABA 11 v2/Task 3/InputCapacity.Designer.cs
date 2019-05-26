namespace Task_3
{
    partial class InputCapacity
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTInputCapacity = new System.Windows.Forms.Button();
            this.TBCapacity = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBCapacity);
            this.groupBox1.Controls.Add(this.BTInputCapacity);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 260);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод размера";
            // 
            // BTInputCapacity
            // 
            this.BTInputCapacity.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTInputCapacity.Location = new System.Drawing.Point(6, 108);
            this.BTInputCapacity.Name = "BTInputCapacity";
            this.BTInputCapacity.Size = new System.Drawing.Size(152, 54);
            this.BTInputCapacity.TabIndex = 5;
            this.BTInputCapacity.Text = "Количество объектов";
            this.BTInputCapacity.UseVisualStyleBackColor = true;
            this.BTInputCapacity.Click += new System.EventHandler(this.BTInputCapacity_Click);
            // 
            // TBCapacity
            // 
            this.TBCapacity.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBCapacity.Location = new System.Drawing.Point(22, 52);
            this.TBCapacity.Name = "TBCapacity";
            this.TBCapacity.Size = new System.Drawing.Size(100, 27);
            this.TBCapacity.TabIndex = 6;
            // 
            // InputCapacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputCapacity";
            this.Text = "InputCapacity";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBCapacity;
        private System.Windows.Forms.Button BTInputCapacity;
    }
}