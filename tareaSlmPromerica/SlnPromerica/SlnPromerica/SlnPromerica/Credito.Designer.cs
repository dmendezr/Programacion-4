namespace SlnPromerica
{
    partial class Credito
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
            this.dgvCredito = new System.Windows.Forms.DataGridView();
            this.btnTotalCreditos = new System.Windows.Forms.Button();
            this.btnFechForma = new System.Windows.Forms.Button();
            this.btnMayorPlazo = new System.Windows.Forms.Button();
            this.btnMayorOpera = new System.Windows.Forms.Button();
            this.btnPromSaldCred = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dtpFechaForma = new System.Windows.Forms.DateTimePicker();
            this.dtpFechVenci = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFechas = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCredito
            // 
            this.dgvCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredito.Location = new System.Drawing.Point(12, 75);
            this.dgvCredito.Name = "dgvCredito";
            this.dgvCredito.Size = new System.Drawing.Size(766, 81);
            this.dgvCredito.TabIndex = 0;
            // 
            // btnTotalCreditos
            // 
            this.btnTotalCreditos.Location = new System.Drawing.Point(20, 197);
            this.btnTotalCreditos.Name = "btnTotalCreditos";
            this.btnTotalCreditos.Size = new System.Drawing.Size(126, 39);
            this.btnTotalCreditos.TabIndex = 1;
            this.btnTotalCreditos.Text = "Total de Creditos";
            this.btnTotalCreditos.UseVisualStyleBackColor = true;
            this.btnTotalCreditos.Click += new System.EventHandler(this.btnTotalCreditos_Click);
            // 
            // btnFechForma
            // 
            this.btnFechForma.Location = new System.Drawing.Point(166, 197);
            this.btnFechForma.Name = "btnFechForma";
            this.btnFechForma.Size = new System.Drawing.Size(126, 39);
            this.btnFechForma.TabIndex = 4;
            this.btnFechForma.Text = "Fecha de Formalizacion";
            this.btnFechForma.UseVisualStyleBackColor = true;
            this.btnFechForma.Click += new System.EventHandler(this.btnFechForma_Click);
            // 
            // btnMayorPlazo
            // 
            this.btnMayorPlazo.Location = new System.Drawing.Point(325, 197);
            this.btnMayorPlazo.Name = "btnMayorPlazo";
            this.btnMayorPlazo.Size = new System.Drawing.Size(126, 39);
            this.btnMayorPlazo.TabIndex = 5;
            this.btnMayorPlazo.Text = "Operacion con mayor plazo";
            this.btnMayorPlazo.UseVisualStyleBackColor = true;
            this.btnMayorPlazo.Click += new System.EventHandler(this.btnMayorPlazo_Click);
            // 
            // btnMayorOpera
            // 
            this.btnMayorOpera.Location = new System.Drawing.Point(472, 197);
            this.btnMayorOpera.Name = "btnMayorOpera";
            this.btnMayorOpera.Size = new System.Drawing.Size(126, 39);
            this.btnMayorOpera.TabIndex = 6;
            this.btnMayorOpera.Text = "Conteo de Operaciones";
            this.btnMayorOpera.UseVisualStyleBackColor = true;
            this.btnMayorOpera.Click += new System.EventHandler(this.btnMayorOpera_Click);
            // 
            // btnPromSaldCred
            // 
            this.btnPromSaldCred.Location = new System.Drawing.Point(616, 197);
            this.btnPromSaldCred.Name = "btnPromSaldCred";
            this.btnPromSaldCred.Size = new System.Drawing.Size(126, 39);
            this.btnPromSaldCred.TabIndex = 7;
            this.btnPromSaldCred.Text = "Promedio de Saldos de Credito";
            this.btnPromSaldCred.UseVisualStyleBackColor = true;
            this.btnPromSaldCred.Click += new System.EventHandler(this.btnPromSaldCred_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id de Cliente";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(96, 20);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(196, 20);
            this.txtFiltro.TabIndex = 9;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            // 
            // dtpFechaForma
            // 
            this.dtpFechaForma.Location = new System.Drawing.Point(31, 317);
            this.dtpFechaForma.Name = "dtpFechaForma";
            this.dtpFechaForma.Size = new System.Drawing.Size(207, 20);
            this.dtpFechaForma.TabIndex = 10;
            // 
            // dtpFechVenci
            // 
            this.dtpFechVenci.Location = new System.Drawing.Point(283, 317);
            this.dtpFechVenci.Name = "dtpFechVenci";
            this.dtpFechVenci.Size = new System.Drawing.Size(207, 20);
            this.dtpFechVenci.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha Formalizacion";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha Vencimiento";
            // 
            // dgvFechas
            // 
            this.dgvFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechas.Location = new System.Drawing.Point(31, 383);
            this.dgvFechas.Name = "dgvFechas";
            this.dgvFechas.Size = new System.Drawing.Size(747, 115);
            this.dgvFechas.TabIndex = 14;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(519, 331);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(172, 36);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 510);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvFechas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechVenci);
            this.Controls.Add(this.dtpFechaForma);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPromSaldCred);
            this.Controls.Add(this.btnMayorOpera);
            this.Controls.Add(this.btnMayorPlazo);
            this.Controls.Add(this.btnFechForma);
            this.Controls.Add(this.btnTotalCreditos);
            this.Controls.Add(this.dgvCredito);
            this.Name = "Credito";
            this.Text = "Credito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Credito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCredito;
        private System.Windows.Forms.Button btnTotalCreditos;
        private System.Windows.Forms.Button btnFechForma;
        private System.Windows.Forms.Button btnMayorPlazo;
        private System.Windows.Forms.Button btnMayorOpera;
        private System.Windows.Forms.Button btnPromSaldCred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaForma;
        private System.Windows.Forms.DateTimePicker dtpFechVenci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFechas;
        private System.Windows.Forms.Button btnConsultar;
    }
}