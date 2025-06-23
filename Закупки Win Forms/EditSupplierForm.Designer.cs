using System.Windows.Forms;

namespace Закупки_Win_Forms
{
    partial class EditSupplierForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSave;
        private TextBox txtInn;
        private TextBox txtShortName;
        private TextBox txtFullName;
        private TextBox txtOrgForm;
        private TextBox txtCountry;
        private TextBox txtKpp;
        private TextBox txtAddress;
        private TextBox txtOgrn;
        private TextBox txtDateReg;
        private TextBox txtSmsrAttr;
        private TextBox txtRusprofileId;
        private TextBox txtCeoName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInn = new System.Windows.Forms.TextBox();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtOrgForm = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtKpp = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtOgrn = new System.Windows.Forms.TextBox();
            this.txtDateReg = new System.Windows.Forms.TextBox();
            this.txtSmsrAttr = new System.Windows.Forms.TextBox();
            this.txtRusprofileId = new System.Windows.Forms.TextBox();
            this.txtCeoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(610, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // txtInn
            //
            this.txtInn.Location = new System.Drawing.Point(150, 15);
            this.txtInn.Name = "txtInn";
            this.txtInn.Size = new System.Drawing.Size(250, 23);
            this.txtInn.TabIndex = 1;
            //
            // txtShortName
            //
            this.txtShortName.Location = new System.Drawing.Point(150, 45);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(250, 23);
            this.txtShortName.TabIndex = 2;
            //
            // txtFullName
            //
            this.txtFullName.Location = new System.Drawing.Point(150, 75);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 23);
            this.txtFullName.TabIndex = 3;
            //
            // txtOrgForm
            //
            this.txtOrgForm.Location = new System.Drawing.Point(150, 105);
            this.txtOrgForm.Name = "txtOrgForm";
            this.txtOrgForm.Size = new System.Drawing.Size(250, 23);
            this.txtOrgForm.TabIndex = 4;
            //
            // txtCountry
            //
            this.txtCountry.Location = new System.Drawing.Point(150, 135);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(250, 23);
            this.txtCountry.TabIndex = 5;
            //
            // txtKpp
            //
            this.txtKpp.Location = new System.Drawing.Point(150, 165);
            this.txtKpp.Name = "txtKpp";
            this.txtKpp.Size = new System.Drawing.Size(250, 23);
            this.txtKpp.TabIndex = 6;
            //
            // txtAddress
            //
            this.txtAddress.Location = new System.Drawing.Point(150, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 23);
            this.txtAddress.TabIndex = 7;
            //
            // txtOgrn
            //
            this.txtOgrn.Location = new System.Drawing.Point(150, 225);
            this.txtOgrn.Name = "txtOgrn";
            this.txtOgrn.Size = new System.Drawing.Size(250, 23);
            this.txtOgrn.TabIndex = 8;
            //
            // txtDateReg
            //
            this.txtDateReg.Location = new System.Drawing.Point(150, 255);
            this.txtDateReg.Name = "txtDateReg";
            this.txtDateReg.Size = new System.Drawing.Size(250, 23);
            this.txtDateReg.TabIndex = 9;
            //
            // txtSmsrAttr
            //
            this.txtSmsrAttr.Location = new System.Drawing.Point(560, 15);
            this.txtSmsrAttr.Name = "txtSmsrAttr";
            this.txtSmsrAttr.Size = new System.Drawing.Size(250, 23);
            this.txtSmsrAttr.TabIndex = 10;
            //
            // txtRusprofileId
            //
            this.txtRusprofileId.Location = new System.Drawing.Point(560, 45);
            this.txtRusprofileId.Name = "txtRusprofileId";
            this.txtRusprofileId.Size = new System.Drawing.Size(250, 23);
            this.txtRusprofileId.TabIndex = 11;
            //
            // txtCeoName
            //
            this.txtCeoName.Location = new System.Drawing.Point(560, 75);
            this.txtCeoName.Name = "txtCeoName";
            this.txtCeoName.Size = new System.Drawing.Size(250, 23);
            this.txtCeoName.TabIndex = 12;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "ИНН:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Краткое название:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Полное название:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Организационная форма:";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Страна:";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "КПП:";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Адрес:";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "ОГРН:";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Дата регистрации:";
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Атрибут СМСП:";
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "ID Rusprofile:";
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(430, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Ген. директор:";
            //
            // EditSupplierForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCeoName);
            this.Controls.Add(this.txtRusprofileId);
            this.Controls.Add(this.txtSmsrAttr);
            this.Controls.Add(this.txtDateReg);
            this.Controls.Add(this.txtOgrn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtKpp);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtOrgForm);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.txtInn);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/Редактирование поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}