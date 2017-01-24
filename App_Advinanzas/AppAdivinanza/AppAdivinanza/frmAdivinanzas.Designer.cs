namespace AppAdivinanza
{
    partial class frmAdivinanzas
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
            this.txtPreguntas = new System.Windows.Forms.TextBox();
            this.dgRespuestas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRespuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPreguntas
            // 
            this.txtPreguntas.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreguntas.Location = new System.Drawing.Point(12, 43);
            this.txtPreguntas.Name = "txtPreguntas";
            this.txtPreguntas.Size = new System.Drawing.Size(697, 36);
            this.txtPreguntas.TabIndex = 1;
            // 
            // dgRespuestas
            // 
            this.dgRespuestas.AllowUserToAddRows = false;
            this.dgRespuestas.AllowUserToDeleteRows = false;
            this.dgRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgRespuestas.Location = new System.Drawing.Point(51, 108);
            this.dgRespuestas.Name = "dgRespuestas";
            this.dgRespuestas.Size = new System.Drawing.Size(608, 150);
            this.dgRespuestas.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::AppAdivinanza.Properties.Resources.Pregunta;
            this.button1.Location = new System.Drawing.Point(310, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 39);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "atrIdRespuesta";
            this.Column1.HeaderText = "idRespuesta";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "atrRespuesta";
            this.Column2.HeaderText = "Respuesta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "atrCorrecto";
            this.Column3.HeaderText = "Correcto";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // frmAdivinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 387);
            this.Controls.Add(this.dgRespuestas);
            this.Controls.Add(this.txtPreguntas);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdivinanzas";
            this.Text = "Juego de Adivinanzas";
            this.Load += new System.EventHandler(this.frmAdivinanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRespuestas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPreguntas;
        private System.Windows.Forms.DataGridView dgRespuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}