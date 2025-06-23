using Npgsql;
using System;
using System.Windows.Forms;

namespace Закупки_Win_Forms
{
    public partial class EditSupplierForm : Form
    {
        private DB db = new DB();
        private int? supplierId = null;

        public EditSupplierForm(int id = -1)
        {
            InitializeComponent();
            supplierId = id == -1 ? (int?)null : id;

            if (supplierId.HasValue)
            {
                LoadSupplierData();
            }
        }

        private void LoadSupplierData()
        {
            using (NpgsqlConnection conn = db.getConnection())
            {
                db.openConnnection();
                string query = "SELECT * FROM temp_suppliers WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", supplierId.Value);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtInn.Text =           reader["inn"]?.ToString();
                            txtShortName.Text =     reader["supplier_short_name"]?.ToString();
                            txtFullName.Text =      reader["supplier_full_name"]?.ToString();
                            txtOrgForm.Text =       reader["organizational_form"]?.ToString();
                            txtCountry.Text =       reader["country_of_origin"]?.ToString();
                            txtKpp.Text =           reader["kpp"]?.ToString();
                            txtAddress.Text =       reader["supplier_addres"]?.ToString();
                            txtOgrn.Text =          reader["ogrn"]?.ToString();
                            txtDateReg.Text =       reader["date_of_reg"]?.ToString();
                            txtSmsrAttr.Text =      reader["smsp_attribute"]?.ToString();
                            txtRusprofileId.Text =  reader["rusprofile_id"]?.ToString();
                            txtCeoName.Text =       reader["ceo_name"]?.ToString();
                        }
                    }
                }
                db.closeConnnection();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInn.Text))
            {
                MessageBox.Show("ИНН обязателен для заполнения.");
                return;
            }

            try
            {
                using (NpgsqlConnection conn = db.getConnection())
                {
                    db.openConnnection();
                    if (!supplierId.HasValue)
                    {
                        // Добавление
                        string insertQuery = @"
                            INSERT INTO temp_suppliers (
                                inn, supplier_short_name, supplier_full_name,
                                organizational_form, country_of_origin, kpp,
                                supplier_addres, ogrn, date_of_reg, smsp_attribute,
                                rusprofile_id, ceo_name
                            ) VALUES (
                                @inn, @shortname, @fullname, @orgform, @country,
                                @kpp, @address, @ogrn, @datereg, @smsp, @rusprofile, @ceo
                            )";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, conn))
                        {
                            
                            AddParameters(cmd);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Обновление
                        string updateQuery = @"
                            UPDATE temp_suppliers SET
                                inn = @inn, 
                                supplier_short_name = @shortname, 
                                supplier_full_name = @fullname,
                                organizational_form = @orgform, 
                                country_of_origin = @country, 
                                kpp = @kpp,
                                supplier_addres = @address, 
                                ogrn = @ogrn, 
                                date_of_reg = @datereg,
                                smsp_attribute = @smsp, 
                                rusprofile_id = @rusprofile, ceo_name = @ceo
                            WHERE id = @id";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, conn))
                        {
                            
                            cmd.Parameters.AddWithValue("@id", supplierId.Value);
                            AddParameters(cmd);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    db.closeConnnection();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void AddParameters(NpgsqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@inn",         txtInn.         Text);
            cmd.Parameters.AddWithValue("@shortname",   txtShortName.   Text ?? "");
            cmd.Parameters.AddWithValue("@fullname",    txtFullName.    Text ?? "");
            cmd.Parameters.AddWithValue("@orgform",     txtOrgForm.     Text ?? "");
            cmd.Parameters.AddWithValue("@country",     txtCountry.     Text ?? "");
            cmd.Parameters.AddWithValue("@kpp",         txtKpp.         Text ?? "");
            cmd.Parameters.AddWithValue("@address",     txtAddress.     Text ?? "");
            cmd.Parameters.AddWithValue("@ogrn",        txtOgrn.        Text ?? "");
            cmd.Parameters.AddWithValue("@datereg",     txtDateReg.     Text ?? "");
            cmd.Parameters.AddWithValue("@smsp",        txtSmsrAttr.    Text ?? "");
            cmd.Parameters.AddWithValue("@rusprofile",  txtRusprofileId.Text ?? "");
            cmd.Parameters.AddWithValue("@ceo",         txtCeoName.     Text ?? "");
        }
    }
}