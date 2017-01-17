namespace AppAdivinanza
{
    partial class MatPreguntas
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lBRespuestas = new System.Windows.Forms.ListBox();
            this.btnCargaPregunta = new System.Windows.Forms.Button();
            this.chkCorrecta = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pregunta";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(155, 49);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(374, 20);
            this.txtPregunta.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(165, 92);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(274, 20);
            this.txtRespuesta.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(467, 89);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lBRespuestas
            // 
            this.lBRespuestas.FormattingEnabled = true;
            this.lBRespuestas.Location = new System.Drawing.Point(71, 144);
            this.lBRespuestas.Name = "lBRespuestas";
            this.lBRespuestas.Size = new System.Drawing.Size(496, 186);
            this.lBRespuestas.TabIndex = 5;
            // 
            // btnCargaPregunta
            // 
            this.btnCargaPregunta.Location = new System.Drawing.Point(80, 369);
            this.btnCargaPregunta.Name = "btnCargaPregunta";
            this.btnCargaPregunta.Size = new System.Drawing.Size(478, 23);
            this.btnCargaPregunta.TabIndex = 6;
            this.btnCargaPregunta.Text = "Cargar Pregunta";
            this.btnCargaPregunta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCargaPregunta.UseVisualStyleBackColor = true;
            this.btnCargaPregunta.Click += new System.EventHandler(this.btnCargaPregunta_Click);
            // 
            // chkCorrecta
            // 
            this.chkCorrecta.AutoSize = true;
            this.chkCorrecta.Location = new System.Drawing.Point(566, 89);
            this.chkCorrecta.Name = "chkCorrecta";
            this.chkCorrecta.Size = new System.Drawing.Size(80, 17);
            this.chkCorrecta.TabIndex = 7;
            this.chkCorrecta.Text = "checkBox2";
            this.chkCorrecta.UseVisualStyleBackColor = true;
            // 
            // MatPreguntas
            // 
            this.ClientSize = new System.Drawing.Size(675, 451);
            this.Controls.Add(this.chkCorrecta);
            this.Controls.Add(this.btnCargaPregunta);
            this.Controls.Add(this.lBRespuestas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.label3);
            this.Name = "MatPreguntas";
            this.Text = "te";
            this.Load += new System.EventHandler(this.MatPreguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lBRespuestas;
        private System.Windows.Forms.Button btnCargaPregunta;
        private System.Windows.Forms.CheckBox chkCorrecta;
    }
}