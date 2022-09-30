namespace Tarea2_CRUD
{
    public partial class Form1 : Form
    {   
       public List<Cerveza> Cervezas { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Cervezas = new List<Cerveza>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvCervezas.DataSource = Cervezas;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            CervezasForms cervezasForms = new CervezasForms();
            if (cervezasForms.ShowDialog()==DialogResult.OK)
            {
                this.Cervezas.Add(cervezasForms.Cerveza);
                this.dgvCervezas.DataSource = this.Cervezas.ToList();

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cerveza? seleccionada = (Cerveza)this.dgvCervezas.CurrentRow.DataBoundItem;
            CervezasForms cervezasForms = new CervezasForms(seleccionada);
            if (cervezasForms.ShowDialog() == DialogResult.OK)
            {
                Cerveza? editar = this.Cervezas.FirstOrDefault(c=>c==seleccionada);
                editar = cervezasForms.Cerveza;
                this.dgvCervezas.DataSource = this.Cervezas.ToList();

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Cerveza? seleccionada = (Cerveza)this.dgvCervezas.CurrentRow.DataBoundItem;
            this.Cervezas.Remove(seleccionada);

        }
    }
}