namespace WindowsFormsApp1
{
    partial class FrmListadoClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BuscarNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BuscarTelefono = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_NumeroTl = new System.Windows.Forms.TextBox();
            this.txt_Facebook = new System.Windows.Forms.TextBox();
            this.txt_Patente = new System.Windows.Forms.TextBox();
            this.txt_Año = new System.Windows.Forms.TextBox();
            this.txt_Problema = new System.Windows.Forms.TextBox();
            this.txt_Prueba = new System.Windows.Forms.TextBox();
            this.txt_Repuestos = new System.Windows.Forms.TextBox();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_GuardarEdit = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_IDS = new System.Windows.Forms.TextBox();
            this.txt_IDA = new System.Windows.Forms.TextBox();
            this.cmb_Modelo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1720, 433);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "";
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.AllowUserToOrderColumns = true;
            this.dgv_Clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Location = new System.Drawing.Point(25, 22);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.Size = new System.Drawing.Size(1673, 381);
            this.dgv_Clientes.TabIndex = 0;
            this.dgv_Clientes.DoubleClick += new System.EventHandler(this.dgv_Clientes_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(499, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar por Nombre:";
            // 
            // txt_BuscarNombre
            // 
            this.txt_BuscarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_BuscarNombre.Location = new System.Drawing.Point(655, 32);
            this.txt_BuscarNombre.Name = "txt_BuscarNombre";
            this.txt_BuscarNombre.Size = new System.Drawing.Size(176, 20);
            this.txt_BuscarNombre.TabIndex = 2;
            this.txt_BuscarNombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(148, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por Telefono:";
            // 
            // txt_BuscarTelefono
            // 
            this.txt_BuscarTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_BuscarTelefono.Location = new System.Drawing.Point(307, 32);
            this.txt_BuscarTelefono.Name = "txt_BuscarTelefono";
            this.txt_BuscarTelefono.Size = new System.Drawing.Size(176, 20);
            this.txt_BuscarTelefono.TabIndex = 1;
            this.txt_BuscarTelefono.TextChanged += new System.EventHandler(this.txt_Telefono_TextChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(220, 55);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(65, 20);
            this.txt_ID.TabIndex = 7;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(220, 110);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(153, 20);
            this.txt_Nombre.TabIndex = 8;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Apellido.Enabled = false;
            this.txt_Apellido.Location = new System.Drawing.Point(220, 174);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(153, 20);
            this.txt_Apellido.TabIndex = 9;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Direccion.Enabled = false;
            this.txt_Direccion.Location = new System.Drawing.Point(220, 239);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(153, 20);
            this.txt_Direccion.TabIndex = 10;
            // 
            // txt_NumeroTl
            // 
            this.txt_NumeroTl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NumeroTl.Enabled = false;
            this.txt_NumeroTl.Location = new System.Drawing.Point(550, 55);
            this.txt_NumeroTl.Name = "txt_NumeroTl";
            this.txt_NumeroTl.Size = new System.Drawing.Size(153, 20);
            this.txt_NumeroTl.TabIndex = 11;
            // 
            // txt_Facebook
            // 
            this.txt_Facebook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Facebook.Enabled = false;
            this.txt_Facebook.Location = new System.Drawing.Point(550, 110);
            this.txt_Facebook.Name = "txt_Facebook";
            this.txt_Facebook.Size = new System.Drawing.Size(153, 20);
            this.txt_Facebook.TabIndex = 12;
            // 
            // txt_Patente
            // 
            this.txt_Patente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Patente.Enabled = false;
            this.txt_Patente.Location = new System.Drawing.Point(550, 174);
            this.txt_Patente.Name = "txt_Patente";
            this.txt_Patente.Size = new System.Drawing.Size(153, 20);
            this.txt_Patente.TabIndex = 13;
            // 
            // txt_Año
            // 
            this.txt_Año.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Año.Enabled = false;
            this.txt_Año.Location = new System.Drawing.Point(938, 53);
            this.txt_Año.Name = "txt_Año";
            this.txt_Año.Size = new System.Drawing.Size(100, 20);
            this.txt_Año.TabIndex = 15;
            // 
            // txt_Problema
            // 
            this.txt_Problema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Problema.Enabled = false;
            this.txt_Problema.Location = new System.Drawing.Point(938, 317);
            this.txt_Problema.Multiline = true;
            this.txt_Problema.Name = "txt_Problema";
            this.txt_Problema.Size = new System.Drawing.Size(258, 202);
            this.txt_Problema.TabIndex = 21;
            // 
            // txt_Prueba
            // 
            this.txt_Prueba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Prueba.Enabled = false;
            this.txt_Prueba.Location = new System.Drawing.Point(1403, 315);
            this.txt_Prueba.Multiline = true;
            this.txt_Prueba.Name = "txt_Prueba";
            this.txt_Prueba.Size = new System.Drawing.Size(258, 200);
            this.txt_Prueba.TabIndex = 22;
            // 
            // txt_Repuestos
            // 
            this.txt_Repuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Repuestos.Enabled = false;
            this.txt_Repuestos.Location = new System.Drawing.Point(540, 317);
            this.txt_Repuestos.Multiline = true;
            this.txt_Repuestos.Name = "txt_Repuestos";
            this.txt_Repuestos.Size = new System.Drawing.Size(258, 202);
            this.txt_Repuestos.TabIndex = 20;
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Observaciones.Enabled = false;
            this.txt_Observaciones.Location = new System.Drawing.Point(152, 319);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(258, 200);
            this.txt_Observaciones.TabIndex = 19;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Precio.Enabled = false;
            this.txt_Precio.Location = new System.Drawing.Point(938, 108);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_GuardarEdit);
            this.panel2.Controls.Add(this.btn_Guardar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_BuscarNombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_BuscarTelefono);
            this.panel2.Controls.Add(this.btn_Nuevo);
            this.panel2.Controls.Add(this.btn_Editar);
            this.panel2.Controls.Add(this.btn_Eliminar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1720, 83);
            this.panel2.TabIndex = 24;
            // 
            // btn_GuardarEdit
            // 
            this.btn_GuardarEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GuardarEdit.Image = global::WindowsFormsApp1.Properties.Resources._1904659_arrow_backup_down_download_save_storage_transfer_122509;
            this.btn_GuardarEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarEdit.Location = new System.Drawing.Point(1352, 20);
            this.btn_GuardarEdit.Name = "btn_GuardarEdit";
            this.btn_GuardarEdit.Size = new System.Drawing.Size(142, 42);
            this.btn_GuardarEdit.TabIndex = 9;
            this.btn_GuardarEdit.Text = "Guardar Edicion";
            this.btn_GuardarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarEdit.UseVisualStyleBackColor = true;
            this.btn_GuardarEdit.Visible = false;
            this.btn_GuardarEdit.Click += new System.EventHandler(this.btn_GuardarEdit_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Image = global::WindowsFormsApp1.Properties.Resources._1904659_arrow_backup_down_download_save_storage_transfer_122509;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(1352, 20);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(142, 42);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Nuevo.Image = global::WindowsFormsApp1.Properties.Resources._1904677_add_addition_calculate_charge_create_new_plus_122527__1_;
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(866, 20);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(142, 42);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click_1);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Editar.Image = global::WindowsFormsApp1.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(1029, 20);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(142, 42);
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click_1);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Eliminar.Image = global::WindowsFormsApp1.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(1191, 20);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(142, 42);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_IDS);
            this.panel3.Controls.Add(this.txt_IDA);
            this.panel3.Controls.Add(this.cmb_Modelo);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txt_Prueba);
            this.panel3.Controls.Add(this.txt_Problema);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.txt_Facebook);
            this.panel3.Controls.Add(this.txt_ID);
            this.panel3.Controls.Add(this.txt_Nombre);
            this.panel3.Controls.Add(this.txt_Apellido);
            this.panel3.Controls.Add(this.txt_Precio);
            this.panel3.Controls.Add(this.txt_Direccion);
            this.panel3.Controls.Add(this.txt_Observaciones);
            this.panel3.Controls.Add(this.txt_NumeroTl);
            this.panel3.Controls.Add(this.txt_Repuestos);
            this.panel3.Controls.Add(this.txt_Patente);
            this.panel3.Controls.Add(this.txt_Año);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 516);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1720, 564);
            this.panel3.TabIndex = 25;
            // 
            // txt_IDS
            // 
            this.txt_IDS.Location = new System.Drawing.Point(1259, 90);
            this.txt_IDS.Name = "txt_IDS";
            this.txt_IDS.Size = new System.Drawing.Size(100, 20);
            this.txt_IDS.TabIndex = 40;
            this.txt_IDS.Visible = false;
            // 
            // txt_IDA
            // 
            this.txt_IDA.Location = new System.Drawing.Point(1259, 53);
            this.txt_IDA.Name = "txt_IDA";
            this.txt_IDA.Size = new System.Drawing.Size(100, 20);
            this.txt_IDA.TabIndex = 10;
            this.txt_IDA.Visible = false;
            // 
            // cmb_Modelo
            // 
            this.cmb_Modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Modelo.Enabled = false;
            this.cmb_Modelo.FormattingEnabled = true;
            this.cmb_Modelo.Location = new System.Drawing.Point(550, 239);
            this.cmb_Modelo.Name = "cmb_Modelo";
            this.cmb_Modelo.Size = new System.Drawing.Size(153, 21);
            this.cmb_Modelo.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(779, 234);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "Fecha Salida(Aprox):";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(821, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Fecha Llegada:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(837, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "Precio Total:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(31, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Observaciones:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(448, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Repuestos:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(1255, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Pruebas realizadas:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(845, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Problemas:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(890, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Año:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(478, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Modelo:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(477, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Patente:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(464, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Facebook:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(391, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Número de Teléfono:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(135, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "DIreccion:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(143, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(143, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(123, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número ID:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(938, 236);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(938, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // FrmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1720, 1080);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoClientes";
            this.Text = "FrmListadoClientes";
            this.Load += new System.EventHandler(this.FrmListadoClientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BuscarTelefono;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BuscarNombre;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_NumeroTl;
        private System.Windows.Forms.TextBox txt_Facebook;
        private System.Windows.Forms.TextBox txt_Patente;
        private System.Windows.Forms.TextBox txt_Año;
        private System.Windows.Forms.TextBox txt_Problema;
        private System.Windows.Forms.TextBox txt_Prueba;
        private System.Windows.Forms.TextBox txt_Repuestos;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Modelo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_GuardarEdit;
        private System.Windows.Forms.TextBox txt_IDS;
        private System.Windows.Forms.TextBox txt_IDA;
    }
}