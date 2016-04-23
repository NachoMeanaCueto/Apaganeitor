using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ApaganeiForm
{
    public partial class FrmPrincipal : Form
    {
        char Tipo;

        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
           
                FrmTiempo mifr = new FrmTiempo(Tipo);

                
                mifr.Show();
                this.Close();
                
            
            
        }

        //Evento cambio de check para saber que formulario mostrar a continuacion
        //establece el atributo Tipo
        private void rbApagar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton mirb = new RadioButton();

            mirb = (RadioButton)sender;

            if (mirb == rbApagar)
            {
                Tipo = Convert.ToChar(rbApagar.Tag);
            }
            else 
            {
                if (mirb == rbReiniciar)
                {
                    Tipo = Convert.ToChar(rbReiniciar.Tag);
                }
                else 
                {
                    Tipo = Convert.ToChar(rbCerrar.Tag);
                }
            }

        }

        private void miFormulario_Load(object sender, EventArgs e)
        {
            rbApagar.Checked = true;
        }

        /*Método para almacenar los perfiles*/
        private void Perfil_Click(object sender, EventArgs e)
        {
            int horas, minus, segun;
            horas = minus = segun = 0;
            char Tipo;
            bool Principal = true;

            ToolStripMenuItem mits = (ToolStripMenuItem)sender;
            FrmApagado mifr;


            if (mits == serieCortaToolStripMenuItem)
            {
                horas = 0;
                minus = 25;
                segun = 0;

            }
            else
            {
                if (mits == serieMediaToolStripMenuItem)
                {
                    horas = 0;
                    minus = 45;
                    segun = 0;
                }
                else
                {
                    if (mits == serieLargaToolStripMenuItem)
                    {
                        horas = 1;
                        minus = 5;
                        segun = 0;
                    }
                    else
                    {
                        if (mits == peliCortaToolStripMenuItem)
                        {
                            horas = 1;
                            minus = 35;
                            segun = 0;

                        }
                        else
                        {
                            if (mits == peliculaLargaToolStripMenuItem)
                            {
                                horas = 2;
                                minus = 30;
                                segun = 0;
                            }
                        }
                    }
                }
            }
            //los perfiles estan pensados para apagar el ordenador
            Tipo = 'a';
            mifr = new FrmApagado(horas, minus, segun, Tipo, Principal);
            
            mifr.Show();
            this.Close();
                
        }

        //al clicar el ayuda llama al frmAyuda y oculta este formulario
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmayuda mifr = new Frmayuda();
            this.Hide();
            mifr.ShowDialog();
            this.Visible = true;
        }

       
    }
}
