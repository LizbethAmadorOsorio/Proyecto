namespace patitasOrgMILAV
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //mostrar menu principal
            login miForm = new login();
            miForm.ShowDialog();
            this.Hide();
        }
    }
}
