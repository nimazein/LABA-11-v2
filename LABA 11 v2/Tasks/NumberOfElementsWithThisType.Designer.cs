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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTShow
            // 
            this.BTShow.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTShow.Location = new System.Drawing.Point(15, 65);
            this.BTShow.Name = "BTShow";
            this.BTShow.Size = new System.Drawing.Size(172, 57);
            this.BTShow.TabIndex = 0;
            this.BTShow.Text = "Вывести количество";
            this.BTShow.UseVisualStyleBackColor = true;
            this.BTShow.Click += new System.EventHandler(this.BTShow_Click);
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
            this.CBTypes.Location = new System.Drawing.Point(15, 31);
            this.CBTypes.Name = "CBTypes";
            this.CBTypes.Size = new System.Drawing.Size(172, 28);
            this.CBTypes.TabIndex = 1;
            // 
            // TBOutput
            // 
            this.TBOutput.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBOutput.Location = new System.Drawing.Point(15, 149);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.ReadOnly = true;
            this.TBOutput.Size = new System.Drawing.Size(200, 33);
            this.TBOutput.TabIndex = 2;
            this.TBOutput.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBOutput);
            this.groupBox1.Controls.Add(this.BTShow);
            this.groupBox1.Controls.Add(this.CBTypes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // NumberOfElementsWithThisType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 298);
            this.Controls.Add(this.groupBox1);
            this.Name = "NumberOfElementsWithThisType";
            this.Text = "NumberOfElementsWithThisType";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTShow;
        private System.Windows.Forms.ComboBox CBTypes;
        private System.Windows.Forms.RichTextBox TBOutput;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}