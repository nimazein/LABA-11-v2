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
            this.SuspendLayout();
            // 
            // BTFind
            // 
            this.BTFind.Location = new System.Drawing.Point(130, 90);
            this.BTFind.Name = "BTFind";
            this.BTFind.Size = new System.Drawing.Size(75, 23);
            this.BTFind.TabIndex = 0;
            this.BTFind.Text = "button1";
            this.BTFind.UseVisualStyleBackColor = true;
            this.BTFind.Click += new System.EventHandler(this.BTFind_Click);
            // 
            // TBKey
            // 
            this.TBKey.Location = new System.Drawing.Point(130, 64);
            this.TBKey.Name = "TBKey";
            this.TBKey.Size = new System.Drawing.Size(100, 20);
            this.TBKey.TabIndex = 1;
            // 
            // TBOutput
            // 
            this.TBOutput.Location = new System.Drawing.Point(99, 148);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(515, 20);
            this.TBOutput.TabIndex = 2;
            // 
            // FindElementByKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}