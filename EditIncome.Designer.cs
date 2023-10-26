namespace ApothecaryApp
{
    partial class EditIncome
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchDPQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DelProdQuantityTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SoldProdQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SoldProdPriceTextBox = new System.Windows.Forms.TextBox();
            this.DelProdPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProdIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.SearchButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.SearchButton.Location = new System.Drawing.Point(430, 7);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 63;
            this.SearchButton.Text = "Искать";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 28);
            this.label1.TabIndex = 62;
            this.label1.Text = "Поиск по кол-ву прив тов";
            // 
            // SearchDPQuantityTextBox
            // 
            this.SearchDPQuantityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.SearchDPQuantityTextBox.Location = new System.Drawing.Point(307, 16);
            this.SearchDPQuantityTextBox.MaxLength = 10;
            this.SearchDPQuantityTextBox.Name = "SearchDPQuantityTextBox";
            this.SearchDPQuantityTextBox.Size = new System.Drawing.Size(117, 22);
            this.SearchDPQuantityTextBox.TabIndex = 61;
            this.SearchDPQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchDPQuantityTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.label7.Location = new System.Drawing.Point(12, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 28);
            this.label7.TabIndex = 60;
            this.label7.Text = "Кол-во прив тов";
            // 
            // DelProdQuantityTextBox
            // 
            this.DelProdQuantityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.DelProdQuantityTextBox.Location = new System.Drawing.Point(205, 162);
            this.DelProdQuantityTextBox.Name = "DelProdQuantityTextBox";
            this.DelProdQuantityTextBox.ReadOnly = true;
            this.DelProdQuantityTextBox.Size = new System.Drawing.Size(251, 22);
            this.DelProdQuantityTextBox.TabIndex = 59;
            this.DelProdQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DelProdQuantityTextBox_KeyPress);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.CancelButton.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.CancelButton.Location = new System.Drawing.Point(318, 318);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(121, 47);
            this.CancelButton.TabIndex = 58;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
            this.SaveButton.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.SaveButton.Location = new System.Drawing.Point(47, 318);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(121, 47);
            this.SaveButton.TabIndex = 57;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 28);
            this.label6.TabIndex = 56;
            this.label6.Text = "Кол-во прод тов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.label5.Location = new System.Drawing.Point(13, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 28);
            this.label5.TabIndex = 55;
            this.label5.Text = "Стоимость прод тов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 28);
            this.label4.TabIndex = 54;
            this.label4.Text = "Стоимость прив тов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "ID товара";
            // 
            // SoldProdQuantityTextBox
            // 
            this.SoldProdQuantityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.SoldProdQuantityTextBox.Location = new System.Drawing.Point(205, 268);
            this.SoldProdQuantityTextBox.Name = "SoldProdQuantityTextBox";
            this.SoldProdQuantityTextBox.ReadOnly = true;
            this.SoldProdQuantityTextBox.Size = new System.Drawing.Size(251, 22);
            this.SoldProdQuantityTextBox.TabIndex = 52;
            this.SoldProdQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoldProdQuantityTextBox_KeyPress);
            // 
            // SoldProdPriceTextBox
            // 
            this.SoldProdPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.SoldProdPriceTextBox.Location = new System.Drawing.Point(246, 215);
            this.SoldProdPriceTextBox.Name = "SoldProdPriceTextBox";
            this.SoldProdPriceTextBox.ReadOnly = true;
            this.SoldProdPriceTextBox.Size = new System.Drawing.Size(211, 22);
            this.SoldProdPriceTextBox.TabIndex = 51;
            this.SoldProdPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoldProdPriceTextBox_KeyPress);
            // 
            // DelProdPriceTextBox
            // 
            this.DelProdPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.DelProdPriceTextBox.Location = new System.Drawing.Point(245, 113);
            this.DelProdPriceTextBox.MaxLength = 10;
            this.DelProdPriceTextBox.Name = "DelProdPriceTextBox";
            this.DelProdPriceTextBox.ReadOnly = true;
            this.DelProdPriceTextBox.Size = new System.Drawing.Size(211, 22);
            this.DelProdPriceTextBox.TabIndex = 50;
            this.DelProdPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DelProdPriceTextBox_KeyPress);
            // 
            // ProdIDTextBox
            // 
            this.ProdIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.ProdIDTextBox.Location = new System.Drawing.Point(205, 64);
            this.ProdIDTextBox.MaxLength = 10;
            this.ProdIDTextBox.Name = "ProdIDTextBox";
            this.ProdIDTextBox.ReadOnly = true;
            this.ProdIDTextBox.Size = new System.Drawing.Size(251, 22);
            this.ProdIDTextBox.TabIndex = 49;
            this.ProdIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdIDTextBox_KeyPress);
            // 
            // EditIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(146)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(517, 389);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchDPQuantityTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DelProdQuantityTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SoldProdQuantityTextBox);
            this.Controls.Add(this.SoldProdPriceTextBox);
            this.Controls.Add(this.DelProdPriceTextBox);
            this.Controls.Add(this.ProdIDTextBox);
            this.Name = "EditIncome";
            this.Text = "Изменить информацию о прибыли";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchDPQuantityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DelProdQuantityTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SoldProdQuantityTextBox;
        private System.Windows.Forms.TextBox SoldProdPriceTextBox;
        private System.Windows.Forms.TextBox DelProdPriceTextBox;
        private System.Windows.Forms.TextBox ProdIDTextBox;
    }
}