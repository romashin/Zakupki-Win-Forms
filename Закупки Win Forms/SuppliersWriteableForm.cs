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
            try
            {
                suppliersTable = new DataTable();

                db.openConnnection();
                string query = "SELECT * FROM Temp_suppliers";

                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, db.getConnection()))
                {
                    adapter.Fill(suppliersTable);
                }

                dataGridView1.DataSource = suppliersTable;
                dataGridView1.ReadOnly = false;

                /// === Здесь переименовываем заголовки столбцов ===
                foreach (DataGridViewColumn column in dataGridView1.Columns) // не сработало
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
                        //case "Date_of_reg":
                        //    column.HeaderText = "Дата регистрации";
                        //    break;
                        case "SMSP_attribute":
                            column.HeaderText = "Атрибут СМСП";
                            break;
                        case "Date_of_SMSP":
                            column.HeaderText = "Дата СМСП";
                            break;
                        //case "Date_of_information":
                        //    column.HeaderText = "Дата информации";
                        //    break;
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

        private void SaveSuppliersData() // функция сохранить данные
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
                            @"UPDATE Temp_suppliers SET 
                        Organizational_form = @Organizational_form,
                        Supplier_short_name = @Supplier_short_name,
                        Supplier_full_name = @Supplier_full_name,
                        type_of_entity = @type_of_entity,
                        country_of_origin = @country_of_origin,
                        INN = @INN,
                        KPP = @KPP,
                        OGRN = @OGRN,
                        Supplier_addres = @Supplier_addres,
                        Date_of_reg = @Date_of_reg,
                        SMSP_attribute = @SMSP_attribute,
                        rusprofile_id = @rusprofile_id,
                        ceo_name = @ceo_name
                      WHERE ID = @ID", db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("ID", row["ID"]);
                            cmd.Parameters.AddWithValue("Organizational_form", row["Organizational_form"]);
                            cmd.Parameters.AddWithValue("Supplier_short_name", row["Supplier_short_name"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Supplier_full_name", row["Supplier_full_name"]);
                            cmd.Parameters.AddWithValue("type_of_entity", row["type_of_entity"]);
                            cmd.Parameters.AddWithValue("country_of_origin", row["country_of_origin"]);
                            cmd.Parameters.AddWithValue("INN", row["INN"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("KPP", row["KPP"]);
                            cmd.Parameters.AddWithValue("OGRN", row["OGRN"]);
                            cmd.Parameters.AddWithValue("Supplier_addres", row["Supplier_addres"]);
                            cmd.Parameters.AddWithValue("Date_of_reg", row["Date_of_reg"]);
                            cmd.Parameters.AddWithValue("SMSP_attribute", row["SMSP_attribute"]);
                            cmd.Parameters.AddWithValue("rusprofile_id", row["rusprofile_id"]);
                            cmd.Parameters.AddWithValue("ceo_name", row["ceo_name"]);


                            //cmd.Parameters.AddWithValue("Date_of_SMSP", row["Date_of_SMSP"] ?? DBNull.Value);
                            //cmd.Parameters.AddWithValue("Date_of_information", row["Date_of_information"] ?? DBNull.Value);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (row.RowState == DataRowState.Added)
                    {
                        // === Добавление новой записи ===
                        using (var cmd = new NpgsqlCommand(
                            @"INSERT INTO Temp_suppliers (
                        
                        Organizational_form,
                        Supplier_short_name,
                        Supplier_full_name,
                        type_of_entity,
                        country_of_origin,
                        INN,
                        KPP,
                        OGRN,
                        Supplier_addres,
                        Date_of_reg,
                        SMSP_attribute,
                        rusprofile_id,
                        ceo_name 

                        
                        Supplier_full_name,
                        Supplier_short_name,
                        Organizational_form,
                        INN,
                        KPP,
                        OGRN,
                        Supplier_addres,
                        Date_of_reg,
                        SMSP_attribute,
                        //Date_of_SMSP,
                        //Date_of_information
                    ) VALUES (
                        
                        @Organizational_form,
                        @Supplier_short_name,
                        @Supplier_full_name,
                        @type_of_entity,
                        @country_of_origin,
                        @INN,
                        @KPP,
                        @OGRN,
                        @Supplier_addres,
                        @Date_of_reg,
                        @SMSP_attribute,
                        @rusprofile_id,
                        @ceo_name       
                    )
                    RETURNING ID;", db.getConnection()))
                        {
                            cmd.Parameters.AddWithValue("Organizational_form", row["Organizational_form"]);
                            cmd.Parameters.AddWithValue("Supplier_short_name", row["Supplier_short_name"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("Supplier_full_name", row["Supplier_full_name"]);
                            cmd.Parameters.AddWithValue("type_of_entity", row["type_of_entity"]);
                            cmd.Parameters.AddWithValue("country_of_origin", row["country_of_origin"]);
                            cmd.Parameters.AddWithValue("INN", row["INN"] ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("KPP", row["KPP"]);
                            cmd.Parameters.AddWithValue("OGRN", row["OGRN"]);
                            cmd.Parameters.AddWithValue("Supplier_addres", row["Supplier_addres"]);
                            cmd.Parameters.AddWithValue("Date_of_reg", row["Date_of_reg"]);
                            cmd.Parameters.AddWithValue("SMSP_attribute", row["SMSP_attribute"]);
                            cmd.Parameters.AddWithValue("rusprofile_id", row["rusprofile_id"]);
                            cmd.Parameters.AddWithValue("ceo_name", row["ceo_name"]);

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
