using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class EditPay : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public EditPay()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
            try
            {
                DateTime searchdate = Convert.ToDateTime(DateSearchTextBox.Text);
                var search = (from p in db.Расчет_с_поставщиками
                              where p.Дата_поставки == searchdate
                              select p).FirstOrDefault();
                if (search != null)
                {
                    DeliveryDateTextBox.Text = search.Дата_поставки.ToString();
                    ProviderIDTextBox.Text = search.Id_поставщика.ToString();
                    SumTextBox.Text = search.Сумма_прибыли.ToString();
                }
                else
                {
                    MessageBox.Show("Такого расчёта нет в базе данных!", "Ошибка",
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
                Расчет_с_поставщиками po = new Расчет_с_поставщиками
                {
                    Дата_поставки = Convert.ToDateTime(DeliveryDateTextBox.Text),
                    Id_поставщика = Convert.ToInt32(ProviderIDTextBox.Text),
                    Сумма_прибыли = Convert.ToDecimal(SumTextBox.Text)
                };
                if (po.Сумма_прибыли <= 0)
                {
                    MessageBox.Show("Слишком малая сумма прибыли!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Расчет_с_поставщиками.Add(po);
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

        private void DateSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '\u002E')
            {
                e.Handled = true;
            }
        }

        private void DeliveryDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '\u002E')
            {
                e.Handled = true;
            }
        }

        private void ProviderIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void SumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
