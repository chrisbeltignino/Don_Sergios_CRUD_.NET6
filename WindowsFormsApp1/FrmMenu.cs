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
    public partial class FrmMenu : Form
    {
        public static FrmListadoClientes formListadoCliente = new FrmListadoClientes();

        private Form activeForm = new Form();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
            if (panelSubMenuListados.Visible == true)
            {
                panelSubMenuListados.Visible = false;
            }
            if (panelSubMenuRepuestos.Visible == true)
            {
                panelSubMenuRepuestos.Visible = false;
            }
            if (panelSubMenuEstadisticas.Visible == true)
            {
                panelSubMenuEstadisticas.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.MdiParent = this;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelFormulario.Controls.Add(childForm);
                panelFormulario.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void btn_Listados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuListados);
        }

        private void btn_ListaClientes_Click(object sender, EventArgs e)
        {
            FrmListadoClientes newForm = new FrmListadoClientes();
            formListadoCliente = newForm;

            openChildForm(FrmMenu.formListadoCliente);

            hideSubMenu();
        }

        private void btn_Repuestos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRepuestos);
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuEstadisticas);
        }
    }
}
