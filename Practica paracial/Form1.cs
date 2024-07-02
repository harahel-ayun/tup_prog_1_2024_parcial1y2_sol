using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_paracial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int[] VectorRegistro = new int[100];
        double[] VectorNota=new double[100];
        int cantidad = 0;

        private void Ordenar()
        {
            int auxRegistro;
            double auxNota;
            for (int i = 0; i < cantidad; i++)
            {
                for(int j=i+1;j< cantidad; j++)
                {
                    if (VectorNota[j] > VectorNota[j])
                    {
                        auxNota = VectorNota[i];
                        VectorNota[i] = VectorNota[j];
                        VectorNota[j]= auxNota;
                        auxRegistro = VectorRegistro[i];
                        VectorRegistro[i] = VectorRegistro[j];
                        VectorRegistro[j]= auxRegistro;
                    }
                }

            }
        }

        private void btnAgregarCandidato_Click(object sender, EventArgs e)
        {
            Fagregar agregar=new Fagregar();
            if (cantidad < VectorRegistro.Length)
            {
                DialogResult opcion= agregar.ShowDialog();
                if (opcion == DialogResult.OK)
                {
                    VectorNota[cantidad]=Convert.ToInt32(agregar.txtNota.Text);
                    VectorRegistro[cantidad] = Convert.ToInt32(agregar.txtNumero.Text);
                    cantidad++;
                }
            }
        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            if (cantidad == 0)
            {
                MessageBox.Show("Sin datos");
            }
            else
            {
                Ordenar();
                listBoxResumen.Items.Clear();
                for (int i = 0; i < cantidad; i++)
                {
                    listBoxResumen.Items.Add(VectorNota[i] + "-" + VectorRegistro[i] + "-");
                }
            }
           
        }

        private void btnVerPromedio_Click(object sender, EventArgs e)
        {
           if(cantidad == 0)
           {
              MessageBox.Show("sin datos");
           }
           else
           {
                double sumaNotas = 0;
                for (int i = 0;i < cantidad; i++)
                {
                    sumaNotas += VectorNota[i];
                }
                double promedio = sumaNotas / cantidad;
                listBoxResumen.Items.Clear();
                listBoxResumen.Items.Add("Promedio de notas: " + promedio);
                listBoxResumen.Items.Add("Candidatos que superan el promedio:");
                for (int i = 0; i < cantidad; i++)
                {
                    if (VectorNota[i] > promedio)
                    {
                        listBoxResumen.Items.Add(VectorRegistro[i] + " - ");
                    }
                }
            }
        }

        private void btnVerAprobados_Click(object sender, EventArgs e)
        {
            double notaCondicion=Convert.ToDouble(txtNota.Text);
            int m = 0;
            for(int i = 0; i < cantidad; i++)
            {
                
                if (VectorNota[i] >= notaCondicion)
                {
                    listBoxResumen.Items.Add(VectorNota[i] + " - , Numero de registro" + VectorRegistro[i]);
                    m++;
                }
                if (m == 0)
                {
                    listBoxResumen.Items.Add("no aprobaron");
                }
            }

        }

        private int Buscar(int buscado)
        {
            int orden = -1, elementos = 0;
            while(orden==-1 && elementos < cantidad)
            {
                if (VectorRegistro[elementos] == buscado)
                {
                    orden = elementos;
                    elementos++;
                }
            }
            return orden;
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int RegistroBuscar = Convert.ToInt32(txtNro.Text);
            int posicion = Buscar(RegistroBuscar);
            if (posicion != -1)
            {
                Fagregar buscado = new Fagregar();
                buscado.Text = "resultado";
                buscado.txtNumero.Text = VectorRegistro[posicion].ToString();
                buscado.txtNumero.ReadOnly = true;
                buscado.ShowDialog();
            }
            else
            {
                MessageBox.Show("registro no encontrado");
            }
        }
    }
}
