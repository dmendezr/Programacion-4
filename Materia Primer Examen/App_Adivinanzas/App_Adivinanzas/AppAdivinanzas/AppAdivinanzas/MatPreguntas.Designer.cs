namespace AppAdivinanzas
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
            this.BtnGuardaPregunta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPregunta = new System.Windows.Forms.TextBox();
            this.LstListaRespuestas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRespuesta = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.ChkCorrecta = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnGuardaPregunta
            // 
            this.BtnGuardaPregunta.Location = new System.Drawing.Point(121, 244);
            this.BtnGuardaPregunta.Name = "BtnGuardaPregunta";
            this.BtnGuardaPregunta.Size = new System.Drawing.Size(406, 23);
            this.BtnGuardaPregunta.TabIndex = 0;
            this.BtnGuardaPregunta.Text = "Guardar pregunta";
            this.BtnGuardaPregunta.UseVisualStyleBackColor = true;
            this.BtnGuardaPregunta.Click += new System.EventHandler(this.BtnGuardaPregunta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregunta";
            // 
            // TxtPregunta
            // 
            this.TxtPregunta.Location = new System.Drawing.Point(121, 30);
            this.TxtPregunta.Name = "TxtPregunta";
            this.TxtPregunta.Size = new System.Drawing.Size(406, 20);
            this.TxtPregunta.TabIndex = 2;
            // 
            // LstListaRespuestas
            // 
            this.LstListaRespuestas.FormattingEnabled = true;
            this.LstListaRespuestas.Location = new System.Drawing.Point(121, 119);
            this.LstListaRespuestas.Name = "LstListaRespuestas";
            this.LstListaRespuestas.Size = new System.Drawing.Size(406, 95);
            this.LstListaRespuestas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Respuesta";
            // 
            // TxtRespuesta
            // 
            this.TxtRespuesta.Location = new System.Drawing.Point(121, 76);
            this.TxtRespuesta.Name = "TxtRespuesta";
            this.TxtRespuesta.Size = new System.Drawing.Size(187, 20);
            this.TxtRespuesta.TabIndex = 6;
            this.TxtRespuesta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(333, 73);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // ChkCorrecta
            // 
            this.ChkCorrecta.AutoSize = true;
            this.ChkCorrecta.Location = new System.Drawing.Point(426, 79);
            this.ChkCorrecta.Name = "ChkCorrecta";
            this.ChkCorrecta.Size = new System.Drawing.Size(66, 17);
            this.ChkCorrecta.TabIndex = 8;
            this.ChkCorrecta.Text = "Correcta";
            this.ChkCorrecta.UseVisualStyleBackColor = true;
            // 
            // MatPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 286);
            this.Controls.Add(this.ChkCorrecta);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtRespuesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LstListaRespuestas);
            this.Controls.Add(this.TxtPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardaPregunta);
            this.Name = "MatPreguntas";
            this.Text = "Mantenimiento de preguntas";
            this.Load += new System.EventHandler(this.MatPreguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardaPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPregunta;
        private System.Windows.Forms.ListBox LstListaRespuestas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRespuesta;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.CheckBox ChkCorrecta;
    }
}