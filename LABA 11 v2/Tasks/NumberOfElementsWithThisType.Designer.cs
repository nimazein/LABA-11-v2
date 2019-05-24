namespace Tasks
{
    partial class NumberOfElementsWithThisType
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
            this.BTShow = new System.Windows.Forms.Button();
            this.CBTypes = new System.Windows.Forms.ComboBox();
            this.TBOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BTShow
            // 
            this.BTShow.Location = new System.Drawing.Point(79, 72);
            this.BTShow.Name = "BTShow";
            this.BTShow.Size = new System.Drawing.Size(75, 23);
            this.BTShow.TabIndex = 0;
            this.BTShow.Text = "button1";
            this.BTShow.UseVisualStyleBackColor = true;
            this.BTShow.Click += new System.EventHandler(this.BTShow_Click);
            // 
            // CBTypes
            // 
            this.CBTypes.FormattingEnabled = true;
            this.CBTypes.Items.AddRange(new object[] {
            "Животные",
            "Млекопитающие",
            "Птицы",
            "Парнокопытные"});
            this.CBTypes.Location = new System.Drawing.Point(79, 32);
            this.CBTypes.Name = "CBTypes";
            this.CBTypes.Size = new System.Drawing.Size(121, 21);
            this.CBTypes.TabIndex = 1;
            // 
            // TBOutput
            // 
            this.TBOutput.Location = new System.Drawing.Point(243, 47);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(100, 96);
            this.TBOutput.TabIndex = 2;
            this.TBOutput.Text = "";
            // 
            // NumberOfElementsWithThisType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBOutput);
            this.Controls.Add(this.CBTypes);
            this.Controls.Add(this.BTShow);
            this.Name = "NumberOfElementsWithThisType";
            this.Text = "NumberOfElementsWithThisType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTShow;
        private System.Windows.Forms.ComboBox CBTypes;
        private System.Windows.Forms.RichTextBox TBOutput;
    }
}