using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmListadoClientes : Form
    {
        private DBDON_SERGIOSEntities db = new DBDON_SERGIOSEntities();
        CDatos datos = new CDatos();
        CLIENTES clientes = new CLIENTES();
        AUTOS autos = new AUTOS();
        SERVICIOS servicios = new SERVICIOS();

        private int ID;
        private int ID_AUTO;
        private int ID_MODELO;
        private int ID_SERVICIO;

        public FrmListadoClientes()
        {
            InitializeComponent();
        }
 
        private void CargarGrid()
        {
            var lst = datos.Read();
            dgv_Clientes.DataSource = lst;
        }

        private void CargarDatos()
        {
            var query = from c in db.CLIENTES
                        join a in db.AUTOS on c.ID_AUTO equals a.ID_AUTO
                        join m in db.MODELOS on a.ID_MODELO equals m.ID_MODELO
                        join s in db.SERVICIOS on c.ID_SERVICIO equals s.ID_SERVICIO
                        select new
                        {
                            ID = c.ID,
                            Nombre = c.NOMBRES,
                            Apellido = c.APELLIDOS,
                            Direccion = c.DIRECCION,
                            NumeroTelefono = c.TELEFONO,
                            Facebook = c.FACEBOOK,
                            ID_Auto = c.ID_AUTO,
                            Patente = a.PATENTE,
                            Modelo = m.MODELO,
                            Año = a.AÑO,
                            ID_Servicio = c.ID_SERVICIO,
                            Problemas = s.PROBLEMAS,
                            PruebasRealizadas = s.PRUEBAS,
                            Repuestos = s.REPUESTOS,
                            Precios = s.PRECIO,
                            Observaciones = s.OBSERVACIONES,
                            FechaLlegada = s.FECHA_LLEGADA,
                            FechaSalida = s.FECHA_SALIDA
                        };

            dgv_Clientes.DataSource = query.ToList(); // Asigna los resultados al DataGridView
        }

        private void BuscarUNCliente(List<CLIENTES> cCliente)
        {
            var query = from c in cCliente
                        join a in db.AUTOS on c.ID_AUTO equals a.ID_AUTO
                        join m in db.MODELOS on a.ID_MODELO equals m.ID_MODELO
                        join s in db.SERVICIOS on c.ID_SERVICIO equals s.ID_SERVICIO
                        select new
                        {
                            ID = c.ID,
                            Nombre = c.NOMBRES,
                            Apellido = c.APELLIDOS,
                            Direccion = c.DIRECCION,
                            NumeroTelefono = c.TELEFONO,
                            Facebook = c.FACEBOOK,
                            Patente = a.PATENTE,
                            Modelo = m.MODELO,
                            Año = a.AÑO,
                            Problemas = s.PROBLEMAS,
                            PruebasRealizadas = s.PRUEBAS,
                            Repuestos = s.REPUESTOS,
                            Precios = s.PRECIO,
                            Observaciones = s.OBSERVACIONES,
                            FechaLlegada = s.FECHA_LLEGADA,
                            FechaSalida = s.FECHA_SALIDA
                        };

            dgv_Clientes.DataSource = query.ToList(); // Asigna los resultados al DataGridView
        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            //CargarGrid();
            CargarDatos();
            LlenarComboBoxModelos();
            dgv_Clientes.AutoGenerateColumns = false;
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_BuscarNombre.Text != string.Empty)
                {
                    var Lst = datos.buscarNombre(txt_BuscarNombre.Text);
                    BuscarUNCliente(Lst);
                }
                else
                {
                    CargarDatos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (txt_BuscarTelefono.Text != string.Empty)
            {
                var Lst = datos.buscarTelefono(txt_BuscarTelefono.Text);
                BuscarUNCliente(Lst);
            }
            else
            {
                CargarDatos();
            }
        }
        
        private void dgv_Clientes_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgv_Clientes.CurrentRow.Cells["ID"].Value.ToString());
            txt_ID.Text = dgv_Clientes.CurrentRow.Cells["ID"].Value.ToString();
            txt_Nombre.Text = dgv_Clientes.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_Apellido.Text = dgv_Clientes.CurrentRow.Cells["Apellido"].Value.ToString();
            txt_Direccion.Text = dgv_Clientes.CurrentRow.Cells["Direccion"].Value.ToString();
            txt_NumeroTl.Text = dgv_Clientes.CurrentRow.Cells["NumeroTelefono"].Value.ToString();
            txt_Facebook.Text = dgv_Clientes.CurrentRow.Cells["Facebook"].Value.ToString();
            ID_AUTO = Convert.ToInt32(dgv_Clientes.CurrentRow.Cells["ID_Auto"].Value.ToString());
            txt_IDA.Text = dgv_Clientes.CurrentRow.Cells["ID_Auto"].Value.ToString();
            txt_Patente.Text = dgv_Clientes.CurrentRow.Cells["Patente"].Value.ToString();
            cmb_Modelo.Text = dgv_Clientes.CurrentRow.Cells["Modelo"].Value.ToString();
            txt_Año.Text = dgv_Clientes.CurrentRow.Cells["Año"].Value.ToString();
            ID_SERVICIO = Convert.ToInt32(dgv_Clientes.CurrentRow.Cells["ID_Servicio"].Value.ToString());
            txt_IDS.Text = dgv_Clientes.CurrentRow.Cells["ID_Servicio"].Value.ToString();
            txt_Problema.Text = dgv_Clientes.CurrentRow.Cells["Problemas"].Value.ToString();
            txt_Prueba.Text = dgv_Clientes.CurrentRow.Cells["PruebasRealizadas"].Value.ToString();
            txt_Repuestos.Text = dgv_Clientes.CurrentRow.Cells["Repuestos"].Value.ToString();
            txt_Precio.Text = dgv_Clientes.CurrentRow.Cells["Precios"].Value.ToString();
            txt_Observaciones.Text = dgv_Clientes.CurrentRow.Cells["Observaciones"].Value.ToString();
            dateTimePicker1.Text = dgv_Clientes.CurrentRow.Cells["FechaLlegada"].Value.ToString();
            dateTimePicker2.Text = dgv_Clientes.CurrentRow.Cells["FechaSalida"].Value.ToString();
        }
        
        private void EnableTrueTxt()
        {
            txt_Nombre.Enabled = true;
            txt_Apellido.Enabled = true;
            txt_Direccion.Enabled = true;
            txt_NumeroTl.Enabled = true;
            txt_Facebook.Enabled = true;
            txt_Patente.Enabled = true;
            cmb_Modelo.Enabled = true;
            txt_Año.Enabled = true;
            txt_Problema.Enabled = true;
            txt_Prueba.Enabled = true;
            txt_Repuestos.Enabled = true;
            txt_Precio.Enabled = true;
            txt_Observaciones.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void EnableFalseTxt()
        {
            txt_Nombre.Enabled = false;
            txt_Apellido.Enabled = false;
            txt_Direccion.Enabled = false;
            txt_NumeroTl.Enabled = false;
            txt_Facebook.Enabled = false;
            txt_Patente.Enabled = false;
            cmb_Modelo.Enabled = false;
            txt_Año.Enabled = false;
            txt_Problema.Enabled = false;
            txt_Prueba.Enabled = false;
            txt_Repuestos.Enabled = false;
            txt_Precio.Enabled = false;
            txt_Observaciones.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void LimpiarCampos()
        {
            ID = 0;
            txt_ID.Text = string.Empty;
            txt_Nombre.Focus();
            txt_Nombre.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            txt_Direccion.Text = string.Empty;
            txt_NumeroTl.Text = string.Empty;
            txt_Facebook.Text = string.Empty;
            txt_Patente.Text = string.Empty;
            cmb_Modelo.Text = string.Empty;
            txt_Año.Text = string.Empty;
            txt_Problema.Text = string.Empty;
            txt_Prueba.Text = string.Empty;
            txt_Repuestos.Text = string.Empty;
            txt_Precio.Text = string.Empty;
            txt_Observaciones.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
        }
        
        private void LlenarComboBoxModelos()
        {
            try
            {
                var query = db.MODELOS.Select(m => new
                {
                    m.ID_MODELO,
                    m.MODELO
                }).ToList();

                cmb_Modelo.DataSource = query.ToList(); // Asigna los resultados al DataGridView
                cmb_Modelo.DisplayMember = "MODELO";
                cmb_Modelo.ValueMember = "ID_MODELO"; // Usar el ID del modelo como valor seleccionado
                /*
                using (db = new DBDON_SERGIOSEntities())
                {
                    var modelos = db.MODELOS.ToList();
                    cmb_Modelo.DataSource = modelos;
                    cmb_Modelo.DisplayMember = "MODELO"; // Mostrar el nombre del modelo en el ComboBox
                    cmb_Modelo.ValueMember = "ID_MODELO"; // Usar el ID del modelo como valor seleccionado
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                EnableTrueTxt();
                LimpiarCampos();
                btn_Editar.Enabled = false;
                btn_Eliminar.Enabled = false;
                btn_Guardar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Editar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ID > 0)
                {
                    EnableTrueTxt();
                    btn_GuardarEdit.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se puede EDITAR ningun registro", "Error al EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarTxt()
        {
            return txt_ID.Text != string.Empty || txt_Nombre.Text != string.Empty || txt_Apellido.Text != string.Empty || txt_Direccion.Text != string.Empty || txt_NumeroTl.Text != string.Empty || txt_Facebook.Text != string.Empty || txt_Patente.Text != string.Empty || cmb_Modelo.Text != string.Empty || txt_Año.Text != string.Empty || txt_Problema.Text != string.Empty;
        }

        private bool GuardarDatos()
        {
            bool isOk = false;
            if (ValidarTxt() == true)
            {
                clientes.ID = ID;
                clientes.NOMBRES = txt_Nombre.Text;
                clientes.APELLIDOS = txt_Apellido.Text;
                clientes.FACEBOOK = txt_Facebook.Text;
                clientes.DIRECCION = txt_Direccion.Text;
                clientes.TELEFONO = txt_NumeroTl.Text;

                //clientes.ID_AUTO = ID_AUTO;
                autos.PATENTE = txt_Patente.Text;
                autos.AÑO = Convert.ToInt32(txt_Año.Text);
                autos.ID_MODELO = Convert.ToInt32(cmb_Modelo.SelectedValue);

                clientes.AUTOS = autos;

                //clientes.ID_SERVICIO = ID_SERVICIO;
                servicios.PROBLEMAS = txt_Problema.Text;
                servicios.PRUEBAS = txt_Prueba.Text;
                servicios.REPUESTOS = txt_Repuestos.Text;
                servicios.OBSERVACIONES = txt_Observaciones.Text;
                servicios.PRECIO = Convert.ToInt32(txt_Precio.Text);
                servicios.FECHA_LLEGADA = Convert.ToDateTime(dateTimePicker1.Text);
                servicios.FECHA_SALIDA = Convert.ToDateTime(dateTimePicker2.Text);

                clientes.SERVICIOS = servicios;

                btn_Eliminar.Enabled = true;
                btn_Editar.Enabled = true;
                btn_Guardar.Enabled = false;
                isOk = true;
            }
            else
            {
                MessageBox.Show("No se ha creado el Cliente correctamente");
            }
            return isOk;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDatos())
                {
                    datos.Create(clientes);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se ha creado el Cliente correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID > 0)
                {
                    datos.Delete(ID);
                    LimpiarCampos();
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Selecciona el Cliente que desea ELIMINAR", "Error al ELIMINAR registro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_GuardarEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    if (clientes != null)
                    {
                        //clientes = db.CLIENTES.Find(ID);
                        clientes.ID = ID;
                        clientes.NOMBRES = txt_Nombre.Text;
                        clientes.APELLIDOS = txt_Apellido.Text;
                        clientes.FACEBOOK = txt_Facebook.Text;
                        clientes.DIRECCION = txt_Direccion.Text;
                        clientes.TELEFONO = txt_NumeroTl.Text;
                        clientes.ID_AUTO = ID_AUTO;
                        clientes.ID_SERVICIO = ID_SERVICIO;

                        if (servicios != null)
                        {
                            //servicios = db.SERVICIOS.Find(ID_SERVICIO);
                            servicios.ID_SERVICIO = ID_SERVICIO;
                            servicios.PROBLEMAS = txt_Problema.Text;
                            servicios.PRUEBAS = txt_Prueba.Text;
                            servicios.REPUESTOS = txt_Repuestos.Text;
                            servicios.OBSERVACIONES = txt_Observaciones.Text;
                            servicios.PRECIO = Convert.ToDouble(txt_Precio.Text);
                            servicios.FECHA_LLEGADA = Convert.ToDateTime(dateTimePicker1.Text);
                            servicios.FECHA_SALIDA = Convert.ToDateTime(dateTimePicker2.Text);

                            if (autos != null)
                            {
                                //autos = db.AUTOS.Find(ID_AUTO);
                                autos.ID_AUTO = ID_AUTO;
                                autos.PATENTE = txt_Patente.Text;
                                autos.AÑO = Convert.ToInt32(txt_Año.Text);
                                autos.ID_MODELO = Convert.ToInt32(cmb_Modelo.SelectedValue);

                                datos.UpdateServicio(servicios);
                                datos.UpdateAuto(autos);
                                datos.Update(clientes);

                                MessageBox.Show("Cliente, auto y servicio actualizados exitosamente.");
                                CargarDatos();
                                EnableFalseTxt();
                                btn_GuardarEdit.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el auto.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el servicio.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
