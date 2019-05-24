namespace Tasks
{
    partial class FindElementByKey
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
            this.BTFind = new System.Windows.Forms.Button();
            this.TBKey = new System.Windows.Forms.TextBox();
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTFind
            // 
            this.BTFind.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTFind.Location = new System.Drawing.Point(40, 78);
            this.BTFind.Name = "BTFind";
            this.BTFind.Size = new System.Drawing.Size(100, 42);
            this.BTFind.TabIndex = 0;
            this.BTFind.Text = "Вывести";
            this.BTFind.UseVisualStyleBackColor = true;
            this.BTFind.Click += new System.EventHandler(this.BTFind_Click);
            // 
            // TBKey
            // 
            this.TBKey.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBKey.Location = new System.Drawing.Point(40, 45);
            this.TBKey.Name = "TBKey";
            this.TBKey.Size = new System.Drawing.Size(146, 27);
            this.TBKey.TabIndex = 1;
            // 
            // TBOutput
            // 
            this.TBOutput.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBOutput.Location = new System.Drawing.Point(40, 152);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.ReadOnly = true;
            this.TBOutput.Size = new System.Drawing.Size(797, 27);
            this.TBOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввод ключа";
            // 
            // FindElementByKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBOutput);
            this.Controls.Add(this.TBKey);
            this.Controls.Add(this.BTFind);
            this.Name = "FindElementByKey";
            this.Text = "FindElementByKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTFind;
        private System.Windows.Forms.TextBox TBKey;
        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.Label label1;
    }
}