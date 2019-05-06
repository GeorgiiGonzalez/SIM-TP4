namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_generar = new System.Windows.Forms.Button();
            this.dgv_general = new System.Windows.Forms.DataGridView();
            this.num_experimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_exitos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_recuerda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recuerda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_compra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_exitos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.MaskedTextBox12 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.MaskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_no_recordaba = new System.Windows.Forms.MaskedTextBox();
            this.txt_recordaba = new System.Windows.Forms.MaskedTextBox();
            this.txt_hasta = new System.Windows.Forms.MaskedTextBox();
            this.txt_desde = new System.Windows.Forms.MaskedTextBox();
            this.txt_tamaño_muestra = new System.Windows.Forms.MaskedTextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_general)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(801, 255);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(107, 39);
            this.btn_generar.TabIndex = 9;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            // 
            // dgv_general
            // 
            this.dgv_general.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_general.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_experimento,
            this.rnd_compra,
            this.compra1,
            this.cant_exitos1,
            this.rnd_recuerda,
            this.recuerda,
            this.rnd_compra2,
            this.compra2,
            this.cant_exitos2});
            this.dgv_general.Location = new System.Drawing.Point(419, 66);
            this.dgv_general.Name = "dgv_general";
            this.dgv_general.Size = new System.Drawing.Size(832, 171);
            this.dgv_general.TabIndex = 8;
            // 
            // num_experimento
            // 
            this.num_experimento.HeaderText = "N°Exp";
            this.num_experimento.Name = "num_experimento";
            this.num_experimento.Width = 80;
            // 
            // rnd_compra
            // 
            this.rnd_compra.HeaderText = "RND_COMPRA";
            this.rnd_compra.Name = "rnd_compra";
            // 
            // compra1
            // 
            this.compra1.HeaderText = "Compra?";
            this.compra1.Name = "compra1";
            this.compra1.Width = 80;
            // 
            // cant_exitos1
            // 
            this.cant_exitos1.HeaderText = "Cant Exitos";
            this.cant_exitos1.Name = "cant_exitos1";
            this.cant_exitos1.Width = 80;
            // 
            // rnd_recuerda
            // 
            this.rnd_recuerda.HeaderText = "RND_RECUERDA";
            this.rnd_recuerda.Name = "rnd_recuerda";
            // 
            // recuerda
            // 
            this.recuerda.HeaderText = "Recuerda?";
            this.recuerda.Name = "recuerda";
            this.recuerda.Width = 80;
            // 
            // rnd_compra2
            // 
            this.rnd_compra2.HeaderText = "RND_COMPRA";
            this.rnd_compra2.Name = "rnd_compra2";
            // 
            // compra2
            // 
            this.compra2.HeaderText = "Compra?";
            this.compra2.Name = "compra2";
            this.compra2.Width = 80;
            // 
            // cant_exitos2
            // 
            this.cant_exitos2.HeaderText = "CantExitos";
            this.cant_exitos2.Name = "cant_exitos2";
            this.cant_exitos2.Width = 80;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.MaskedTextBox12);
            this.GroupBox3.Controls.Add(this.MaskedTextBox11);
            this.GroupBox3.Controls.Add(this.MaskedTextBox10);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Location = new System.Drawing.Point(419, 255);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(320, 165);
            this.GroupBox3.TabIndex = 7;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "No podía recordar el mensaje";
            // 
            // MaskedTextBox12
            // 
            this.MaskedTextBox12.Location = new System.Drawing.Point(146, 29);
            this.MaskedTextBox12.Name = "MaskedTextBox12";
            this.MaskedTextBox12.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextBox12.TabIndex = 1;
            // 
            // MaskedTextBox11
            // 
            this.MaskedTextBox11.Location = new System.Drawing.Point(146, 65);
            this.MaskedTextBox11.Name = "MaskedTextBox11";
            this.MaskedTextBox11.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextBox11.TabIndex = 1;
            // 
            // MaskedTextBox10
            // 
            this.MaskedTextBox10.Location = new System.Drawing.Point(146, 95);
            this.MaskedTextBox10.Name = "MaskedTextBox10";
            this.MaskedTextBox10.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextBox10.TabIndex = 1;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(6, 102);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(95, 13);
            this.Label11.TabIndex = 0;
            this.Label11.Text = "Definitivamente sí:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(6, 32);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(98, 13);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Definitivamente no:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 68);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(47, 13);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Dudoso:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.MaskedTextBox9);
            this.GroupBox2.Controls.Add(this.MaskedTextBox8);
            this.GroupBox2.Controls.Add(this.MaskedTextBox7);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Location = new System.Drawing.Point(13, 255);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(384, 165);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Podía recordar el mensaje";
            // 
            // MaskedTextBox9
            // 
            this.MaskedTextBox9.Location = new System.Drawing.Point(223, 95);
            this.MaskedTextBox9.Name = "MaskedTextBox9";
            this.MaskedTextBox9.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextBox9.TabIndex = 1;
            // 
            // MaskedTextBox8
            // 
            this.MaskedTextBox8.Location = new System.Drawing.Point(223, 61);
            this.MaskedTextBox8.Name = "MaskedTextBox8";
            this.MaskedTextBox8.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextBox8.TabIndex = 1;
            // 
            // MaskedTextBox7
            // 
            this.MaskedTextBox7.Location = new System.Drawing.Point(223, 25);
            this.MaskedTextBox7.Name = "MaskedTextBox7";
            this.MaskedTextBox7.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextBox7.TabIndex = 1;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 102);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(95, 13);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Definitivamente sí:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(6, 68);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(47, 13);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Dudoso:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 32);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(98, 13);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Definitivamente no:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txt_no_recordaba);
            this.GroupBox1.Controls.Add(this.txt_recordaba);
            this.GroupBox1.Controls.Add(this.txt_hasta);
            this.GroupBox1.Controls.Add(this.txt_desde);
            this.GroupBox1.Controls.Add(this.txt_tamaño_muestra);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(13, 66);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(384, 173);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Parámetros:";
            // 
            // txt_no_recordaba
            // 
            this.txt_no_recordaba.Location = new System.Drawing.Point(233, 141);
            this.txt_no_recordaba.Name = "txt_no_recordaba";
            this.txt_no_recordaba.Size = new System.Drawing.Size(100, 20);
            this.txt_no_recordaba.TabIndex = 1;
            // 
            // txt_recordaba
            // 
            this.txt_recordaba.Location = new System.Drawing.Point(233, 119);
            this.txt_recordaba.Name = "txt_recordaba";
            this.txt_recordaba.Size = new System.Drawing.Size(100, 20);
            this.txt_recordaba.TabIndex = 1;
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(233, 87);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(100, 20);
            this.txt_hasta.TabIndex = 1;
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(233, 52);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(100, 20);
            this.txt_desde.TabIndex = 1;
            // 
            // txt_tamaño_muestra
            // 
            this.txt_tamaño_muestra.Location = new System.Drawing.Point(233, 23);
            this.txt_tamaño_muestra.Name = "txt_tamaño_muestra";
            this.txt_tamaño_muestra.Size = new System.Drawing.Size(100, 20);
            this.txt_tamaño_muestra.TabIndex = 1;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(6, 148);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(205, 13);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "El individuo no podía recordar el mensaje:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 126);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(168, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "El individuo recordaba el mensaje:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 94);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 13);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Hasta:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 59);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Desde:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "N(experimentos):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 487);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.dgv_general);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_general)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btn_generar;
        internal System.Windows.Forms.DataGridView dgv_general;
        internal System.Windows.Forms.DataGridViewTextBoxColumn num_experimento;
        internal System.Windows.Forms.DataGridViewTextBoxColumn rnd_compra;
        internal System.Windows.Forms.DataGridViewTextBoxColumn compra1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn cant_exitos1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn rnd_recuerda;
        internal System.Windows.Forms.DataGridViewTextBoxColumn recuerda;
        internal System.Windows.Forms.DataGridViewTextBoxColumn rnd_compra2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn compra2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn cant_exitos2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.MaskedTextBox MaskedTextBox12;
        internal System.Windows.Forms.MaskedTextBox MaskedTextBox11;
        internal System.Windows.Forms.MaskedTextBox MaskedTextBox10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.MaskedTextBox MaskedTextBox9;
        internal System.Windows.Forms.MaskedTextBox MaskedTextBox8;
        internal System.Windows.Forms.MaskedTextBox MaskedTextBox7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.MaskedTextBox txt_no_recordaba;
        internal System.Windows.Forms.MaskedTextBox txt_recordaba;
        internal System.Windows.Forms.MaskedTextBox txt_hasta;
        internal System.Windows.Forms.MaskedTextBox txt_desde;
        internal System.Windows.Forms.MaskedTextBox txt_tamaño_muestra;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
    }
}

