using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class AddMedicine : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
            try
            {
                Список_Товаров st = new Список_Товаров 
                { 
                    Название_Товара = MedicineNameTextBox.Text,
                    Группа = MedicineGroupTextBox.Text,
                    Дата_Изготовления = Convert.ToDateTime(ProdDateTextBox.Text),
                    Дата_Окончания_Срока_Годности = Convert.ToDateTime(ExpireDateTextBox.Text),
                    Производитель = CompanyTextBox.Text,
                    Дозировка = Convert.ToInt32(DoseTextBox.Text),
                    Id_поставщика = Convert.ToInt32(ProviderIdTextBox.Text)
                };
                if (st.Дозировка <= 0)
                {
                    MessageBox.Show("Слишком малая дозировка!", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Список_Товаров.Add(st);
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

        private void ProdDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '\u002E')
            {
                e.Handled = true;
            }
        }

        private void ExpireDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '\u002E')
            {
                e.Handled = true;
            }
        }

        private void ProviderIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void DoseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
