namespace Task_3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTEnqueue = new System.Windows.Forms.Button();
            this.BTContains = new System.Windows.Forms.Button();
            this.BTClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTCapacity = new System.Windows.Forms.Button();
            this.BTCount = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BTCtorCollection = new System.Windows.Forms.Button();
            this.BTCtorEmpty = new System.Windows.Forms.Button();
            this.BTCtorCapacity = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BTDequeue = new System.Windows.Forms.Button();
            this.BTPeek = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTCopyTo = new System.Windows.Forms.Button();
            this.BTToArray = new System.Windows.Forms.Button();
            this.BTClone = new System.Windows.Forms.Button();
            this.BTFill = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTEnqueue);
            this.groupBox2.Controls.Add(this.BTContains);
            this.groupBox2.Controls.Add(this.BTClear);
            this.groupBox2.Location = new System.Drawing.Point(633, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 259);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Элементы";
            // 
            // BTEnqueue
            // 
            this.BTEnqueue.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEnqueue.Location = new System.Drawing.Point(19, 160);
            this.BTEnqueue.Name = "BTEnqueue";
            this.BTEnqueue.Size = new System.Drawing.Size(152, 68);
            this.BTEnqueue.TabIndex = 5;
            this.BTEnqueue.Text = "Добавить новый элемент";
            this.BTEnqueue.UseVisualStyleBackColor = true;
            this.BTEnqueue.Click += new System.EventHandler(this.BTEnqueue_Click);
            // 
            // BTContains
            // 
            this.BTContains.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTContains.Location = new System.Drawing.Point(19, 31);
            this.BTContains.Name = "BTContains";
            this.BTContains.Size = new System.Drawing.Size(152, 68);
            this.BTContains.TabIndex = 1;
            this.BTContains.Text = "Проверить содержание элемента";
            this.BTContains.UseVisualStyleBackColor = true;
            this.BTContains.Click += new System.EventHandler(this.BTContains_Click);
            // 
            // BTClear
            // 
            this.BTClear.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTClear.Location = new System.Drawing.Point(19, 105);
            this.BTClear.Name = "BTClear";
            this.BTClear.Size = new System.Drawing.Size(152, 49);
            this.BTClear.TabIndex = 3;
            this.BTClear.Text = "Очистить";
            this.BTClear.UseVisualStyleBackColor = true;
            this.BTClear.Click += new System.EventHandler(this.BTClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTCapacity);
            this.groupBox1.Controls.Add(this.BTCount);
            this.groupBox1.Location = new System.Drawing.Point(411, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 260);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запросы";
            // 
            // BTCapacity
            // 
            this.BTCapacity.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCapacity.Location = new System.Drawing.Point(20, 92);
            this.BTCapacity.Name = "BTCapacity";
            this.BTCapacity.Size = new System.Drawing.Size(152, 57);
            this.BTCapacity.TabIndex = 2;
            this.BTCapacity.Text = "Вместимость коллекции";
            this.BTCapacity.UseVisualStyleBackColor = true;
            this.BTCapacity.Click += new System.EventHandler(this.BTCapacity_Click);
            // 
            // BTCount
            // 
            this.BTCount.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCount.Location = new System.Drawing.Point(20, 32);
            this.BTCount.Name = "BTCount";
            this.BTCount.Size = new System.Drawing.Size(152, 54);
            this.BTCount.TabIndex = 5;
            this.BTCount.Text = "Количество объектов";
            this.BTCount.UseVisualStyleBackColor = true;
            this.BTCount.Click += new System.EventHandler(this.BTCount_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BTCtorCollection);
            this.groupBox4.Controls.Add(this.BTCtorEmpty);
            this.groupBox4.Controls.Add(this.BTCtorCapacity);
            this.groupBox4.Location = new System.Drawing.Point(7, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 260);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Создать коллекцию (тестирование конструкторов)";
            // 
            // BTCtorCollection
            // 
            this.BTCtorCollection.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCtorCollection.Location = new System.Drawing.Point(25, 172);
            this.BTCtorCollection.Name = "BTCtorCollection";
            this.BTCtorCollection.Size = new System.Drawing.Size(135, 69);
            this.BTCtorCollection.TabIndex = 3;
            this.BTCtorCollection.Text = "Скопировать существующую коллекцию";
            this.BTCtorCollection.UseVisualStyleBackColor = true;
            this.BTCtorCollection.Click += new System.EventHandler(this.BTCtorCollection_Click);
            // 
            // BTCtorEmpty
            // 
            this.BTCtorEmpty.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCtorEmpty.Location = new System.Drawing.Point(25, 56);
            this.BTCtorEmpty.Name = "BTCtorEmpty";
            this.BTCtorEmpty.Size = new System.Drawing.Size(105, 52);
            this.BTCtorEmpty.TabIndex = 2;
            this.BTCtorEmpty.Text = "Размер по умолчанию";
            this.BTCtorEmpty.UseVisualStyleBackColor = true;
            this.BTCtorEmpty.Click += new System.EventHandler(this.BTCtorEmpty_Click);
            // 
            // BTCtorCapacity
            // 
            this.BTCtorCapacity.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCtorCapacity.Location = new System.Drawing.Point(25, 114);
            this.BTCtorCapacity.Name = "BTCtorCapacity";
            this.BTCtorCapacity.Size = new System.Drawing.Size(105, 52);
            this.BTCtorCapacity.TabIndex = 1;
            this.BTCtorCapacity.Text = "Задать размер";
            this.BTCtorCapacity.UseVisualStyleBackColor = true;
            this.BTCtorCapacity.Click += new System.EventHandler(this.BTCtorCapacity_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BTDequeue);
            this.groupBox5.Controls.Add(this.BTPeek);
            this.groupBox5.Location = new System.Drawing.Point(846, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 260);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Первый элемент";
            // 
            // BTDequeue
            // 
            this.BTDequeue.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDequeue.Location = new System.Drawing.Point(20, 92);
            this.BTDequeue.Name = "BTDequeue";
            this.BTDequeue.Size = new System.Drawing.Size(152, 57);
            this.BTDequeue.TabIndex = 2;
            this.BTDequeue.Text = "Показать и удалить";
            this.BTDequeue.UseVisualStyleBackColor = true;
            this.BTDequeue.Click += new System.EventHandler(this.BTDequeue_Click);
            // 
            // BTPeek
            // 
            this.BTPeek.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPeek.Location = new System.Drawing.Point(20, 32);
            this.BTPeek.Name = "BTPeek";
            this.BTPeek.Size = new System.Drawing.Size(152, 54);
            this.BTPeek.TabIndex = 5;
            this.BTPeek.Text = "Показать";
            this.BTPeek.UseVisualStyleBackColor = true;
            this.BTPeek.Click += new System.EventHandler(this.BTPeek_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTCopyTo);
            this.groupBox3.Controls.Add(this.BTToArray);
            this.groupBox3.Controls.Add(this.BTClone);
            this.groupBox3.Location = new System.Drawing.Point(1071, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 259);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия со всей коллекцией";
            // 
            // BTCopyTo
            // 
            this.BTCopyTo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCopyTo.Location = new System.Drawing.Point(19, 160);
            this.BTCopyTo.Name = "BTCopyTo";
            this.BTCopyTo.Size = new System.Drawing.Size(152, 68);
            this.BTCopyTo.TabIndex = 5;
            this.BTCopyTo.Text = "Скопировать в массив\r\n";
            this.BTCopyTo.UseVisualStyleBackColor = true;
            this.BTCopyTo.Click += new System.EventHandler(this.BTCopyTo_Click);
            // 
            // BTToArray
            // 
            this.BTToArray.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTToArray.Location = new System.Drawing.Point(19, 31);
            this.BTToArray.Name = "BTToArray";
            this.BTToArray.Size = new System.Drawing.Size(152, 68);
            this.BTToArray.TabIndex = 1;
            this.BTToArray.Text = "Преобразовать в массив";
            this.BTToArray.UseVisualStyleBackColor = true;
            this.BTToArray.Click += new System.EventHandler(this.BTToArray_Click);
            // 
            // BTClone
            // 
            this.BTClone.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTClone.Location = new System.Drawing.Point(19, 105);
            this.BTClone.Name = "BTClone";
            this.BTClone.Size = new System.Drawing.Size(152, 49);
            this.BTClone.TabIndex = 3;
            this.BTClone.Text = "Поверхностно скопировать";
            this.BTClone.UseVisualStyleBackColor = true;
            this.BTClone.Click += new System.EventHandler(this.BTClone_Click);
            // 
            // BTFill
            // 
            this.BTFill.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTFill.Location = new System.Drawing.Point(224, 126);
            this.BTFill.Name = "BTFill";
            this.BTFill.Size = new System.Drawing.Size(152, 54);
            this.BTFill.TabIndex = 18;
            this.BTFill.Text = "Заполнить коллекцию";
            this.BTFill.UseVisualStyleBackColor = true;
            this.BTFill.Click += new System.EventHandler(this.BTFill_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 538);
            this.Controls.Add(this.BTFill);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTContains;
        private System.Windows.Forms.Button BTClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTCount;
        private System.Windows.Forms.Button BTCapacity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTCtorCollection;
        private System.Windows.Forms.Button BTCtorEmpty;
        private System.Windows.Forms.Button BTCtorCapacity;
        private System.Windows.Forms.Button BTEnqueue;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BTDequeue;
        private System.Windows.Forms.Button BTPeek;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTCopyTo;
        private System.Windows.Forms.Button BTToArray;
        private System.Windows.Forms.Button BTClone;
        private System.Windows.Forms.Button BTFill;
    }
}