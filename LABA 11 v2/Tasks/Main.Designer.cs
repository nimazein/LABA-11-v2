namespace Tasks
{
    partial class Main
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
            this.BTAddElements = new System.Windows.Forms.Button();
            this.BTPrintEach = new System.Windows.Forms.Button();
            this.BTFindElementByKey = new System.Windows.Forms.Button();
            this.BTClone = new System.Windows.Forms.Button();
            this.BTPrintElementsWithThisType = new System.Windows.Forms.Button();
            this.BTNumOfElementsWithThisType = new System.Windows.Forms.Button();
            this.BTDeleteElements = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTCreate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTAddElements
            // 
            this.BTAddElements.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAddElements.Location = new System.Drawing.Point(6, 33);
            this.BTAddElements.Name = "BTAddElements";
            this.BTAddElements.Size = new System.Drawing.Size(105, 52);
            this.BTAddElements.TabIndex = 0;
            this.BTAddElements.Text = "Добавить элементы";
            this.BTAddElements.UseVisualStyleBackColor = true;
            this.BTAddElements.Click += new System.EventHandler(this.BTAddElements_Click);
            // 
            // BTPrintEach
            // 
            this.BTPrintEach.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPrintEach.Location = new System.Drawing.Point(19, 31);
            this.BTPrintEach.Name = "BTPrintEach";
            this.BTPrintEach.Size = new System.Drawing.Size(152, 68);
            this.BTPrintEach.TabIndex = 1;
            this.BTPrintEach.Text = "Перебор всех элементов коллекции";
            this.BTPrintEach.UseVisualStyleBackColor = true;
            this.BTPrintEach.Click += new System.EventHandler(this.BTPrintEach_Click);
            // 
            // BTFindElementByKey
            // 
            this.BTFindElementByKey.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTFindElementByKey.Location = new System.Drawing.Point(21, 180);
            this.BTFindElementByKey.Name = "BTFindElementByKey";
            this.BTFindElementByKey.Size = new System.Drawing.Size(152, 57);
            this.BTFindElementByKey.TabIndex = 2;
            this.BTFindElementByKey.Text = "Поиск элемента по ключу";
            this.BTFindElementByKey.UseVisualStyleBackColor = true;
            this.BTFindElementByKey.Click += new System.EventHandler(this.BTFindElementByKey_Click);
            // 
            // BTClone
            // 
            this.BTClone.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTClone.Location = new System.Drawing.Point(19, 105);
            this.BTClone.Name = "BTClone";
            this.BTClone.Size = new System.Drawing.Size(152, 49);
            this.BTClone.TabIndex = 3;
            this.BTClone.Text = "Клонирование коллекции";
            this.BTClone.UseVisualStyleBackColor = true;
            this.BTClone.Click += new System.EventHandler(this.BTClone_Click);
            // 
            // BTPrintElementsWithThisType
            // 
            this.BTPrintElementsWithThisType.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPrintElementsWithThisType.Location = new System.Drawing.Point(21, 106);
            this.BTPrintElementsWithThisType.Name = "BTPrintElementsWithThisType";
            this.BTPrintElementsWithThisType.Size = new System.Drawing.Size(152, 68);
            this.BTPrintElementsWithThisType.TabIndex = 4;
            this.BTPrintElementsWithThisType.Text = "Печать элементов данного типа";
            this.BTPrintElementsWithThisType.UseVisualStyleBackColor = true;
            this.BTPrintElementsWithThisType.Click += new System.EventHandler(this.BTPrintElementsWithThisType_Click);
            // 
            // BTNumOfElementsWithThisType
            // 
            this.BTNumOfElementsWithThisType.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNumOfElementsWithThisType.Location = new System.Drawing.Point(21, 32);
            this.BTNumOfElementsWithThisType.Name = "BTNumOfElementsWithThisType";
            this.BTNumOfElementsWithThisType.Size = new System.Drawing.Size(152, 68);
            this.BTNumOfElementsWithThisType.TabIndex = 5;
            this.BTNumOfElementsWithThisType.Text = "Количество элементов данного типа";
            this.BTNumOfElementsWithThisType.UseVisualStyleBackColor = true;
            this.BTNumOfElementsWithThisType.Click += new System.EventHandler(this.BTNumOfElementsWithThisType_Click);
            // 
            // BTDeleteElements
            // 
            this.BTDeleteElements.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDeleteElements.Location = new System.Drawing.Point(6, 91);
            this.BTDeleteElements.Name = "BTDeleteElements";
            this.BTDeleteElements.Size = new System.Drawing.Size(105, 53);
            this.BTDeleteElements.TabIndex = 6;
            this.BTDeleteElements.Text = "Удалить элементы";
            this.BTDeleteElements.UseVisualStyleBackColor = true;
            this.BTDeleteElements.Click += new System.EventHandler(this.BTDeleteElements_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNumOfElementsWithThisType);
            this.groupBox1.Controls.Add(this.BTPrintElementsWithThisType);
            this.groupBox1.Controls.Add(this.BTFindElementByKey);
            this.groupBox1.Location = new System.Drawing.Point(192, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 260);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запросы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTPrintEach);
            this.groupBox2.Controls.Add(this.BTClone);
            this.groupBox2.Location = new System.Drawing.Point(414, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 259);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия со всей коллекцией";
            // 
            // BTCreate
            // 
            this.BTCreate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTCreate.Location = new System.Drawing.Point(12, 31);
            this.BTCreate.Name = "BTCreate";
            this.BTCreate.Size = new System.Drawing.Size(130, 55);
            this.BTCreate.TabIndex = 9;
            this.BTCreate.Text = "Создать коллекцию";
            this.BTCreate.UseVisualStyleBackColor = true;
            this.BTCreate.Click += new System.EventHandler(this.BTCreate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTDeleteElements);
            this.groupBox3.Controls.Add(this.BTAddElements);
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 154);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заполнение коллекции";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 507);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BTCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTAddElements;
        private System.Windows.Forms.Button BTPrintEach;
        private System.Windows.Forms.Button BTFindElementByKey;
        private System.Windows.Forms.Button BTClone;
        private System.Windows.Forms.Button BTPrintElementsWithThisType;
        private System.Windows.Forms.Button BTNumOfElementsWithThisType;
        private System.Windows.Forms.Button BTDeleteElements;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTCreate;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

