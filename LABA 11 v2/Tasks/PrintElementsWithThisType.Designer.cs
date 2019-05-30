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
            this.BTPrint.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTPrint.Location = new System.Drawing.Point(35, 70);
            this.BTPrint.Name = "BTPrint";
            this.BTPrint.Size = new System.Drawing.Size(123, 37);
            this.BTPrint.TabIndex = 0;
            this.BTPrint.Text = "Вывести";
            this.BTPrint.UseVisualStyleBackColor = true;
            this.BTPrint.Click += new System.EventHandler(this.BTPrint_Click);
            // 
            // CBTypes
            // 
            this.CBTypes.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.CBTypes.FormattingEnabled = true;
            this.CBTypes.Items.AddRange(new object[] {
            "Животные",
            "Млекопитающие",
            "Птицы",
            "Парнокопытные"});
            this.CBTypes.Location = new System.Drawing.Point(35, 36);
            this.CBTypes.Name = "CBTypes";
            this.CBTypes.Size = new System.Drawing.Size(134, 28);
            this.CBTypes.TabIndex = 2;
            // 
            // TBOutput
            // 
            this.TBOutput.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBOutput.Location = new System.Drawing.Point(35, 126);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.ReadOnly = true;
            this.TBOutput.Size = new System.Drawing.Size(844, 312);
            this.TBOutput.TabIndex = 3;
            this.TBOutput.Text = "";
            // 
            // PrintElementsWithThisType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
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