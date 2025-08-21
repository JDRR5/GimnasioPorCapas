namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            FrmPrincipal ppal = new FrmPrincipal();
            ppal.ShowDialog();
            this.Hide();
            this.Dispose(); //Borrelo de la memoria
        }
    }
}
