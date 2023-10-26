using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class DeleteWriteoff : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public DeleteWriteoff()
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

        private void DeleteButton_Click(object sender, EventArgs e)
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
                DialogResult result = MessageBox.Show("Вы точно хотите удалить данного поставщика?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.Списание.Remove(w);
                    db.SaveChanges();
                    Thread.Sleep(1000);
                    MessageBox.Show("Данные удалены успешно!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
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
    }
}
