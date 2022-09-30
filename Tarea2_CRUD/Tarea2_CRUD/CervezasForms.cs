using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_CRUD
{
    public partial class CervezasForms : Form
    {
        public Cerveza Cerveza { get; set; }
        public CervezasForms()
        {
            InitializeComponent();
            Cerveza = new Cerveza();
        }
        public CervezasForms(Cerveza Cerveza):this()
        {
            this.Cerveza=Cerveza;
        }

        private void CervezasForms_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text =this.Cerveza.Nombre;
            this.txtEstilo.Text =this.Cerveza.Estilo;
            this.txtAlcohol.Text = this.Cerveza.Alcohol.ToString();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            this.Cerveza.Nombre = this.txtNombre.Text;
            this.Cerveza.Estilo = this.txtEstilo.Text;
            this.Cerveza.Alcohol = double.Parse(this.txtAlcohol.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
