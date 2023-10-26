using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ApothecaryApp
{
    public partial class SearchWindow : Form
    {
        readonly ApothecaryEntities db = new ApothecaryEntities();
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
            try
            {
                string chosentype = SearchComboBox.SelectedItem.ToString();
                switch (chosentype)
                {
                    case "Название лекарства":
                        string searchname = SearchTextBox.Text;
                        var search = from m in db.Список_Товаров
                                     where m.Название_Товара == searchname
                                     select m;
                        dataGridView1.DataSource = search.ToList();
                        break;
                    case "Группа лекарств":
                        string searchgroup = SearchTextBox.Text;
                        search = from m in db.Список_Товаров
                                 where m.Группа == searchgroup
                                 select m;
                        dataGridView1.DataSource = search.ToList();
                        break;
                    case "Дата изготовления":
                        DateTime searchproddate = Convert.ToDateTime(SearchTextBox.Text);
                        search = from m in db.Список_Товаров 
                                 where m.Дата_Изготовления == searchproddate 
                                 select m;
                        dataGridView1.DataSource = search.ToList();
                        break;
                    case "Срок годности":
                        DateTime searchexpdate = Convert.ToDateTime(SearchTextBox.Text);
                        search = from m in db.Список_Товаров 
                                 where m.Дата_Окончания_Срока_Годности == searchexpdate 
                                 select m;
                        dataGridView1.DataSource = search.ToList();
                        break;
                    case "Производитель":
                        string searchcompany = SearchTextBox.Text;
                        search = from m in db.Список_Товаров 
                                 where m.Производитель == searchcompany 
                                 select m;
                        dataGridView1.DataSource = search.ToList();
                        break;
                    case "Дозировка":
                        int searchdose = Convert.ToInt32(SearchTextBox.Text);
                        search = from m in db.Список_Товаров 
                                 where m.Дозировка == searchdose 
                                 select m;
                        dataGridView1.DataSource = search.ToList();
                        break;
                    case "Компания поставщика":
                        string searchdelcompany = SearchTextBox.Text;
                        var search2 = from c in db.Поставщики 
                                      where c.Название == searchdelcompany 
                                      select c;
                        dataGridView1.DataSource = search2.ToList();
                        break;
                    case "ФИО поставщика":
                        string searchfullname = SearchTextBox.Text;
                        search2 = from c in db.Поставщики 
                                  where c.ФИО == searchfullname 
                                  select c;
                        dataGridView1.DataSource = search2.ToList();
                        break;
                    case "Номер телефона поставщика":
                        int searchnumber = Convert.ToInt32(SearchTextBox.Text);
                        search2 = from c in db.Поставщики 
                                  where c.Телефон == searchnumber 
                                  select c;
                        dataGridView1.DataSource = search2.ToList();
                        break;
                    case "Город поставщика":
                        string searchcity = SearchTextBox.Text;
                        search2 = from c in db.Поставщики 
                                  where c.Город == searchcity 
                                  select c;
                        dataGridView1.DataSource = search2.ToList();
                        break;
                    case "Дата поставки":
                        DateTime deldate = Convert.ToDateTime(SearchTextBox.Text);
                        var search3 = from d in db.Расчет_с_поставщиками 
                                      where d.Дата_поставки == deldate 
                                      select d;
                        dataGridView1.DataSource = search3.ToList();
                        break;
                    case "Дата продажи":
                        DateTime saledate = Convert.ToDateTime(SearchTextBox.Text);
                        var search4 = from s in db.Продажи 
                                      where s.Дата_продажи == saledate 
                                      select s;
                        dataGridView1.DataSource = search4.ToList();
                        break;
                    case "Дата списания":
                        DateTime writeoffdate = Convert.ToDateTime(SearchTextBox.Text);
                        var search5 = from w in db.Списание 
                                      where w.Дата_Списания == writeoffdate 
                                      select w;
                        dataGridView1.DataSource = search5.ToList();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
