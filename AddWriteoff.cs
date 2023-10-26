using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class AddWriteoff : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public AddWriteoff()
        {
            InitializeComponent();
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
    }
}
