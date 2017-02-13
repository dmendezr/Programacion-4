namespace AppAdivinanzas
{
    partial class FrmAdivinanzas
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtPregunta = new System.Windows.Forms.TextBox();
            this.dgRespuestas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRespuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::AppAdivinanzas.Properties.Resources.Pregunta;
            this.button1.Location = new System.Drawing.Point(361, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtPregunta
            // 
            this.TxtPregunta.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPregunta.Location = new System.Drawing.Point(26, 47);
            this.TxtPregunta.Name = "TxtPregunta";
            this.TxtPregunta.Size = new System.Drawing.Size(772, 39);
            this.TxtPregunta.TabIndex = 1;
            // 
            // dgRespuestas
            // 
            this.dgRespuestas.AllowUserToAddRows = false;
            this.dgRespuestas.AllowUserToDeleteRows = false;
            this.dgRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgRespuestas.Location = new System.Drawing.Point(26, 112);
            this.dgRespuestas.Name = "dgRespuestas";
            this.dgRespuestas.Size = new System.Drawing.Size(772, 119);
            this.dgRespuestas.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "atrIdRespuesta";
            this.Column1.HeaderText = "IdRespuesta";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "atrRespuesta";
            this.Column2.HeaderText = "Respuesta";
            this.Column2.Name = "Column2";
            // 
            // FrmAdivinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 401);
            this.Controls.Add(this.dgRespuestas);
            this.Controls.Add(this.TxtPregunta);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdivinanzas";
            this.Text = "Juego de adivinanzas";
            this.Load += new System.EventHandler(this.FrmAdivinanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRespuestas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtPregunta;
        private System.Windows.Forms.DataGridView dgRespuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}