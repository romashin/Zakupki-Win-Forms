using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Закупки_Win_Forms
{
    public partial class InvoicesWriteableForm : Form
    {
        private DB db = new DB();
        private DataTable invoicesTable = new DataTable();

        public InvoicesWriteableForm()
        {
        
            InitializeComponent();
            Load += InvoicesWriteableForm_Load;

        }

        private void InvoicesWriteableForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Загрузка данных из таблицы invoices
        private void LoadData()
        {
            try
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM invoices", db.getConnection()))
                {
                    invoicesTable.Clear();
                    adapter.Fill(invoicesTable);

                    dataGridViewInvoices.DataSource = invoicesTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }
        // Обработчик кнопки "Сохранить изменения"
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM invoices", db.getConnection()))
                {
                    // Установим команды обновления
                    NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);

                    // Обновляем БД
                    adapter.Update(invoicesTable);

                    MessageBox.Show("Изменения сохранены.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        // Обработчик кнопки "Обновить данные"
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }


    }
}
