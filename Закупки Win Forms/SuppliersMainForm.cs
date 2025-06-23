using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Закупки_Win_Forms
{
    public partial class SuppliersMainForm : Form
    {
        private DB db = new DB();
        public SuppliersMainForm()
        {
            InitializeComponent();
            Load += SuppliersMainForm_Load;
        }

        private void SuppliersMainForm_Load(object sender, EventArgs e)
        {
            LoadSuppliersData();
        }

        private void LoadSuppliersData()
        {
            try
            {
                DataTable table = new DataTable();

                // Открываем соединение
                db.openConnnection();

                // SQL-запрос
                string query = "SELECT * FROM Temp_suppliers";

                // Создаем адаптер и заполняем таблицу данными
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, db.getConnection()))
                {
                    adapter.Fill(table);
                }

                // Привязка данных к DataGridView
                dataGridView1.DataSource = table;

                // Закрываем соединение
                db.closeConnnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
