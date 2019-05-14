namespace WindowsFormsApp1
{
    partial class Montecarlo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Montecarlo));
            this.btn_generar = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_NoRecuerda_y_NoCompra = new System.Windows.Forms.MaskedTextBox();
            this.txt_NoRecuerda_y_Duda = new System.Windows.Forms.MaskedTextBox();
            this.txt_NoRecuerda_y_Compra = new System.Windows.Forms.MaskedTextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_recuerda_y_compra = new System.Windows.Forms.MaskedTextBox();
            this.txt_recuerda_y_duda = new System.Windows.Forms.MaskedTextBox();
            this.txt_recuerda_no_compra = new System.Windows.Forms.MaskedTextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_no_recuerda = new System.Windows.Forms.MaskedTextBox();
            this.txt_recuerda = new System.Windows.Forms.MaskedTextBox();
            this.txt_hasta = new System.Windows.Forms.MaskedTextBox();
            this.txt_desde = new System.Windows.Forms.MaskedTextBox();
            this.txt_tamaño_muestra = new System.Windows.Forms.MaskedTextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.bnt_limpiar = new System.Windows.Forms.Button();
            this.dgv_simulacion = new System.Windows.Forms.DataGridView();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.lbl_cantidad_total_exitos = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.Transparent;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.ForeColor = System.Drawing.Color.Black;
            this.btn_generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar.Image")));
            this.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar.Location = new System.Drawing.Point(66, 655);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(181, 66);
            this.btn_generar.TabIndex = 9;
            this.btn_generar.Text = "Generar";
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txt_NoRecuerda_y_NoCompra);
            this.GroupBox3.Controls.Add(this.txt_NoRecuerda_y_Duda);
            this.GroupBox3.Controls.Add(this.txt_NoRecuerda_y_Compra);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.GroupBox3.Location = new System.Drawing.Point(1120, 27);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(491, 211);
            this.GroupBox3.TabIndex = 7;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "No podía recordar el mensaje";
            // 
            // txt_NoRecuerda_y_NoCompra
            // 
            this.txt_NoRecuerda_y_NoCompra.Location = new System.Drawing.Point(195, 36);
            this.txt_NoRecuerda_y_NoCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NoRecuerda_y_NoCompra.Name = "txt_NoRecuerda_y_NoCompra";
            this.txt_NoRecuerda_y_NoCompra.Size = new System.Drawing.Size(132, 27);
            this.txt_NoRecuerda_y_NoCompra.TabIndex = 0;
            // 
            // txt_NoRecuerda_y_Duda
            // 
            this.txt_NoRecuerda_y_Duda.Location = new System.Drawing.Point(195, 80);
            this.txt_NoRecuerda_y_Duda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NoRecuerda_y_Duda.Name = "txt_NoRecuerda_y_Duda";
            this.txt_NoRecuerda_y_Duda.Size = new System.Drawing.Size(132, 27);
            this.txt_NoRecuerda_y_Duda.TabIndex = 1;
            // 
            // txt_NoRecuerda_y_Compra
            // 
            this.txt_NoRecuerda_y_Compra.Location = new System.Drawing.Point(195, 117);
            this.txt_NoRecuerda_y_Compra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NoRecuerda_y_Compra.Name = "txt_NoRecuerda_y_Compra";
            this.txt_NoRecuerda_y_Compra.Size = new System.Drawing.Size(132, 27);
            this.txt_NoRecuerda_y_Compra.TabIndex = 2;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(8, 126);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(167, 20);
            this.Label11.TabIndex = 0;
            this.Label11.Text = "Definitivamente sí:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(3, 39);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(172, 20);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Definitivamente no:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(8, 84);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(79, 20);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Dudoso:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txt_recuerda_y_compra);
            this.GroupBox2.Controls.Add(this.txt_recuerda_y_duda);
            this.GroupBox2.Controls.Add(this.txt_recuerda_no_compra);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.GroupBox2.Location = new System.Drawing.Point(555, 27);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(514, 213);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Podía recordar el mensaje";
            // 
            // txt_recuerda_y_compra
            // 
            this.txt_recuerda_y_compra.Location = new System.Drawing.Point(297, 117);
            this.txt_recuerda_y_compra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_recuerda_y_compra.Name = "txt_recuerda_y_compra";
            this.txt_recuerda_y_compra.Size = new System.Drawing.Size(132, 27);
            this.txt_recuerda_y_compra.TabIndex = 2;
            // 
            // txt_recuerda_y_duda
            // 
            this.txt_recuerda_y_duda.Location = new System.Drawing.Point(297, 75);
            this.txt_recuerda_y_duda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_recuerda_y_duda.Name = "txt_recuerda_y_duda";
            this.txt_recuerda_y_duda.Size = new System.Drawing.Size(132, 27);
            this.txt_recuerda_y_duda.TabIndex = 1;
            // 
            // txt_recuerda_no_compra
            // 
            this.txt_recuerda_no_compra.Location = new System.Drawing.Point(297, 31);
            this.txt_recuerda_no_compra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_recuerda_no_compra.Name = "txt_recuerda_no_compra";
            this.txt_recuerda_no_compra.Size = new System.Drawing.Size(132, 27);
            this.txt_recuerda_no_compra.TabIndex = 0;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(8, 126);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(167, 20);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Definitivamente sí:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(8, 84);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(79, 20);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Dudoso:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(8, 39);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(172, 20);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Definitivamente no:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txt_no_recuerda);
            this.GroupBox1.Controls.Add(this.txt_recuerda);
            this.GroupBox1.Controls.Add(this.txt_hasta);
            this.GroupBox1.Controls.Add(this.txt_desde);
            this.GroupBox1.Controls.Add(this.txt_tamaño_muestra);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.GroupBox1.Location = new System.Drawing.Point(17, 13);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(512, 225);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Parámetros:";
            // 
            // txt_no_recuerda
            // 
            this.txt_no_recuerda.Location = new System.Drawing.Point(372, 183);
            this.txt_no_recuerda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_no_recuerda.Name = "txt_no_recuerda";
            this.txt_no_recuerda.Size = new System.Drawing.Size(132, 27);
            this.txt_no_recuerda.TabIndex = 4;
            // 
            // txt_recuerda
            // 
            this.txt_recuerda.Location = new System.Drawing.Point(372, 148);
            this.txt_recuerda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_recuerda.Name = "txt_recuerda";
            this.txt_recuerda.Size = new System.Drawing.Size(132, 27);
            this.txt_recuerda.TabIndex = 3;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(372, 109);
            this.txt_hasta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(132, 27);
            this.txt_hasta.TabIndex = 2;
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(372, 63);
            this.txt_desde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(132, 27);
            this.txt_desde.TabIndex = 1;
            // 
            // txt_tamaño_muestra
            // 
            this.txt_tamaño_muestra.Location = new System.Drawing.Point(372, 28);
            this.txt_tamaño_muestra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tamaño_muestra.Name = "txt_tamaño_muestra";
            this.txt_tamaño_muestra.Size = new System.Drawing.Size(132, 27);
            this.txt_tamaño_muestra.TabIndex = 0;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = System.Drawing.Color.Black;
            this.Label12.Location = new System.Drawing.Point(8, 182);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(315, 20);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "El individuo no recuerda el mensaje:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(8, 152);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(289, 20);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "El individuo recuerda el mensaje:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(8, 116);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 20);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Hasta:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(8, 73);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 20);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Desde:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(8, 37);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(154, 20);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "N(experimentos):";
            // 
            // bnt_limpiar
            // 
            this.bnt_limpiar.BackColor = System.Drawing.Color.Transparent;
            this.bnt_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_limpiar.ForeColor = System.Drawing.Color.Black;
            this.bnt_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("bnt_limpiar.Image")));
            this.bnt_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnt_limpiar.Location = new System.Drawing.Point(300, 655);
            this.bnt_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_limpiar.Name = "bnt_limpiar";
            this.bnt_limpiar.Size = new System.Drawing.Size(187, 66);
            this.bnt_limpiar.TabIndex = 10;
            this.bnt_limpiar.Text = "Limpiar";
            this.bnt_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_limpiar.UseVisualStyleBackColor = false;
            this.bnt_limpiar.Click += new System.EventHandler(this.bnt_limpiar_Click);
            // 
            // dgv_simulacion
            // 
            this.dgv_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_simulacion.Location = new System.Drawing.Point(29, 263);
            this.dgv_simulacion.Name = "dgv_simulacion";
            this.dgv_simulacion.RowTemplate.Height = 24;
            this.dgv_simulacion.Size = new System.Drawing.Size(1262, 258);
            this.dgv_simulacion.TabIndex = 11;
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultados.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_resultados.Location = new System.Drawing.Point(63, 582);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(766, 38);
            this.lbl_resultados.TabIndex = 13;
            this.lbl_resultados.Text = "Resultados de la simulación";
            this.lbl_resultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cantidad_total_exitos
            // 
            this.lbl_cantidad_total_exitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_total_exitos.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_cantidad_total_exitos.Location = new System.Drawing.Point(63, 544);
            this.lbl_cantidad_total_exitos.Name = "lbl_cantidad_total_exitos";
            this.lbl_cantidad_total_exitos.Size = new System.Drawing.Size(766, 38);
            this.lbl_cantidad_total_exitos.TabIndex = 14;
            this.lbl_cantidad_total_exitos.Text = "Cantidad total de exitos :";
            this.lbl_cantidad_total_exitos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1699, 773);
            this.Controls.Add(this.lbl_cantidad_total_exitos);
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.dgv_simulacion);
            this.Controls.Add(this.bnt_limpiar);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Montecarlo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btn_generar;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.MaskedTextBox txt_NoRecuerda_y_NoCompra;
        internal System.Windows.Forms.MaskedTextBox txt_NoRecuerda_y_Duda;
        internal System.Windows.Forms.MaskedTextBox txt_NoRecuerda_y_Compra;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.MaskedTextBox txt_recuerda_y_compra;
        internal System.Windows.Forms.MaskedTextBox txt_recuerda_y_duda;
        internal System.Windows.Forms.MaskedTextBox txt_recuerda_no_compra;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.MaskedTextBox txt_no_recuerda;
        internal System.Windows.Forms.MaskedTextBox txt_recuerda;
        internal System.Windows.Forms.MaskedTextBox txt_hasta;
        internal System.Windows.Forms.MaskedTextBox txt_desde;
        internal System.Windows.Forms.MaskedTextBox txt_tamaño_muestra;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button bnt_limpiar;
        private System.Windows.Forms.DataGridView dgv_simulacion;
        private System.Windows.Forms.Label lbl_resultados;
        private System.Windows.Forms.Label lbl_cantidad_total_exitos;
    }
}

