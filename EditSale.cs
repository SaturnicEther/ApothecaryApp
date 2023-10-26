using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace ApothecaryApp
{
    public partial class EditSale : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public EditSale()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
            try
            {
                DateTime searchdate = Convert.ToDateTime(SearchDateTextBox.Text);
                var search = (from s in db.Продажи
                              where s.Дата_продажи == searchdate
                              select s).FirstOrDefault();
                if (search != null)
                {
                    SaleDateTextBox.Text = search.Дата_продажи.ToString();
                    ProductIDTextBox.Text = search.Id_товара.ToString();
                    PriceTextBox.Text = search.Стоимость.ToString();
                    QuantityTextBox.Text = search.Количество.ToString();
                }
                else
                {
                    MessageBox.Show("Такой продажи нет в базе данных!", "Ошибка",
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
                Продажи p = new Продажи
                {
                    Дата_продажи = Convert.ToDateTime(SaleDateTextBox.Text),
                    Id_товара = Convert.ToInt32(ProductIDTextBox.Text),
                    Стоимость = Convert.ToDecimal(PriceTextBox.Text),
                    Количество = Convert.ToInt32(QuantityTextBox.Text)
                };
                if (p.Количество <= 0 || p.Стоимость <= 0)
                {
                    MessageBox.Show("Слишком малая стоимость или количество!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Продажи.Add(p);
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

        private void SearchDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '\u002E')
            {
                e.Handled = true;
            }
        }

        private void SaleDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '\u002E')
            {
                e.Handled = true;
            }
        }

        private void ProductIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
