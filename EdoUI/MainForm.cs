using System.Timers;
using System.Windows.Forms;

namespace EdoUI
{
    public partial class MainForm : Form
    {
        
        delegate void SetTextCallback(string text);
        static System.Timers.Timer iTimer;

        ControlRaiz iControlRaiz;

        public MainForm()
        {
            InitializeComponent();

            this.iControlRaiz = new ControlRaiz() { Dock = DockStyle.Fill };

            this.PanelRaiz.Controls.Add(this.iControlRaiz);


            iTimer = new System.Timers.Timer(5000);
            iTimer.Elapsed += new ElapsedEventHandler(iTimer_Elapsed);
            iTimer.Enabled = true;
        }

        private void iTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //this.SetText(VerificarConexion.ObtenerEstadoConexion() ? "Conectado" : "Sin Conexion");
        }
        private void SetText(string pTexto)
        {
            if (this.statusStripConexion.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { pTexto });
            }
            else
            {
                this.toolStripStatusLabelConexion.Text = pTexto;
            }
        }

    }
}
