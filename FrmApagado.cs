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
    
    public partial class FrmApagado : Form
    {
        FrmPrincipal mifrmPrin;
        FrmTiempo mifrmTiem;

        //atributos de horas minutos y segundos
        int h, m, s, h1,m1,s1;
        //el atributo tipo controla que proceso se realiza
        char Tipo;
        //campo para controlar si parar o reanudar el timer
        bool parar = true;
        //campo para comprobar a que formulario ir al pulsar el boton atras, va al formulario anterior
        bool Principal;
        //objeto de la clase proceso para realizar el proceso que toque
        Process miProceso = new Process();
        

        //constructor
        public FrmApagado(int horas, int minutos, int segundos, char tipo,bool principal)
        {
            //campos para el timer
            this.h = horas;
            this.m = minutos;
            this.s = segundos;

            //campos para el boton atras
            this.h1 = horas;
            this.m1 = minutos;
            this.s1 = segundos;

            this.Tipo = tipo;
            this.Principal = principal;

            InitializeComponent();
            labTiempo.Text = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
            timer1.Start();
        }

        /*-------------------------------------------------------------------------
         * Evento que controla el tiempo del timer y el texto del label
         --------------------------------------------------------------------------*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (h == 0 && m == 0 )
            {
                //cuando queda menos de un minuto pinta el texto en rojo
                labTiempo.ForeColor = System.Drawing.Color.Red;
                s = s - 1;
                labTiempo.Text = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);

                //cuando llega a 0 se para el timer y se lanza el proceso  
                if (s <= 0)
                {
                    timer1.Stop();

                    miProceso.Start();
                }
            }
            else
            {
                if (s > 0)
                {
                    s = s - 1;
                }
                else
                {
                    if (s == 0)
                    {
                        m = m - 1;
                        s = 59;

                        if (m < 0)
                        {
                            m = 59;
                            h = h - 1;

                        }
                    }
                }
            }

            labTiempo.Text = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
            TsmTiempo.Text = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
        }

        //evento click en el boton atras
        //selecciona el formulario anterior y lo llama
        private void BtnAtras_click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (Principal)
            {
                mifrmPrin = new FrmPrincipal();
                mifrmPrin.Show();
                this.Close();
            }
            else 
            {
                mifrmTiem = new FrmTiempo(Tipo, h1, m1, s1);
                mifrmTiem.Show();
                this.Close();
            }
            
            
        }

        private void FrmApagado_Load(object sender, EventArgs e)
        {
            //enciende el timer al cargar el formulario
            timer1.Start();

            //escoje que formulario mostrar y el proceso a realizar
            try
            {
                switch (Tipo)
                {
                    case 'a':
                        labTexto.Text = "Su ordenador se apagará en:";
                        TsmTitulo.Text = "Apagado en:";
                        NtiIcono.BalloonTipTitle = "Apagado programado";
                        miProceso.StartInfo.FileName = "shutdown.exe";
                        miProceso.StartInfo.Arguments = "-s -t 0";
                        pintaTexto();
                        break;
                    case 'r':
                        labTexto.Text = "Su ordenador se reiniciará en:";
                        TsmTitulo.Text = "Reinicio en:";
                        NtiIcono.BalloonTipTitle = "Reinicio programado";
                        miProceso.StartInfo.FileName = "shutdown.exe";
                        miProceso.StartInfo.Arguments = "-r -t 0";
                        pintaTexto();
                        break;

                    case 'c':
                        labTexto.Text = "Su sesión se cerrará en:";
                        TsmTitulo.Text = "Cierre de sesión en:";
                        NtiIcono.BalloonTipTitle = "Cierre de sesión programado";
                        miProceso.StartInfo.FileName = "shutdown.exe";
                        miProceso.StartInfo.Arguments = "-l ";
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
            labTexto.Location = new Point(puntoMedio - labTexto.Width / 2, labTexto.Location.Y);
        }

        //evento click sobre elboton salir
        private void BtnSalir_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //eventoclick sobre el boton minimizar
        //minimiza la aplicacion al la tray bar
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            NtiIcono.Visible = true;
            NtiIcono.ShowBalloonTip(3);
        }
       
        
        //evento de pulsar sobre el boton maximizar del notifyicon
        private void TsmMaximizar_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
            NtiIcono.Visible = false;
        }


        //evento click sobre el boton salir del notifyIcon
        private void TsmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //evento click en el boton parar para o reanuda el timer y cambia el texto del boton
        private void BtnParar_Click(object sender, EventArgs e)
        {
            if (parar)
            {
                timer1.Stop();
                BtnParar.Text = "&Reanudar";
                parar = false;
            }
            else 
            {
                timer1.Start();
                BtnParar.Text = "&Pausar";
                parar = true;
            }
        }

        //evento click en el boton parar del menu para o reanuda el timer y cambia el texto del boton
        private void TsmParar_Click(object sender, EventArgs e)
        {
            if (parar)
            {
                timer1.Stop();
                TsmParar.Text = "&Reanudar";
                parar = false;
            }
            else
            {
                timer1.Start();
                TsmParar.Text = "&Pausar";
                parar = true;
            }
        }

        //evento paitn de boton parar para que al cambiar del notifyIcon al formulario 
        //si el timer está parado muestre reanuday y sino muestre pausar
        private void BtnParar_Paint(object sender, PaintEventArgs e)
        {
            if (parar)
            {
                BtnParar.Text = "&Pausar";
            }
            else 
            {
                BtnParar.Text = "&Reanudar";
            }
        }


        //evento paint de boton parar del menu para que al cambiar del notifyIcon al formulario 
        //si el timer está parado muestre reanuday y sino muestre pausar
        private void TsmParar_Paint(object sender, PaintEventArgs e)
        {

            if (parar)
            {
                TsmParar.Text = "&Pausar";
            }
            else
            {
               TsmParar.Text = "&Reanudar";
            }
        }

        
        //evento doble click sobre el icono del notifyicon
        //maximiza la ventana
        private void NtiIcono_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
            NtiIcono.Visible = false;
        }
    }
}
