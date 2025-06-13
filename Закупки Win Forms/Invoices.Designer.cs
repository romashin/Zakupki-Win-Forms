namespace Закупки_Win_Forms
{
    partial class InvoicesWriteableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            buttonSave = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInvoices
            // 
            dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoices.Location = new System.Drawing.Point(13, 74);
            dataGridViewInvoices.Name = "dataGridViewInvoices";
            dataGridViewInvoices.Size = new System.Drawing.Size(1238, 644);
            dataGridViewInvoices.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(269, 34);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(250, 34);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить изменения";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new System.Drawing.Point(724, 34);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(250, 34);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Обновить данные";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // InvoicesWriteableForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1263, 730);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewInvoices);
            Name = "InvoicesWriteableForm";
            Text = "Закрывающие документы";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefresh;
    }
}