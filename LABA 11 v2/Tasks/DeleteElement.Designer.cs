namespace Tasks
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
            this.SuspendLayout();
            // 
            // BTDelete
            // 
            this.BTDelete.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTDelete.Location = new System.Drawing.Point(78, 110);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(117, 46);
            this.BTDelete.TabIndex = 0;
            this.BTDelete.Text = "Удалить";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // TBKey
            // 
            this.TBKey.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBKey.Location = new System.Drawing.Point(78, 66);
            this.TBKey.Name = "TBKey";
            this.TBKey.Size = new System.Drawing.Size(100, 27);
            this.TBKey.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DeleteElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBKey);
            this.Controls.Add(this.BTDelete);
            this.Name = "DeleteElement";
            this.Text = "DeleteElement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.TextBox TBKey;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}