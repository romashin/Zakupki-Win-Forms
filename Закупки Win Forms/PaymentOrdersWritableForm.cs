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
    public partial class PaymentOrdersWritableForm : Form
    {
        private DB db = new DB();
        private DataTable paymentOrdersTable = new DataTable();

        public PaymentOrdersWritableForm()
        {
            InitializeComponent();
            Load += PaymentOrdersWritableForm_Load;
        }

        private void PaymentOrdersWritableForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Загрузка данных из таблицы payment_orders
        private void LoadData()
        {
            try
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM payment_orders", db.getConnection()))
                {
                    paymentOrdersTable.Clear();
                    adapter.Fill(paymentOrdersTable);

                    dataGridViewPayments.DataSource = paymentOrdersTable;
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
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM payment_orders", db.getConnection()))
                {
                    NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);

                    // Сохраняем изменения в БД
                    adapter.Update(paymentOrdersTable);

                    MessageBox.Show("Изменения успешно сохранены.");
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
