namespace Task_2
{
    partial class DeleteElement
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
            this.components = new System.ComponentModel.Container();
            this.BTDelete = new System.Windows.Forms.Button();
            this.TBKey = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTDelete
            // 
            this.BTDelete.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTDelete.Location = new System.Drawing.Point(22, 71);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(103, 46);
            this.BTDelete.TabIndex = 0;
            this.BTDelete.Text = "Удалить";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // TBKey
            // 
            this.TBKey.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBKey.Location = new System.Drawing.Point(22, 28);
            this.TBKey.Name = "TBKey";
            this.TBKey.Size = new System.Drawing.Size(135, 27);
            this.TBKey.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTDelete);
            this.groupBox1.Controls.Add(this.TBKey);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод ключа";
            // 
            // DeleteElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 190);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteElement";
            this.Text = "DeleteElement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.TextBox TBKey;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}