using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class EditWriteoff : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public EditWriteoff()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
            try
            {
                DateTime searchdate = Convert.ToDateTime(DateSearchTextBox.Text);
                var search = (from p in db.Списание
                              where p.Дата_Списания == searchdate
                              select p).FirstOrDefault();
                if (search != null)
                {
                    DateSearchTextBox.Text = search.Дата_Списания.ToString();
                    ProductIDTextBox.Text = search.Id_Товара.ToString();
                    PriceTextBox.Text = search.Стоимость.ToString();
                    QuantityTextBox.Text = search.Количество.ToString();
                }
                else
                {
                    MessageBox.Show("Такого списания нет в базе данных!", "Ошибка",
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
                Списание w = new Списание
                {
                    Дата_Списания = Convert.ToDateTime(WriteoffDateTextBox.Text),
                    Id_Товара = Convert.ToInt32(ProductIDTextBox.Text),
                    Стоимость = Convert.ToDecimal(PriceTextBox.Text),
                    Количество = Convert.ToInt32(QuantityTextBox.Text)
                };
                if (w.Количество <= 0 || w.Стоимость <= 0)
                {
                    MessageBox.Show("Слишком малая стоимость или количество!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Списание.Add(w);
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

        private void WriteoffDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DateSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '\u002E')
            {
                e.Handled = true;
            }
        }
    }
}
