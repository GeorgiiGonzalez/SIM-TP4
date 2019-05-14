using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Montecarlo : Form
    {
        public Montecarlo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Valores por defecto
            txt_recuerda.Text = "0,40";
            txt_no_recuerda.Text = "0,60";
            //Si recuerda:
            txt_recuerda_no_compra.Text = "0,30";
            txt_recuerda_y_duda.Text = "0,30";
            txt_recuerda_y_compra.Text = "0,40";
            //Si No recuerda:
            txt_NoRecuerda_y_NoCompra.Text= "0,50";
            txt_NoRecuerda_y_Duda.Text = "0,40";
            txt_NoRecuerda_y_Compra.Text= "0,10";
        }

        //Metodo para generar similacion 
        private void generar_simulacion()
        {

            //Tomamos los parametros de entrada
            int cantidad_experimentos = Convert.ToInt32(txt_tamaño_muestra.Text);
            int desde = Convert.ToInt32(txt_desde.Text);
            int hasta = Convert.ToInt32(txt_hasta.Text);



            //Probabilidades
            decimal recuerda_mendaje = Convert.ToDecimal(txt_recuerda.Text);
            decimal NoRecuerda_mendaje = Convert.ToDecimal(txt_no_recuerda.Text) + Convert.ToDecimal(txt_recuerda.Text);
            if (NoRecuerda_mendaje > 1 || NoRecuerda_mendaje < 1)
            {
                MessageBox.Show("La suma de las probabiliades no puede ser mayo o menor a 1", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Si recuerda el mensaje
            decimal recuerda_noCompra = Convert.ToDecimal(txt_recuerda_no_compra.Text);
            decimal recuerda_y_duda = Convert.ToDecimal(txt_recuerda_y_duda.Text) + Convert.ToDecimal(txt_recuerda_no_compra.Text);
            decimal recuerda_y_Compra = Convert.ToDecimal(txt_recuerda_y_compra.Text) + Convert.ToDecimal(txt_recuerda_y_duda.Text) + Convert.ToDecimal(txt_recuerda_no_compra.Text);
            decimal Probabilidad_total = recuerda_y_Compra;

            if (Probabilidad_total > 1 || Probabilidad_total < 1)
            {
                MessageBox.Show("La suma de las probabiliades no puede ser mayor o menor a 1", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //Si No recuerda el mendaje 
            decimal NoRecuerda_NoCompra = Convert.ToDecimal(txt_NoRecuerda_y_NoCompra.Text);
            decimal NoRecuerda_Duda = Convert.ToDecimal(txt_NoRecuerda_y_Duda.Text) + Convert.ToDecimal(txt_NoRecuerda_y_NoCompra.Text);
            decimal NoRecuerda_Compra = Convert.ToDecimal(txt_NoRecuerda_y_Compra.Text) + Convert.ToDecimal(txt_NoRecuerda_y_Duda.Text) + Convert.ToDecimal(txt_NoRecuerda_y_NoCompra.Text);
            decimal prob_total_2 = NoRecuerda_Compra;

            if (prob_total_2 > 1 || prob_total_2 < 1)
            {
                MessageBox.Show("La suma de las probabiliades no puede ser mayo o menor a 1", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // valida el rango
            if (desde >= hasta || hasta > cantidad_experimentos)
            {
                MessageBox.Show("El rango ingresado no es válido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_desde.Text = "";
                txt_hasta.Text = "";
                txt_desde.Focus();
                return;
            }

            //Creamos las columnas de la tabla 
            DataTable dt = new DataTable();
            dt.Columns.Add("Nro. exp.");
            dt.Columns.Add("RND");
            dt.Columns.Add("Recuerda?");
            dt.Columns.Add("RND compra");
            dt.Columns.Add("Compra?");
            dt.Columns.Add("Contador de Exitos");

            //Este es el acumuladora para contar los exitos
            Int64 acu_exitos = 0;
            //Para calcular el promedio
            double promedio_si_compra = 0;

            Random RND = new Random();
            Random RND2 = new Random();


            for (int i = 1; i <= cantidad_experimentos; i++)
            {
                DataRow dr = dt.NewRow();
                // variables
                double RND_recuerda = Math.Round(RND.NextDouble(), 4);
                double RND_compra = Math.Round(RND2.NextDouble(), 4);
                string respuesta = "";
                string respuesta_compra = "";

                if (Convert.ToDecimal(RND_recuerda) < recuerda_mendaje)
                {
                    respuesta = "SI";
                }
                else
                { respuesta = "NO"; }

                //SI recuerda el mendaje:

                if (respuesta == "SI")
                {
                    if (Convert.ToDecimal(RND_compra) < recuerda_y_duda)
                    {
                        if (Convert.ToDecimal(RND_compra) < recuerda_noCompra)

                        {
                            respuesta_compra = "Definitivamente no";

                        }
                        else
                        {
                            respuesta_compra = "Dudoso";
                        }
                    }
                    else
                    {
                        respuesta_compra = "Definitivamente si";
                        acu_exitos += 1;
                    }
                }

                //Si no recuerda el mensaje:
                if (respuesta == "NO")
                {
                    if (Convert.ToDecimal(RND_compra) < NoRecuerda_Duda)
                    {
                        if (Convert.ToDecimal(RND_compra) < recuerda_noCompra)

                        {
                            respuesta_compra = "Definitivamente no";

                        }
                        else
                        {
                            respuesta_compra = "Dudoso";
                        }
                    }
                    else
                    {
                        respuesta_compra = "Definitivamente si";
                        acu_exitos += 1;
                    }
                }
                promedio_si_compra = Convert.ToDouble(acu_exitos) / Convert.ToDouble(i);

                //Agregamos los datos  a la tabla
                dr["Nro. exp."] = i;
                dr["RND"] = RND_recuerda;
                dr["Recuerda?"] = respuesta;
                dr["RND compra"] = RND_compra;
                dr["Compra?"] = respuesta_compra;
                dr["Contador de Exitos"] = acu_exitos;


                // rango a mostrar de la simulacion
                if (i >= desde && i <= hasta)
                {
                    dt.Rows.Add(dr);
                }
            }
            this.dgv_simulacion.DataSource = dt;
            lbl_cantidad_total_exitos.Text = "Cantidad total de Exitos : " + Convert.ToString(acu_exitos);
            lbl_resultados.Text = "Probabilidad general de que un individuo responda Si  : " + Convert.ToString( promedio_si_compra);
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (txt_tamaño_muestra.Text == "" | txt_desde.Text == "" | txt_hasta.Text == "" | txt_recuerda.Text == ""|
                txt_no_recuerda.Text == ""| txt_recuerda_no_compra.Text == "" | txt_recuerda_y_duda.Text=="" | txt_recuerda_y_compra.Text ==""
                | txt_NoRecuerda_y_NoCompra.Text =="" | txt_NoRecuerda_y_Duda.Text == "" | txt_NoRecuerda_y_Compra.Text == "")
            {
                MessageBox.Show("Complete TODOS los campos por favor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.generar_simulacion();
           
        }

        private void bnt_limpiar_Click(object sender, EventArgs e)
        {
            //int desde = Convert.ToInt32(txt_desde.Text);
            //int hasta = Convert.ToInt32(txt_hasta.Text);
            //for (int i = desde; i <= hasta; i++)
            //{
            //    int index = dgv_simulacion.SelectedRows[i].Index;
            //    dgv_simulacion.Rows.RemoveAt(index);
            //}

            txt_tamaño_muestra.Text = "";
            txt_desde.Text = "";
            txt_hasta.Text = "";
            //Valores por defecto
            txt_recuerda.Text = "0,40";
            txt_no_recuerda.Text = "0,60";
            //Si recuerda:
            txt_recuerda_no_compra.Text = "0,30";
            txt_recuerda_y_duda.Text = "0,30";
            txt_recuerda_y_compra.Text = "0,40";
            //Si No recuerda:
            txt_NoRecuerda_y_NoCompra.Text = "0,50";
            txt_NoRecuerda_y_Duda.Text = "0,40";
            txt_NoRecuerda_y_Compra.Text = "0,10";
            lbl_resultados.Text = "";
            lbl_cantidad_total_exitos.Text = "";



        }
        private void validar()
        {
            if (txt_tamaño_muestra.Text == "" | txt_desde.Text == "" | txt_hasta.Text == "" | txt_recuerda.Text == "")
            {
                MessageBox.Show("Complete TODOS los campos por favor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
