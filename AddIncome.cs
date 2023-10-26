using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class AddIncome : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public AddIncome()
        {
            InitializeComponent();
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
