namespace ApothecaryApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mAINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.providerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.providerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.списаниеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAYOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прибыльToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.прибыльToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.прибыльToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAINToolStripMenuItem,
            this.lAYOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mAINToolStripMenuItem
            // 
            this.mAINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.mAINToolStripMenuItem.Name = "mAINToolStripMenuItem";
            this.mAINToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.mAINToolStripMenuItem.Text = "&ДЕЙСТВИЯ";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem,
            this.providerToolStripMenuItem,
            this.продажаToolStripMenuItem,
            this.списаниеToolStripMenuItem,
            this.расчётToolStripMenuItem,
            this.прибыльToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "&Добавить";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.medicineToolStripMenuItem.Text = "&Лекарство";
            this.medicineToolStripMenuItem.Click += new System.EventHandler(this.medicineToolStripMenuItem_Click);
            // 
            // providerToolStripMenuItem
            // 
            this.providerToolStripMenuItem.Name = "providerToolStripMenuItem";
            this.providerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.providerToolStripMenuItem.Text = "&Поставщик";
            this.providerToolStripMenuItem.Click += new System.EventHandler(this.providerToolStripMenuItem_Click);
            // 
            // продажаToolStripMenuItem
            // 
            this.продажаToolStripMenuItem.Name = "продажаToolStripMenuItem";
            this.продажаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.продажаToolStripMenuItem.Text = "&Продажа";
            this.продажаToolStripMenuItem.Click += new System.EventHandler(this.продажаToolStripMenuItem_Click);
            // 
            // списаниеToolStripMenuItem
            // 
            this.списаниеToolStripMenuItem.Name = "списаниеToolStripMenuItem";
            this.списаниеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.списаниеToolStripMenuItem.Text = "&Списание";
            this.списаниеToolStripMenuItem.Click += new System.EventHandler(this.списаниеToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem1,
            this.providerToolStripMenuItem1,
            this.продажаToolStripMenuItem1,
            this.списаниеToolStripMenuItem1,
            this.расчётToolStripMenuItem1,
            this.прибыльToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "&Изменить";
            // 
            // medicineToolStripMenuItem1
            // 
            this.medicineToolStripMenuItem1.Name = "medicineToolStripMenuItem1";
            this.medicineToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.medicineToolStripMenuItem1.Text = "&Лекарство";
            this.medicineToolStripMenuItem1.Click += new System.EventHandler(this.medicineToolStripMenuItem1_Click);
            // 
            // providerToolStripMenuItem1
            // 
            this.providerToolStripMenuItem1.Name = "providerToolStripMenuItem1";
            this.providerToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.providerToolStripMenuItem1.Text = "&Поставщик";
            this.providerToolStripMenuItem1.Click += new System.EventHandler(this.providerToolStripMenuItem1_Click);
            // 
            // продажаToolStripMenuItem1
            // 
            this.продажаToolStripMenuItem1.Name = "продажаToolStripMenuItem1";
            this.продажаToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.продажаToolStripMenuItem1.Text = "&Продажа";
            this.продажаToolStripMenuItem1.Click += new System.EventHandler(this.продажаToolStripMenuItem1_Click);
            // 
            // списаниеToolStripMenuItem1
            // 
            this.списаниеToolStripMenuItem1.Name = "списаниеToolStripMenuItem1";
            this.списаниеToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.списаниеToolStripMenuItem1.Text = "&Списание";
            this.списаниеToolStripMenuItem1.Click += new System.EventHandler(this.списаниеToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem2,
            this.providerToolStripMenuItem2,
            this.продажаToolStripMenuItem2,
            this.списаниеToolStripMenuItem2,
            this.расчётToolStripMenuItem2,
            this.прибыльToolStripMenuItem2});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "&Удалить";
            // 
            // medicineToolStripMenuItem2
            // 
            this.medicineToolStripMenuItem2.Name = "medicineToolStripMenuItem2";
            this.medicineToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.medicineToolStripMenuItem2.Text = "&Лекарство";
            this.medicineToolStripMenuItem2.Click += new System.EventHandler(this.medicineToolStripMenuItem2_Click);
            // 
            // providerToolStripMenuItem2
            // 
            this.providerToolStripMenuItem2.Name = "providerToolStripMenuItem2";
            this.providerToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.providerToolStripMenuItem2.Text = "&Поставщик";
            this.providerToolStripMenuItem2.Click += new System.EventHandler(this.providerToolStripMenuItem2_Click);
            // 
            // продажаToolStripMenuItem2
            // 
            this.продажаToolStripMenuItem2.Name = "продажаToolStripMenuItem2";
            this.продажаToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.продажаToolStripMenuItem2.Text = "&Продажа";
            this.продажаToolStripMenuItem2.Click += new System.EventHandler(this.продажаToolStripMenuItem2_Click);
            // 
            // списаниеToolStripMenuItem2
            // 
            this.списаниеToolStripMenuItem2.Name = "списаниеToolStripMenuItem2";
            this.списаниеToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.списаниеToolStripMenuItem2.Text = "&Списание";
            this.списаниеToolStripMenuItem2.Click += new System.EventHandler(this.списаниеToolStripMenuItem2_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchToolStripMenuItem.Text = "&Поиск";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // lAYOUTToolStripMenuItem
            // 
            this.lAYOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.lAYOUTToolStripMenuItem.Name = "lAYOUTToolStripMenuItem";
            this.lAYOUTToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.lAYOUTToolStripMenuItem.Text = "&РАСКЛАДКА";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.cascadeToolStripMenuItem.Text = "&Каскадная";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.horizontalToolStripMenuItem.Text = "&Горизонтальная";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.verticalToolStripMenuItem.Text = "&Вертикальная";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // расчётToolStripMenuItem
            // 
            this.расчётToolStripMenuItem.Name = "расчётToolStripMenuItem";
            this.расчётToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.расчётToolStripMenuItem.Text = "&Расчёт";
            this.расчётToolStripMenuItem.Click += new System.EventHandler(this.расчётToolStripMenuItem_Click);
            // 
            // прибыльToolStripMenuItem
            // 
            this.прибыльToolStripMenuItem.Name = "прибыльToolStripMenuItem";
            this.прибыльToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.прибыльToolStripMenuItem.Text = "&Прибыль";
            this.прибыльToolStripMenuItem.Click += new System.EventHandler(this.прибыльToolStripMenuItem_Click);
            // 
            // расчётToolStripMenuItem1
            // 
            this.расчётToolStripMenuItem1.Name = "расчётToolStripMenuItem1";
            this.расчётToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.расчётToolStripMenuItem1.Text = "&Расчёт";
            this.расчётToolStripMenuItem1.Click += new System.EventHandler(this.расчётToolStripMenuItem1_Click);
            // 
            // прибыльToolStripMenuItem1
            // 
            this.прибыльToolStripMenuItem1.Name = "прибыльToolStripMenuItem1";
            this.прибыльToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.прибыльToolStripMenuItem1.Text = "&Прибыль";
            this.прибыльToolStripMenuItem1.Click += new System.EventHandler(this.прибыльToolStripMenuItem1_Click);
            // 
            // расчётToolStripMenuItem2
            // 
            this.расчётToolStripMenuItem2.Name = "расчётToolStripMenuItem2";
            this.расчётToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.расчётToolStripMenuItem2.Text = "&Расчёт";
            this.расчётToolStripMenuItem2.Click += new System.EventHandler(this.расчётToolStripMenuItem2_Click);
            // 
            // прибыльToolStripMenuItem2
            // 
            this.прибыльToolStripMenuItem2.Name = "прибыльToolStripMenuItem2";
            this.прибыльToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.прибыльToolStripMenuItem2.Text = "&Прибыль";
            this.прибыльToolStripMenuItem2.Click += new System.EventHandler(this.прибыльToolStripMenuItem2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(146)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Основное окно";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mAINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem providerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem providerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem lAYOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списаниеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem продажаToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem списаниеToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem расчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прибыльToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчётToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem прибыльToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem расчётToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem прибыльToolStripMenuItem2;
    }
}

