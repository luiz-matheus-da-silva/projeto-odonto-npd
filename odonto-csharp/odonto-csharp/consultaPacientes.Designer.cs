namespace odonto_csharp
{
    partial class frmConsultaPacientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPacientes));
            this.gridTabelaPacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaSintoma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTabelaPacientes
            // 
            this.gridTabelaPacientes.AllowUserToAddRows = false;
            this.gridTabelaPacientes.AllowUserToDeleteRows = false;
            this.gridTabelaPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTabelaPacientes.BackgroundColor = System.Drawing.Color.White;
            this.gridTabelaPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTabelaPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridTabelaPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(91)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTabelaPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTabelaPacientes.ColumnHeadersHeight = 50;
            this.gridTabelaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNome,
            this.ColunaTelefone,
            this.colunaIdade,
            this.colunaData,
            this.colunaSintoma});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTabelaPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTabelaPacientes.EnableHeadersVisualStyles = false;
            this.gridTabelaPacientes.GridColor = System.Drawing.SystemColors.Control;
            this.gridTabelaPacientes.Location = new System.Drawing.Point(0, 75);
            this.gridTabelaPacientes.Name = "gridTabelaPacientes";
            this.gridTabelaPacientes.ReadOnly = true;
            this.gridTabelaPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTabelaPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTabelaPacientes.RowHeadersVisible = false;
            this.gridTabelaPacientes.RowHeadersWidth = 50;
            this.gridTabelaPacientes.RowTemplate.DividerHeight = 1;
            this.gridTabelaPacientes.RowTemplate.Height = 30;
            this.gridTabelaPacientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTabelaPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTabelaPacientes.Size = new System.Drawing.Size(1050, 643);
            this.gridTabelaPacientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(354, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de pacientes ";
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome Completo";
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            this.colunaNome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColunaTelefone
            // 
            this.ColunaTelefone.HeaderText = "Telefone";
            this.ColunaTelefone.Name = "ColunaTelefone";
            this.ColunaTelefone.ReadOnly = true;
            this.ColunaTelefone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colunaIdade
            // 
            this.colunaIdade.HeaderText = "Idade";
            this.colunaIdade.Name = "colunaIdade";
            this.colunaIdade.ReadOnly = true;
            this.colunaIdade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colunaData
            // 
            this.colunaData.HeaderText = "Data do Agentamento";
            this.colunaData.Name = "colunaData";
            this.colunaData.ReadOnly = true;
            this.colunaData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colunaSintoma
            // 
            this.colunaSintoma.HeaderText = "Sintoma";
            this.colunaSintoma.Name = "colunaSintoma";
            this.colunaSintoma.ReadOnly = true;
            this.colunaSintoma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmConsultaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1050, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTabelaPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Shown += new System.EventHandler(this.frmConsultaPacientes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTabelaPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaSintoma;
    }
}