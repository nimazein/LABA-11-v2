namespace Tasks
{
    partial class PrintEach
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
            this.TBOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TBOutput
            // 
            this.TBOutput.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBOutput.Location = new System.Drawing.Point(12, 12);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(543, 618);
            this.TBOutput.TabIndex = 0;
            this.TBOutput.Text = "";
            // 
            // PrintEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 642);
            this.Controls.Add(this.TBOutput);
            this.Name = "PrintEach";
            this.Text = "PrintEach";
            this.Load += new System.EventHandler(this.PrintEach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TBOutput;
    }
}