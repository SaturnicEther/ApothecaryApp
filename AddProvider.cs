using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class AddProvider : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public AddProvider()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
            try
            {
                Поставщики p = new Поставщики
                {
                    Название = ProviderNameTextBox.Text,
                    ФИО = FullNameTextBox.Text,
                    Телефон = Convert.ToInt32(TelephoneTextBox.Text),
                    Город = CityTextBox.Text
                };
                db.Поставщики.Add(p);
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

        private void TelephoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '\u002E')
            {
                e.Handled = true;
            }
        }

        private void CityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '\u002E')
            {
                e.Handled = true;
            }
        }
    }
}
