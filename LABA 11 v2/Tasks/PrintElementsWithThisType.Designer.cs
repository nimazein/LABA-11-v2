namespace Tasks
{
    partial class PrintElementsWithThisType
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
            this.BTPrint = new System.Windows.Forms.Button();
            this.CBTypes = new System.Windows.Forms.ComboBox();
            this.TBOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BTPrint
            // 
            this.BTPrint.Location = new System.Drawing.Point(59, 85);
            this.BTPrint.Name = "BTPrint";
            this.BTPrint.Size = new System.Drawing.Size(75, 23);
            this.BTPrint.TabIndex = 0;
            this.BTPrint.Text = "button1";
            this.BTPrint.UseVisualStyleBackColor = true;
            this.BTPrint.Click += new System.EventHandler(this.BTPrint_Click);
            // 
            // CBTypes
            // 
            this.CBTypes.FormattingEnabled = true;
            this.CBTypes.Items.AddRange(new object[] {
            "Животные",
            "Млекопитающие",
            "Птицы",
            "Парнокопытные"});
            this.CBTypes.Location = new System.Drawing.Point(59, 58);
            this.CBTypes.Name = "CBTypes";
            this.CBTypes.Size = new System.Drawing.Size(134, 21);
            this.CBTypes.TabIndex = 2;
            // 
            // TBOutput
            // 
            this.TBOutput.Location = new System.Drawing.Point(89, 134);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(259, 286);
            this.TBOutput.TabIndex = 3;
            this.TBOutput.Text = "";
            // 
            // PrintElementsWithThisType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBOutput);
            this.Controls.Add(this.CBTypes);
            this.Controls.Add(this.BTPrint);
            this.Name = "PrintElementsWithThisType";
            this.Text = "PrintElementsWithThisType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTPrint;
        private System.Windows.Forms.ComboBox CBTypes;
        private System.Windows.Forms.RichTextBox TBOutput;
    }
}