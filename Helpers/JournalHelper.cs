using System;
using System.IO;
using System.Windows.Forms;

    
namespace WindowsFormsApp2.Helpers
{
    public static class JournalHelper
    {
        public static void Writejournal(string journalText,System.Collections.Generic.List<string>storageJournal)
        {
            string journal = $"[{DateTime.Now:dd.MM.yyyy  HH:mm:ss}] {journalText}";
            storageJournal.Add(journal);
            try
            {
                System.IO.File.AppendAllText("journal.txt", journal + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка записи в журнал: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
