namespace Закупки_Win_Forms
{
    partial class PaymentOrdersWritableForm
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
            dataGridViewPayments = new System.Windows.Forms.DataGridView();
            buttonSave = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayments.Location = new System.Drawing.Point(12, 66);
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.Size = new System.Drawing.Size(1159, 562);
            dataGridViewPayments.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(160, 37);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new System.Drawing.Point(797, 37);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(75, 23);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // PaymentOrdersWritableForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1183, 640);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewPayments);
            Name = "PaymentOrdersWritableForm";
            Text = "PaymentOrdersWritableForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefresh;
    }
}