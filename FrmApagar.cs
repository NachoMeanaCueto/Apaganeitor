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
    public partial class FrmTiempo : Form
    {
        FrmPrincipal mifrmPrin;

        //atributo para llamar al siguiente formulario
        private char Tipo;

        //campo para comprobar a que formulario llamar si se pulsa el boton
        //atras del frmApagado
        private bool principal = false;

        //constructor
        public FrmTiempo(char tipo)
        {
            InitializeComponent();
            Tipo = tipo;
        }

        public FrmTiempo(char tipo, int horas, int minutos, int segundos) 
        {
            InitializeComponent();
            Tipo = tipo;

            NudHoras.Value = horas;
            NudMin.Value = minutos;
            NudSeg.Value = segundos;

        }

        //evento que controla el click sobre el boton cancelar
        //cierra este formulario.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mifrmPrin = new FrmPrincipal();
            mifrmPrin.Show();
            this.Close();
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //variables para almacenar los datos de los texbox
            int hor, min, seg;

            FrmApagado miApagado;
            DialogResult midialogo;

            try
            {
              
                hor = (int)NudHoras.Value;
                min = (int)NudMin.Value;
                seg = (int)NudSeg.Value;

                //comprueba si se da el caso que llama al siguiente form con los valores en 0 si es un error o quiere
                //apagar el ordenador así
                if (hor == 0 && min == 0 && seg == 0)
                {
                    midialogo = MessageBox.Show("Si continua el proceso se ejecutará inmediatamente", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (midialogo == DialogResult.OK)
                    {
                        miApagado = new FrmApagado(hor, min, seg, Tipo, principal);

                       
                        miApagado.Show();
                        this.Close();
                    }
                }
                else
                {
                    miApagado = new FrmApagado(hor, min, seg, Tipo, principal);

                 
                    miApagado.Show();
                    this.Close();
                }
                
                        
        
                    
             } 
            catch 
            {

            }
        }

        /*--------------------------------------------------------------------------
         * Evento load del formulario para comprobar que imagen y texto mostrar al cargar el 
         * formulario depende del atributo tipo que se manda en el constructor--
         ---------------------------------------------------------------------------*/
        private void FrmTiempo_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Tipo)
                {
                    case 'a':
                        labTitulo.Text = "Menú de apagado";
                        labtext.Text = "Introduzca el tiempo que desea que pase \nhasta que se apague su ordenador \ny pulse continuar.";
                        pcbIcono.Image = imageList1.Images[0];
                        pintaTexto();
                        break;
                    case 'r':
                        labTitulo.Text = "Menú de reinicio";
                        labtext.Text = "Introduzca el tiempo que desea que pase \nhasta que se reinicie su ordenador \ny pulse continuar.";
                        pcbIcono.Image = imageList1.Images[1];
                        pintaTexto();
                        break;

                    case 'c':
                        labTitulo.Text = "Menú de cierre de sesión";
                        labtext.Text = "Introduzca el tiempo que desea que pase \nhasta que se cierre su sesion \ny pulse continuar.";
                        pcbIcono.Image = imageList1.Images[2];
                        pintaTexto();
                        break;
                }
            }
            catch { }
        }

        /*-----------------------------------------------------------
         * Metodo PintaTexto para centrar un label en el formulario
         ------------------------------------------------------------*/
        private void pintaTexto()
        {
            int puntoMedio;

            //calculo el area del formulario y calculo su punto medio
            Rectangle miArea = this.ClientRectangle;
            puntoMedio = miArea.Width / 2;

            //dibujo la etiqueta centrada
            labTitulo.Location = new Point(puntoMedio - labTitulo.Width / 2, labTitulo.Location.Y);
        }

        //método que controla las teclas que puedes marcar en los numericupdown
        //solo números y el boton de borrar
        private void NudHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si se pulsa el retroceso no controla el evento
            if (e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
            }
            else 
            {
                //si se pulsa cualquier cosa que no sean números del 0 al 9 
                //controla el evento
                if (e.KeyChar < '0' || e.KeyChar > '9') 
                {
                    e.Handled = true;
                }
            }

        }

       

    }
}
