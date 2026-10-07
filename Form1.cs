using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;
using System.Text.Json;
using System.Drawing.Text;
using Microsoft.VisualBasic;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.Services;
using System.Net.Http.Headers;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<Product> productList = new List<Product>();
        private List<string> storageJournal = new List<string>();
       
        
        private void LoadwareData()
        {
            try
            {


                productList = WarehouseService.LoadwarehouseData();
                    dataGridView1.Rows.Clear();

                    foreach(var  product in productList)
                    {
                    DateTime today = DateTime.Today;
                    int daysLeft=(DateTime.Parse(product.ExpiryDate)-today).Days;
                    string statusText = "Свежий";
                    Color statusColor = Color.LightGreen;
                    Color textColor = Color.Black;
                    if(daysLeft < 0)
                    {
                        statusText = "ПРОСРОЧЕНО";
                        statusColor = Color.Red;
                        textColor = Color.White;
                    }
                    else if(daysLeft <=4)
                    {
                        statusText = "Срок заканчивается!";
                        statusColor = Color.Yellow;
                        textColor = Color.Black;
                    }
                    dataGridView1.Rows.Add(
                        product.Name,
                        product.Category,
                        product.TotalStock,

                        product.FreeStock,
                        product.Reserved,
                        product.DeliveryDate,
                        product.ExpiryDate,

                        statusText
                            );
                    int lastRowIndex=dataGridView1.Rows.Count-1;
                    dataGridView1.Rows[lastRowIndex].Cells[7].Style.BackColor = statusColor;
                    dataGridView1.Rows[lastRowIndex].Cells[7].Style.ForeColor = textColor;

                    }
                
                UpdateWarehouseLoad();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных склада: " + ex.Message,"Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public Form1()
        {
            InitializeComponent();
            
           textBoxName.Text = "Название товара";
            textBoxName.ForeColor = Color.Gray;
            LoadwareData();
           JournalHelper.Writejournal("Смена начата. Программа успешно запущена кладовщиком.",storageJournal);
            categoryComboBox.SelectedIndex = 0;
        }
        
        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDownCount.Value = trackBar1.Value;
            label1.Text = "Выбрано количество: " + trackBar1.Value.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Ошибка! нельзя добавить товар без названия. Пожалуйста, введите имя товара!","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка! Пожалуйста, выберите категорию товара из списка!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product newproduct = new Product
            {
            Name=textBoxName.Text,
            Category=comboBoxCategory.Text,
            TotalStock=trackBar1.Value,
            Reserved=0,
            FreeStock=trackBar1.Value,
            DeliveryDate=DateTime.Now.ToShortDateString(),
            ExpiryDate=dateTimePickerExpiry.Value.ToShortDateString()

            };
            productList.Add(newproduct);
            dataGridView1.Rows.Add(

                newproduct.Name,
                newproduct.Category,
                newproduct.TotalStock,
                newproduct.FreeStock,
                 newproduct.Reserved,
                newproduct.DeliveryDate,
                newproduct.ExpiryDate
                );
            UpdateWarehouseLoad();
            JournalHelper.Writejournal("Добавлен товар: "+ newproduct.Name + " | Кол-во: " + newproduct.TotalStock + " шт. | Годен до: " + newproduct.ExpiryDate,storageJournal);

            WarehouseService.SavewarehouseData(productList);
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow==null)
            {
                MessageBox.Show("Пожалуйста,выберите товар в таблице!","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            //Всего на складе
            int totalfStock = Convert.ToInt32(selectedRow.Cells[2].Value);
            //текущийрезерв
            int currentReserve = Convert.ToInt32(selectedRow.Cells[4].Value);
            //СколькоРезервируем
            int reserveAmount=(int)numericUpDownCount.Value;
            int freestock = Convert.ToInt32(selectedRow.Cells[3].Value);
            if(reserveAmount>freestock)
            {
                MessageBox.Show("Ошибка! Нельзя зарезервировать больше,чем есть на складе!", "Ошибка резерва", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedRow.Cells[4].Value = currentReserve + reserveAmount;
            selectedRow.Cells[3].Value = freestock - reserveAmount;
            int rowIndex = selectedRow.Index;
            if(rowIndex>=0&&rowIndex<productList.Count)
            {
                productList[rowIndex].Reserved = currentReserve + reserveAmount;
                productList[rowIndex].FreeStock = freestock - reserveAmount;
            }
            JournalHelper.Writejournal("Зарезервирован товар: " + Convert.ToString(selectedRow.Cells[0].Value)+"в количестве "+ reserveAmount+ " шт.",storageJournal);
            WarehouseService.SavewarehouseData(productList);
            MessageBox.Show("Товар успешно зарезервирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {

            trackBar1.Value = (int)numericUpDownCount.Value;
            label1.Text = "Выбрано количество: " + numericUpDownCount.Value.ToString();
        }

        private void numericUpDownCount_KeyUp(object sender, KeyEventArgs e)
        {
            trackBar1.Value = (int)numericUpDownCount.Value;
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow==null)
            {
                MessageBox.Show("Пожалуйста, выберите товар в таблице!","Внимание",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            int totalstock = Convert.ToInt32(selectedRow.Cells[2].Value);
            int currentreserve = Convert.ToInt32(selectedRow.Cells[4].Value);
            int freeStock = Convert.ToInt32(selectedRow.Cells[3].Value);
            int sellAmount=(int)numericUpDownCount.Value;
            if(checkBoxfromreserv.Checked)
            {
                if(sellAmount>currentreserve)
                {
                    MessageBox.Show($"Ошибка! В резерве отложен только {currentreserve} шт.!", "Ошибка резерва", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                  selectedRow.Cells[2].Value = totalstock - sellAmount;
                     selectedRow.Cells[4].Value = currentreserve- sellAmount;
                int rowIndex = selectedRow.Index;
                if(rowIndex>=0&&rowIndex<productList.Count)
                {
                    productList[rowIndex].TotalStock = totalstock - sellAmount;
                    productList[rowIndex].Reserved=currentreserve- sellAmount;
                }
               JournalHelper.Writejournal("Выданно из резерва: " + Convert.ToString(selectedRow.Cells[0].Value) + " (" + sellAmount + " шт.)",storageJournal);
                 WarehouseService.SavewarehouseData(productList);
                MessageBox.Show("Товар успешно выдан из резерва!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(sellAmount>totalstock)
                {
                    MessageBox.Show("Ошибка! На складе нет такого количество товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if(sellAmount>freeStock)
                {
                    MessageBox.Show($"Ошибка! свободно для продажи тольк {freeStock} шт. Остальное в резерве!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                selectedRow.Cells[2].Value = totalstock - sellAmount;
                selectedRow.Cells[3].Value= freeStock- sellAmount;
                int rowIndexNormal= selectedRow.Index;
                if(rowIndexNormal>=0 && rowIndexNormal<productList.Count)
                {
                    productList[rowIndexNormal].TotalStock = totalstock - sellAmount;
                    productList[rowIndexNormal].FreeStock = freeStock - sellAmount;
                }
                JournalHelper.Writejournal("Продан товар: " + Convert.ToString(selectedRow.Cells[0].Value) + " (" + sellAmount + "шт. )",storageJournal);
                 WarehouseService.SavewarehouseData(productList);
                MessageBox.Show("Товар успешно продан обычному покупателю","Успех",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void checkBoxfromreserv_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxfromreserv.Checked)
            {
                buttonSell.Text = "Продать из резерва";
            }
            else
            {
                buttonSell.Text = "Продать товар";
            }
        }

        
        private void buttonUnreserve_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите товар в таблице! ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            int currentReserve = Convert.ToInt32(selectedRow.Cells[4].Value);
            int freeStock=Convert.ToInt32(selectedRow.Cells [3].Value);
            int unreserveAmount = (int)numericUpDownCount.Value;
            if (unreserveAmount > currentReserve)
            {
                MessageBox.Show($"Ошибка! в резерве отложенно только {currentReserve} шт.,вы не можете снять {unreserveAmount} шт.", "Ошибка снятия", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedRow.Cells[4].Value = currentReserve - unreserveAmount;
            selectedRow.Cells[3].Value = freeStock + unreserveAmount;
            int Unreserve = selectedRow.Index;
            if(Unreserve>=0&&Unreserve<productList.Count)
            {
                productList[Unreserve].Reserved = currentReserve - unreserveAmount;
                productList[Unreserve].FreeStock = freeStock + unreserveAmount;
            }
            JournalHelper.Writejournal("Снято с резерва: " + Convert.ToString(selectedRow.Cells[0].Value) + "в количестве " + unreserveAmount + "шт.",storageJournal);
             WarehouseService.SavewarehouseData(productList);
            MessageBox.Show("Товар успешно снят с резерва!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateWarehouseLoad()
        {
            int totalItemsWarhouse = 0;
            int maxCapacity = 1000;

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value!=null)
                {
                    totalItemsWarhouse += Convert.ToInt32(row.Cells[2].Value);
                }
            }
            if(totalItemsWarhouse > maxCapacity)
            {
                totalItemsWarhouse=maxCapacity;
            }
            int percentLoad = (totalItemsWarhouse * 100) / maxCapacity;
            progressBar1.Value = percentLoad;
            labelStorageInfo.Text = $"Заполненность склада: {percentLoad}% ({totalItemsWarhouse}/{maxCapacity} шт.)";
        }

        

        private void textBoxName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxName.Text == "Название товара")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
           
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.Text = "Название товара";
                textBoxName.ForeColor = Color.Gray;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow==null)
            {
                MessageBox.Show("Пожалуйста,выберите товар в таблице!","Внимание",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            string productName=Convert.ToString(selectedRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Вы уверенны, что хотите удалить товар" + productName + "?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             
            if(result==DialogResult.Yes)
            {
                int rowIndexdell = selectedRow.Index;
                if(rowIndexdell >=0&&rowIndexdell<productList.Count)
                {
                    productList.RemoveAt(rowIndexdell);
                }
                dataGridView1.Rows.Remove(selectedRow);
                UpdateWarehouseLoad();
                JournalHelper.Writejournal("УДАЛЕН ТОВАР: " + productName,storageJournal);
                 WarehouseService.SavewarehouseData(productList);
                MessageBox.Show("Товар успешно удален со склада!","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
           
        }

        private void SaveToMenu_Click(object sender, EventArgs e)
        {
             WarehouseService.SavewarehouseData(productList);
            MessageBox.Show("Данные склада успешно сохранены в файл JSON!","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information );
        }

        private void Information_Click(object sender, EventArgs e)
        {
            string aboutinfo = "📦 СИСТЕМА УПРАВЛЕНИЯ СКЛАДОМ <<МОЙ СКЛАД>>\n" +
                "=======================================\n" +
                "💠 Версия программы: 1.0.0 (Стабильная)\n" +
                "💠 Платформа: .NET Framework / Winforms\n\n" +
                "💻 ИНФОРМАЦИЯ ОБ АВТОРЕ:\n" +
                "------------------------------------------------------------------------------\n" +
                "🔵 Разработчик: студент Амаяк\n" +
                "🔵 Год создания проекта: 2026 год\n\n" +
                "🛡️ МОДУЛИ БЕЗОПАСНОСТИ И УЧЕТА:\n" +
                "------------------------------------------------------------------------------\n" +
                "✔️ База данных: Автоматическое сохранение в формат [JSON]\n" +
                "✔️ Аудит операций: Система непрерывного логирования действий в [TXT]\n" +
                "✔️ Контроль рисков: Защита от Махинаций и превышения лимитов склада\n" +
                "=======================================\n" +
                "©️ 2026 Все права защищены. Программа готова к проверке.";
            MessageBox.Show(aboutinfo, "О программе <<Мой Склад>>", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверенны, что хотите закрыть программу 'Мой Склад'? \n\n" +
                " Убедитесь, что все важные данные сохранены.\n ",
                "Подтверждение выхода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                 );
            if( result == DialogResult.No )
            {
                e.Cancel = true;
            }
            else
            {
                JournalHelper.Writejournal("Смена окончена. Программа успешно закрыта кладовщиком.",storageJournal);
            }

        }

        private void ClearWarehousmenu_Click(object sender, EventArgs e)
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите секретный пароль Администратора:","Доступ ограничен 🔒",""
                );
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Вы не ввели пароль"/*,MessageBoxButtons.OK,MessageBoxIcon.Information*/);
                return;
            }
            string curentPassword = System.IO.File.Exists("pass.txt") ? System.IO.File.ReadAllText("pass.txt").Trim() : "1234";
            if ( password !=curentPassword )
            {
                MessageBox.Show("Доступ запрещен! Не верный пароль Администратора.",
                    "Ошибка безопасности", MessageBoxButtons.OK, MessageBoxIcon.Error

                    );
                JournalHelper.Writejournal("ВНИМАНИЕ: Зафиксирована неудачная попытка очистки склада! Введен неверный пароль.", storageJournal);
                return;
            }
            DialogResult result = MessageBox.Show("Пароль подтвержден.\nВы точно хотите ПОЛНОСТЬЮ очистить склад?\nВсе товары будут безвозвратно удалены из базы JSON!",
                "Финальное подтверждение",MessageBoxButtons.YesNo, MessageBoxIcon.Warning

                );
            if(result== DialogResult.Yes )
            {
                productList.Clear();
                dataGridView1.Rows.Clear();
                UpdateWarehouseLoad();
                 WarehouseService.SavewarehouseData(productList);
                JournalHelper.Writejournal("АДМИНИСТРАТОР: Произведена полная отчистка базы данных склада.", storageJournal);
                MessageBox.Show("База данных склада успешно обнулена!", "Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void ClearJournalmenu_Click(object sender, EventArgs e)
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите секретный пароль Администратора для удаления логов журнала:",
                "Доступ ограничен 🔒",""
                );
            if(string.IsNullOrEmpty(password) )
            {
                return;
            }
            string curentPassword = System.IO.File.Exists("pass.txt") ? System.IO.File.ReadAllText("pass.txt").Trim() : "1234";
            if (password != curentPassword)
            {
                MessageBox.Show("Доступ запрещен! Не верный пароль Администратора.",
                    "Ошибка безопасности", MessageBoxButtons.OK, MessageBoxIcon.Error

                    );
                JournalHelper.Writejournal("ВНИМАНИЕ: Зафиксирована неудачная попытка очистки склада! Введен неверный пароль.", storageJournal);
                return;
            }
            DialogResult result = MessageBox.Show("Пароль подтвержден.\nВы точно хотите ПОЛНОСТЬЮ стереть всю историю изфайла journal.txt?",
               "Финальное подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                System.IO.File.WriteAllText("journal.txt", string.Empty);
                JournalHelper.Writejournal("Журнал действий успешно очищен Администратором склада.", storageJournal);
                MessageBox.Show("Журнал действий полностью очищен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportReportMenu_Click(object sender, EventArgs e)
        {
            if (productList.Count == 0)
            {
                MessageBox.Show("На складе нет товаров для формирования отчета!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            System.Text.StringBuilder report = new System.Text.StringBuilder();
            report.AppendLine("================================================================================");
            report.AppendLine("Официальная Ведомость остатков склада");
            report.AppendLine($"Дата формирования: {DateTime.Now.ToString("dd.mm.yyyy  HH:mm:ss")}");
            report.AppendLine("=================================================================================");
            report.AppendLine(string.Format("{0,-20} | {1,-18} | {2,-10} | {3,-10} | {4,-10}",
                "Название","Категории","Количество","Доступно","В резерве"
                ));
            report.AppendLine("---------------------------------------------------------------------------------");
            foreach(var product in productList)
            {
                report.AppendLine(string.Format("{0,-20} | {1,-18} | {2,-10} | {3,-10} | {4,-10}",
                    product.Name,product.Category,product.TotalStock,product.FreeStock,product.Reserved
                    ));

            }
            report.AppendLine("==================================================================================");
            System.IO.File.WriteAllText("report.txt", report.ToString());
            JournalHelper.Writejournal("ОТЧЕТ: Сформирован и выгружен экспорт остатков склада в файл report.txt", storageJournal);
                MessageBox.Show("Отчет успешно сформирован и сохранен в файл report.txt","УСПЕХ",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = searchTextBox.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(searchText))
                {
                    LoadwareData();
                    return;
                }
                var filteredList = productList.FindAll(p => p.Name.ToLower().Contains(searchText));
                dataGridView1.Rows.Clear();
                foreach (var product in filteredList)
                {
                    DateTime today = DateTime.Today;
                    int daysLeft = (DateTime.Parse(product.ExpiryDate) - today).Days;
                    string statusText = "Свежий";
                    Color statusColor = Color.LightGreen;
                    Color textColor = Color.Black;
                    if (daysLeft < 0)
                    {
                        statusText = "ПРОСРОЧЕНО";
                        statusColor = Color.Red;
                        textColor = Color.White;
                    }
                    else if (daysLeft <= 4)
                    {
                        statusText = "Срок заканчивается!";
                        statusColor = Color.Yellow;
                        textColor = Color.Black;
                    }
                    dataGridView1.Rows.Add(
                    product.Name,
                    product.Category,
                    product.TotalStock,
                    product.FreeStock,
                     product.Reserved,
                    product.DeliveryDate,
                    product.ExpiryDate,
                    statusText
                    );
                    int lastRowIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows[lastRowIndex].Cells[7].Style.BackColor = statusColor;
                    dataGridView1.Rows[lastRowIndex].Cells[7].Style.ForeColor = textColor;
                }
                UpdateWarehouseLoad();
            }
            
            catch( Exception ex )
            {
                MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedCategory=categoryComboBox.SelectedItem?.ToString();
                if(string.IsNullOrEmpty(selectedCategory)||selectedCategory=="Все категории")
                {
                    LoadwareData();
                    return;
                }
                var filteredList=productList.FindAll(p=>p.Category==selectedCategory);
                dataGridView1.Rows.Clear();
                foreach( var product in filteredList)
                {
                    DateTime today = DateTime.Today;
                    int daysLeft = (DateTime.Parse(product.ExpiryDate) - today).Days;
                    string statusText = "Свежий";
                    Color statusColor = Color.LightGreen;
                    Color textColor = Color.Black;
                    if (daysLeft < 0)
                    {
                        statusText = "ПРОСРОЧЕНО";
                        statusColor = Color.Red;
                        textColor = Color.White;
                    }
                    else if (daysLeft <= 4)
                    {
                        statusText = "Срок заканчивается!";
                        statusColor = Color.Yellow;
                        textColor = Color.Black;
                    }
                    dataGridView1.Rows.Add(

                         product.Name,
                    product.Category,
                    product.TotalStock,
                    product.FreeStock,
                     product.Reserved,
                    product.DeliveryDate,
                    product.ExpiryDate,
                    statusText
                        );
                    int lastRowIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows[lastRowIndex].Cells[7].Style.BackColor = statusColor;
                    dataGridView1.Rows[lastRowIndex].Cells[7].Style.ForeColor = textColor;
                }
                UpdateWarehouseLoad();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Ошибка фильтрации: " + ex.Message,"Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль администратора: ",
                    "Смена пароля","1234"
                    
                    );
                if(!string.IsNullOrEmpty(input))
                {
                    System.IO.File.WriteAllText("pass.txt", input.Trim());
                    JournalHelper.Writejournal("Безопасность: Произведена успешная смена пароля администратора. ", storageJournal);
                    MessageBox.Show("Пароль администратора успешно изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при смене пароля: " + ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
