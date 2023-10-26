﻿using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class EditIncome : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public EditIncome()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
            try
            {
                int searchquantity = Convert.ToInt32(SearchDPQuantityTextBox.Text);
                var search = (from i in db.Прибыль
                              where i.Количество_Привезенных_Товаров
                              == searchquantity
                              select i).FirstOrDefault();
                if (search != null)
                {
                    ProdIDTextBox.Text = search.Id_Товара.ToString();
                    DelProdPriceTextBox.Text = search.Стоимость_Привезенных_Товаров.ToString();
                    DelProdQuantityTextBox.Text = search.Количество_Привезенных_Товаров.ToString();
                    SoldProdPriceTextBox.Text = search.Стоимость_Продажи_Товаров.ToString();
                    SoldProdQuantityTextBox.Text = search.Количество_Продажи_Товаров.ToString();
                }
                else
                {
                    MessageBox.Show("Такой прибыли нет в базе данных!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
            try
            {
                Прибыль i = new Прибыль
                {
                    Id_Товара = Convert.ToInt32(ProdIDTextBox.Text),
                    Стоимость_Привезенных_Товаров = Convert.ToDecimal(DelProdPriceTextBox.Text),
                    Количество_Привезенных_Товаров = Convert.ToInt32(DelProdQuantityTextBox.Text),
                    Стоимость_Продажи_Товаров = Convert.ToDecimal(SoldProdPriceTextBox.Text),
                    Количество_Продажи_Товаров = Convert.ToInt32(SoldProdQuantityTextBox.Text)
                };
                if (i.Количество_Привезенных_Товаров <= 0 || i.Количество_Продажи_Товаров <= 0)
                {
                    MessageBox.Show("Слишком малое количество!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Прибыль.Add(i);
                db.SaveChanges();
                Thread.Sleep(1000);
                MessageBox.Show("Данные сохранены успешно!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();    
        }

        private void SearchDPQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void ProdIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void DelProdPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void DelProdQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void SoldProdPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void SoldProdQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
