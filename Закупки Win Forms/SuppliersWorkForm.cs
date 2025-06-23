using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace Закупки_Win_Forms
{
    public partial class SuppliersWorkForm : Form
    {
        private DB db = new DB();
        private DataTable suppliersTable = new DataTable();

        public SuppliersWorkForm()
        {
            InitializeComponent();
            LoadData();
        }

        // Загрузка данных из таблицы temp_suppliers
        private void LoadData(string filter = "")
        {
            using (NpgsqlConnection conn = db.getConnection())
            {
                db.openConnnection();

                string query = "SELECT id, inn, supplier_short_name, organizational_form, country_of_origin FROM temp_suppliers";

                if (!string.IsNullOrEmpty(filter))
                {
                    query += $" WHERE inn ILIKE '%{filter}%' OR supplier_short_name ILIKE '%{filter}%'";
                }

                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                {
                    suppliersTable.Clear();
                    adapter.Fill(suppliersTable);
                    dgvSuppliers.DataSource = suppliersTable;
                }

                db.closeConnnection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            LoadData(searchText);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditSupplierForm editForm = new EditSupplierForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["id"].Value);

                EditSupplierForm editForm = new EditSupplierForm(selectedId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите поставщика для редактирования.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["id"].Value);

                if (MessageBox.Show("Вы уверены, что хотите удалить этого поставщика?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using (NpgsqlConnection conn = db.getConnection())
                        {
                            db.openConnnection();
                            string query = "DELETE FROM temp_suppliers WHERE id = @id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", selectedId);
                                cmd.ExecuteNonQuery();
                            }
                            db.closeConnnection();
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите поставщика для удаления.");
            }
        }
    }
}