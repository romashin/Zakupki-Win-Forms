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
    public partial class ContractWriteableForm : Form
    {
        public ContractWriteableForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            using (var adapter = new NpgsqlDataAdapter("SELECT * FROM Contracts", db.getConnection()))
            {
                db.openConnnection();
                adapter.Fill(table);
                db.closeConnnection();
            }

            dataGridViewContracts.DataSource = table;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            var table = (DataTable)dataGridViewContracts.DataSource;

            if (table == null)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }

            DB db = new DB();
            db.openConnnection();

            using (var cmdBuilder = new NpgsqlCommandBuilder(new NpgsqlDataAdapter("SELECT * FROM Contracts", db.getConnection())))
            using (var adapter = new NpgsqlDataAdapter(cmdBuilder.DataAdapter.SelectCommand.CommandText, db.getConnection()))
            {
                var commandInsert = new NpgsqlCommand("INSERT INTO Contracts (...) VALUES (...)", db.getConnection());
                // Можно улучшить через автоматическую генерацию команд через CommandBuilder

                var changes = table.GetChanges();

                if (changes != null)
                {
                    var updateCmd = cmdBuilder.GetUpdateCommand();
                    adapter.UpdateCommand = updateCmd;
                    adapter.InsertCommand = cmdBuilder.GetInsertCommand();
                    adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();

                    adapter.Update(changes);
                    table.AcceptChanges();
                    MessageBox.Show("Изменения успешно сохранены.");
                }
                else
                {
                    MessageBox.Show("Изменений нет.");
                }
            }

            db.closeConnnection();
        }
    }
}
