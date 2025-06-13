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
//using Npgsql;

namespace Закупки_Win_Forms
{

    public partial class SuppliersWriteableForm : Form
    {
        private DB db = new DB();
        private DataTable suppliersTable;
        public SuppliersWriteableForm()
        {
            InitializeComponent();

            // Привязка события Load
            this.Load += SuppliersWriteableForm_Load;

            // Привязка события закрытия формы (для закрытия соединения)
            this.FormClosed += SuppliersWriteableForm_FormClosed;

            saveButton.Click += saveButton_Click;
        }

        private void SuppliersWriteableForm_Load(object sender, EventArgs e)
        {
            LoadSuppliersData();
        }

        private void SuppliersWriteableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.closeConnnection();
        }

        private void LoadSuppliersData()
        {
            ///
                
            ///
            try
            {
                suppliersTable = new DataTable();

                db.openConnnection();
                string query = "SELECT * FROM Suppliers";

                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, db.getConnection()))
                {
                    adapter.Fill(suppliersTable);
                }

                dataGridView1.DataSource = suppliersTable;
                dataGridView1.ReadOnly = false;

                /// === Здесь переименовываем заголовки столбцов ===
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    switch (column.Name)
                    {
                        case "ID":
                            column.HeaderText = "Идентификатор";
                            break;
                        case "Supplier_full_name":
                            column.HeaderText = "Полное наименование";
                            break;
                        case "Supplier_short_name":
                            column.HeaderText = "Краткое наименование";
                            break;
                        case "Organizational_form":
                            column.HeaderText = "Организационная форма";
                            break;
                        case "INN":
                            column.HeaderText = "ИНН";
                            break;
                        case "KPP":
                            column.HeaderText = "КПП";
                            break;
                        case "OGRN":
                            column.HeaderText = "ОГРН";
                            break;
                        case "Supplier_addres":
                            column.HeaderText = "Адрес поставщика";
                            break;
                        case "Date_of_reg":
                            column.HeaderText = "Дата регистрации";
                            break;
                        case "SMSP_attribute":
                            column.HeaderText = "Атрибут СМСП";
                            break;
                        case "Date_of_SMSP":
                            column.HeaderText = "Дата СМСП";
                            break;
                        case "Date_of_information":
                            column.HeaderText = "Дата информации";
                            break;
                    }
                }
                ///

                db.closeConnnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void SaveSuppliersData()
        {
            if (suppliersTable == null || suppliersTable.GetChanges() == null)
            {
                MessageBox.Show("Нет измененных данных.");
                return;
            }

            try
            {
                db.openConnnection();

                foreach (DataRow row in suppliersTable.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        // === Обновление существующей записи ===
                        using (var cmd = new NpgsqlCommand(
                            @"UPDATE Suppliers SET 
                        Supplier_full_name = @Supplier_full_name,
                        Supplier_short_name = @Supplier_short_name,
                        Organizational_form = @Organizational_form,
                        INN = @INN,
                        KPP = @KPP,
                        OGRN = @OGRN,
                        Supplier_addres = @Supplier_addres,
                        Date_of_reg = @Date_of_reg,
                        SMSP_attribute = @SMSP_attribute,
                        Date_of_SMSP = @Date_of_SMSP,
                        Date_of_information = @Date_of_information
                      WHERE ID = @ID", db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("ID", row["ID"]);
                            cmd.Parameters.AddWithValue("Supplier_full_name", row["Supplier_full_name"]);
                            cmd.Parameters.AddWithValue("Supplier_short_name", row["Supplier_short_name"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Organizational_form", row["Organizational_form"]);
                            cmd.Parameters.AddWithValue("INN", row["INN"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("KPP", row["KPP"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("OGRN", row["OGRN"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Supplier_addres", row["Supplier_addres"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Date_of_reg", row["Date_of_reg"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("SMSP_attribute", row["SMSP_attribute"]);
                            cmd.Parameters.AddWithValue("Date_of_SMSP", row["Date_of_SMSP"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Date_of_information", row["Date_of_information"] ?? DBNull.Value);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (row.RowState == DataRowState.Added)
                    {
                        // === Добавление новой записи ===
                        using (var cmd = new NpgsqlCommand(
                            @"INSERT INTO Suppliers (
                        Supplier_full_name,
                        Supplier_short_name,
                        Organizational_form,
                        INN,
                        KPP,
                        OGRN,
                        Supplier_addres,
                        Date_of_reg,
                        SMSP_attribute,
                        Date_of_SMSP,
                        Date_of_information
                    ) VALUES (
                        @Supplier_full_name,
                        @Supplier_short_name,
                        @Organizational_form,
                        @INN,
                        @KPP,
                        @OGRN,
                        @Supplier_addres,
                        @Date_of_reg,
                        @SMSP_attribute,
                        @Date_of_SMSP,
                        @Date_of_information
                    )
                    RETURNING ID;", db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("Supplier_full_name", row["Supplier_full_name"]);
                            cmd.Parameters.AddWithValue("Supplier_short_name", row["Supplier_short_name"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Organizational_form", row["Organizational_form"]);
                            cmd.Parameters.AddWithValue("INN", row["INN"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("KPP", row["KPP"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("OGRN", row["OGRN"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Supplier_addres", row["Supplier_addres"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Date_of_reg", row["Date_of_reg"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("SMSP_attribute", row["SMSP_attribute"]);
                            cmd.Parameters.AddWithValue("Date_of_SMSP", row["Date_of_SMSP"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Date_of_information", row["Date_of_information"] ?? DBNull.Value);

                            // Получаем новый ID из базы
                            object result = cmd.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out int newId))
                            {
                                row["ID"] = newId; // Устанавливаем ID для новой строки
                            }
                        }
                    }
                }

                suppliersTable.AcceptChanges(); // Сбрасываем состояние изменений

                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
            finally
            {
                db.closeConnnection();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveSuppliersData();
        }
       
    }
}
