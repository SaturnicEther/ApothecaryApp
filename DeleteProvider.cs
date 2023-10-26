using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class DeleteProvider : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public DeleteProvider()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
            try
            {
                string searchname = NameSearchTextBox.Text;
                var search = (from p in db.Поставщики 
                              where p.Название.Contains(searchname) 
                              select p).FirstOrDefault();
                if (search != null)
                {
                    ProviderNameTextBox.Text = search.Название;
                    FullNameTextBox.Text = search.ФИО;
                    TelephoneTextBox.Text = search.Телефон.ToString();
                    CityTextBox.Text = search.Город;
                }
                else
                {
                    MessageBox.Show("Такого поставщика нет в базе данных!", "Ошибка",
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
                Поставщики p = new Поставщики 
                { 
                    Название = ProviderNameTextBox.Text,
                    ФИО = FullNameTextBox.Text,
                    Телефон = Convert.ToInt32(TelephoneTextBox.Text),
                    Город = CityTextBox.Text
                };
                DialogResult result = MessageBox.Show("Вы точно хотите удалить данного поставщика?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.Поставщики.Remove(p);
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
