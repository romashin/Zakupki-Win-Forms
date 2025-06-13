namespace Закупки_Win_Forms
{
    partial class ContractWriteableForm
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
            dataGridViewContracts = new System.Windows.Forms.DataGridView();
            buttonSaveChanges = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContracts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewContracts
            // 
            dataGridViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContracts.Location = new System.Drawing.Point(9, 8);
            dataGridViewContracts.Name = "dataGridViewContracts";
            dataGridViewContracts.Size = new System.Drawing.Size(1253, 766);
            dataGridViewContracts.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.Location = new System.Drawing.Point(1328, 317);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new System.Drawing.Size(75, 44);
            buttonSaveChanges.TabIndex = 1;
            buttonSaveChanges.Text = "Сохранить данные";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new System.Drawing.Point(1328, 384);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(75, 43);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Обновить данные";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ContractWriteableForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1443, 786);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSaveChanges);
            Controls.Add(dataGridViewContracts);
            Name = "ContractWriteableForm";
            Text = "ContractWriteableForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewContracts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContracts;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}