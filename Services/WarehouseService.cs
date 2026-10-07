using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;
using System.IO;
namespace WindowsFormsApp2.Services
{
    public static class WarehouseService
    {
        public static void SavewarehouseData(List<Product>productList)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    //Encoder чтобы в файле JSON был русский текст
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                string jsonString = JsonSerializer.Serialize(productList, options);
                System.IO.File.WriteAllText("sklad.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения данных склада: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public static List<Product>LoadwarehouseData()
            {
            try
            {
                if (File.Exists("sklad.json"))
                    {
                    string jsonString = File.ReadAllText("sklad.json");
                    return JsonSerializer.Deserialize<List<Product>>(jsonString) ?? new List<Product>();
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка загрузки данных в сервисе: ",ex.Message);
            }
            return new List<Product>();
        }

    }
}
