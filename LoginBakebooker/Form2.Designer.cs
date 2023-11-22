namespace LoginBakebooker
{
    partial class Form2
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
            this.tabPageInventario = new System.Windows.Forms.TabPage();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.tabPageDetallePedidos = new System.Windows.Forms.TabPage();
            this.dgvPedido_detalles = new System.Windows.Forms.DataGridView();
            this.tabPagePedidos = new System.Windows.Forms.TabPage();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.tabPageProovedores = new System.Windows.Forms.TabPage();
            this.dgvProovedores = new System.Windows.Forms.DataGridView();
            this.CORREO_ELECTRONICO_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_PROOVEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROOVEDOR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tabPageEmpleados = new System.Windows.Forms.TabPage();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tabPageClientes = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtCliente_ID_C = new System.Windows.Forms.TextBox();
            this.txtA_Paterno_C = new System.Windows.Forms.TextBox();
            this.txtA_Materno_C = new System.Windows.Forms.TextBox();
            this.txtNombre_C = new System.Windows.Forms.TextBox();
            this.txtTelefono_C = new System.Windows.Forms.TextBox();
            this.txtRfc_C = new System.Windows.Forms.TextBox();
            this.txtCorreo_Electronico_C = new System.Windows.Forms.TextBox();
            this.txt_Direccion_C = new System.Windows.Forms.TextBox();
            this.txt_Colonia_C = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Postal_C = new System.Windows.Forms.TextBox();
            this.txt_Fecha_Alta_C = new System.Windows.Forms.TextBox();
            this.lblCliente_ID_C = new System.Windows.Forms.Label();
            this.lbl_A_Paterno_C = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInsertar_C = new System.Windows.Forms.Button();
            this.btnEliminar_C = new System.Windows.Forms.Button();
            this.btnModificar_C = new System.Windows.Forms.Button();
            this.btnBuscar_C = new System.Windows.Forms.Button();
            this.tabControlBakeBooker = new System.Windows.Forms.TabControl();
            this.tabPageInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.tabPageDetallePedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido_detalles)).BeginInit();
            this.tabPagePedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabPageProovedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProovedores)).BeginInit();
            this.tabPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabPageEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tabPageClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabControlBakeBooker.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageInventario
            // 
            this.tabPageInventario.Controls.Add(this.dgvInventario);
            this.tabPageInventario.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventario.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageInventario.Name = "tabPageInventario";
            this.tabPageInventario.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageInventario.Size = new System.Drawing.Size(768, 327);
            this.tabPageInventario.TabIndex = 6;
            this.tabPageInventario.Text = "Inventario";
            this.tabPageInventario.UseVisualStyleBackColor = true;
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(-1, 70);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 62;
            this.dgvInventario.RowTemplate.Height = 28;
            this.dgvInventario.Size = new System.Drawing.Size(763, 253);
            this.dgvInventario.TabIndex = 5;
            // 
            // tabPageDetallePedidos
            // 
            this.tabPageDetallePedidos.Controls.Add(this.dgvPedido_detalles);
            this.tabPageDetallePedidos.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetallePedidos.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDetallePedidos.Name = "tabPageDetallePedidos";
            this.tabPageDetallePedidos.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDetallePedidos.Size = new System.Drawing.Size(768, 327);
            this.tabPageDetallePedidos.TabIndex = 5;
            this.tabPageDetallePedidos.Text = "Detalle Pedidos";
            this.tabPageDetallePedidos.UseVisualStyleBackColor = true;
            // 
            // dgvPedido_detalles
            // 
            this.dgvPedido_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido_detalles.Location = new System.Drawing.Point(2, 76);
            this.dgvPedido_detalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido_detalles.Name = "dgvPedido_detalles";
            this.dgvPedido_detalles.RowHeadersWidth = 62;
            this.dgvPedido_detalles.RowTemplate.Height = 28;
            this.dgvPedido_detalles.Size = new System.Drawing.Size(763, 253);
            this.dgvPedido_detalles.TabIndex = 4;
            // 
            // tabPagePedidos
            // 
            this.tabPagePedidos.Controls.Add(this.dgvPedidos);
            this.tabPagePedidos.Location = new System.Drawing.Point(4, 22);
            this.tabPagePedidos.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePedidos.Name = "tabPagePedidos";
            this.tabPagePedidos.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePedidos.Size = new System.Drawing.Size(768, 327);
            this.tabPagePedidos.TabIndex = 4;
            this.tabPagePedidos.Text = "Pedidos";
            this.tabPagePedidos.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(4, 74);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 62;
            this.dgvPedidos.RowTemplate.Height = 28;
            this.dgvPedidos.Size = new System.Drawing.Size(763, 253);
            this.dgvPedidos.TabIndex = 4;
            // 
            // tabPageProovedores
            // 
            this.tabPageProovedores.Controls.Add(this.dgvProovedores);
            this.tabPageProovedores.Location = new System.Drawing.Point(4, 22);
            this.tabPageProovedores.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageProovedores.Name = "tabPageProovedores";
            this.tabPageProovedores.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageProovedores.Size = new System.Drawing.Size(768, 327);
            this.tabPageProovedores.TabIndex = 3;
            this.tabPageProovedores.Text = "Proovedores";
            this.tabPageProovedores.UseVisualStyleBackColor = true;
            // 
            // dgvProovedores
            // 
            this.dgvProovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProovedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROOVEDOR_ID,
            this.NOMBRE_PROOVEDOR,
            this.TELEFONO_P,
            this.CORREO_ELECTRONICO_P});
            this.dgvProovedores.Location = new System.Drawing.Point(2, 76);
            this.dgvProovedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProovedores.Name = "dgvProovedores";
            this.dgvProovedores.RowHeadersWidth = 62;
            this.dgvProovedores.RowTemplate.Height = 28;
            this.dgvProovedores.Size = new System.Drawing.Size(763, 253);
            this.dgvProovedores.TabIndex = 3;
            // 
            // CORREO_ELECTRONICO_P
            // 
            this.CORREO_ELECTRONICO_P.HeaderText = "CORREO_ELECTRONICO";
            this.CORREO_ELECTRONICO_P.MinimumWidth = 8;
            this.CORREO_ELECTRONICO_P.Name = "CORREO_ELECTRONICO_P";
            this.CORREO_ELECTRONICO_P.Width = 150;
            // 
            // TELEFONO_P
            // 
            this.TELEFONO_P.HeaderText = "TELEFONO";
            this.TELEFONO_P.MinimumWidth = 8;
            this.TELEFONO_P.Name = "TELEFONO_P";
            this.TELEFONO_P.Width = 150;
            // 
            // NOMBRE_PROOVEDOR
            // 
            this.NOMBRE_PROOVEDOR.HeaderText = "NOMBRE_PROOVEDOR";
            this.NOMBRE_PROOVEDOR.MinimumWidth = 8;
            this.NOMBRE_PROOVEDOR.Name = "NOMBRE_PROOVEDOR";
            this.NOMBRE_PROOVEDOR.Width = 150;
            // 
            // PROOVEDOR_ID
            // 
            this.PROOVEDOR_ID.HeaderText = "PROOVEDOR_ID";
            this.PROOVEDOR_ID.MinimumWidth = 8;
            this.PROOVEDOR_ID.Name = "PROOVEDOR_ID";
            this.PROOVEDOR_ID.Width = 150;
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.Controls.Add(this.dgvProductos);
            this.tabPageProductos.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductos.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageProductos.Size = new System.Drawing.Size(768, 327);
            this.tabPageProductos.TabIndex = 2;
            this.tabPageProductos.Text = "Productos";
            this.tabPageProductos.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(2, 74);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(763, 253);
            this.dgvProductos.TabIndex = 2;
            // 
            // tabPageEmpleados
            // 
            this.tabPageEmpleados.Controls.Add(this.dgvEmpleados);
            this.tabPageEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEmpleados.Name = "tabPageEmpleados";
            this.tabPageEmpleados.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageEmpleados.Size = new System.Drawing.Size(768, 327);
            this.tabPageEmpleados.TabIndex = 1;
            this.tabPageEmpleados.Text = "Empleados";
            this.tabPageEmpleados.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(4, 74);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 62;
            this.dgvEmpleados.RowTemplate.Height = 28;
            this.dgvEmpleados.Size = new System.Drawing.Size(763, 253);
            this.dgvEmpleados.TabIndex = 1;
            // 
            // tabPageClientes
            // 
            this.tabPageClientes.Controls.Add(this.btnBuscar_C);
            this.tabPageClientes.Controls.Add(this.btnModificar_C);
            this.tabPageClientes.Controls.Add(this.btnEliminar_C);
            this.tabPageClientes.Controls.Add(this.btnInsertar_C);
            this.tabPageClientes.Controls.Add(this.label9);
            this.tabPageClientes.Controls.Add(this.label8);
            this.tabPageClientes.Controls.Add(this.label7);
            this.tabPageClientes.Controls.Add(this.label6);
            this.tabPageClientes.Controls.Add(this.label5);
            this.tabPageClientes.Controls.Add(this.label1);
            this.tabPageClientes.Controls.Add(this.label4);
            this.tabPageClientes.Controls.Add(this.label3);
            this.tabPageClientes.Controls.Add(this.label2);
            this.tabPageClientes.Controls.Add(this.lbl_A_Paterno_C);
            this.tabPageClientes.Controls.Add(this.lblCliente_ID_C);
            this.tabPageClientes.Controls.Add(this.txt_Fecha_Alta_C);
            this.tabPageClientes.Controls.Add(this.txt_Codigo_Postal_C);
            this.tabPageClientes.Controls.Add(this.txt_Colonia_C);
            this.tabPageClientes.Controls.Add(this.txt_Direccion_C);
            this.tabPageClientes.Controls.Add(this.txtCorreo_Electronico_C);
            this.tabPageClientes.Controls.Add(this.txtRfc_C);
            this.tabPageClientes.Controls.Add(this.txtTelefono_C);
            this.tabPageClientes.Controls.Add(this.txtNombre_C);
            this.tabPageClientes.Controls.Add(this.txtA_Materno_C);
            this.tabPageClientes.Controls.Add(this.txtA_Paterno_C);
            this.tabPageClientes.Controls.Add(this.txtCliente_ID_C);
            this.tabPageClientes.Controls.Add(this.dgvClientes);
            this.tabPageClientes.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientes.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageClientes.Size = new System.Drawing.Size(768, 327);
            this.tabPageClientes.TabIndex = 0;
            this.tabPageClientes.Text = "Clientes";
            this.tabPageClientes.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(4, 132);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(763, 196);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.TabStop = false;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // txtCliente_ID_C
            // 
            this.txtCliente_ID_C.Location = new System.Drawing.Point(90, 10);
            this.txtCliente_ID_C.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente_ID_C.Name = "txtCliente_ID_C";
            this.txtCliente_ID_C.Size = new System.Drawing.Size(68, 20);
            this.txtCliente_ID_C.TabIndex = 1;
            // 
            // txtA_Paterno_C
            // 
            this.txtA_Paterno_C.Location = new System.Drawing.Point(88, 33);
            this.txtA_Paterno_C.Margin = new System.Windows.Forms.Padding(2);
            this.txtA_Paterno_C.Name = "txtA_Paterno_C";
            this.txtA_Paterno_C.Size = new System.Drawing.Size(188, 20);
            this.txtA_Paterno_C.TabIndex = 1;
            // 
            // txtA_Materno_C
            // 
            this.txtA_Materno_C.Location = new System.Drawing.Point(88, 57);
            this.txtA_Materno_C.Margin = new System.Windows.Forms.Padding(2);
            this.txtA_Materno_C.Name = "txtA_Materno_C";
            this.txtA_Materno_C.Size = new System.Drawing.Size(188, 20);
            this.txtA_Materno_C.TabIndex = 1;
            // 
            // txtNombre_C
            // 
            this.txtNombre_C.Location = new System.Drawing.Point(87, 82);
            this.txtNombre_C.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre_C.Name = "txtNombre_C";
            this.txtNombre_C.Size = new System.Drawing.Size(188, 20);
            this.txtNombre_C.TabIndex = 1;
            // 
            // txtTelefono_C
            // 
            this.txtTelefono_C.Location = new System.Drawing.Point(91, 103);
            this.txtTelefono_C.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono_C.Name = "txtTelefono_C";
            this.txtTelefono_C.Size = new System.Drawing.Size(113, 20);
            this.txtTelefono_C.TabIndex = 1;
            // 
            // txtRfc_C
            // 
            this.txtRfc_C.Location = new System.Drawing.Point(365, 10);
            this.txtRfc_C.Margin = new System.Windows.Forms.Padding(2);
            this.txtRfc_C.Name = "txtRfc_C";
            this.txtRfc_C.Size = new System.Drawing.Size(154, 20);
            this.txtRfc_C.TabIndex = 1;
            // 
            // txtCorreo_Electronico_C
            // 
            this.txtCorreo_Electronico_C.Location = new System.Drawing.Point(365, 33);
            this.txtCorreo_Electronico_C.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo_Electronico_C.Name = "txtCorreo_Electronico_C";
            this.txtCorreo_Electronico_C.Size = new System.Drawing.Size(154, 20);
            this.txtCorreo_Electronico_C.TabIndex = 1;
            // 
            // txt_Direccion_C
            // 
            this.txt_Direccion_C.Location = new System.Drawing.Point(365, 57);
            this.txt_Direccion_C.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Direccion_C.Name = "txt_Direccion_C";
            this.txt_Direccion_C.Size = new System.Drawing.Size(154, 20);
            this.txt_Direccion_C.TabIndex = 1;
            // 
            // txt_Colonia_C
            // 
            this.txt_Colonia_C.Location = new System.Drawing.Point(365, 82);
            this.txt_Colonia_C.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Colonia_C.Name = "txt_Colonia_C";
            this.txt_Colonia_C.Size = new System.Drawing.Size(154, 20);
            this.txt_Colonia_C.TabIndex = 1;
            // 
            // txt_Codigo_Postal_C
            // 
            this.txt_Codigo_Postal_C.Location = new System.Drawing.Point(325, 103);
            this.txt_Codigo_Postal_C.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Codigo_Postal_C.Name = "txt_Codigo_Postal_C";
            this.txt_Codigo_Postal_C.Size = new System.Drawing.Size(68, 20);
            this.txt_Codigo_Postal_C.TabIndex = 1;
            // 
            // txt_Fecha_Alta_C
            // 
            this.txt_Fecha_Alta_C.Location = new System.Drawing.Point(619, 10);
            this.txt_Fecha_Alta_C.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Fecha_Alta_C.Name = "txt_Fecha_Alta_C";
            this.txt_Fecha_Alta_C.Size = new System.Drawing.Size(121, 20);
            this.txt_Fecha_Alta_C.TabIndex = 1;
            this.txt_Fecha_Alta_C.TextChanged += new System.EventHandler(this.txt_Fecha_Alta_C_TextChanged);
            // 
            // lblCliente_ID_C
            // 
            this.lblCliente_ID_C.AutoSize = true;
            this.lblCliente_ID_C.Location = new System.Drawing.Point(13, 12);
            this.lblCliente_ID_C.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente_ID_C.Name = "lblCliente_ID_C";
            this.lblCliente_ID_C.Size = new System.Drawing.Size(72, 13);
            this.lblCliente_ID_C.TabIndex = 2;
            this.lblCliente_ID_C.Text = "CLIENTE_ID:";
            // 
            // lbl_A_Paterno_C
            // 
            this.lbl_A_Paterno_C.AutoSize = true;
            this.lbl_A_Paterno_C.Location = new System.Drawing.Point(11, 35);
            this.lbl_A_Paterno_C.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_A_Paterno_C.Name = "lbl_A_Paterno_C";
            this.lbl_A_Paterno_C.Size = new System.Drawing.Size(75, 13);
            this.lbl_A_Paterno_C.TabIndex = 3;
            this.lbl_A_Paterno_C.Text = "A_PATERNO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A_MATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFONO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RFC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "CORREO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "DIRECCION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "COLONIA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "CP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "FECHA_ALTA:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnInsertar_C
            // 
            this.btnInsertar_C.Location = new System.Drawing.Point(538, 47);
            this.btnInsertar_C.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar_C.Name = "btnInsertar_C";
            this.btnInsertar_C.Size = new System.Drawing.Size(75, 27);
            this.btnInsertar_C.TabIndex = 5;
            this.btnInsertar_C.Text = "Insertar";
            this.btnInsertar_C.UseVisualStyleBackColor = true;
            this.btnInsertar_C.Click += new System.EventHandler(this.btnInsertar_C_Click);
            // 
            // btnEliminar_C
            // 
            this.btnEliminar_C.Location = new System.Drawing.Point(619, 47);
            this.btnEliminar_C.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar_C.Name = "btnEliminar_C";
            this.btnEliminar_C.Size = new System.Drawing.Size(75, 27);
            this.btnEliminar_C.TabIndex = 6;
            this.btnEliminar_C.Text = "Eliminar";
            this.btnEliminar_C.UseVisualStyleBackColor = true;
            this.btnEliminar_C.Click += new System.EventHandler(this.btnEliminar_C_Click);
            // 
            // btnModificar_C
            // 
            this.btnModificar_C.Location = new System.Drawing.Point(538, 84);
            this.btnModificar_C.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar_C.Name = "btnModificar_C";
            this.btnModificar_C.Size = new System.Drawing.Size(75, 28);
            this.btnModificar_C.TabIndex = 7;
            this.btnModificar_C.Text = "Modificar";
            this.btnModificar_C.UseVisualStyleBackColor = true;
            // 
            // btnBuscar_C
            // 
            this.btnBuscar_C.Location = new System.Drawing.Point(619, 84);
            this.btnBuscar_C.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar_C.Name = "btnBuscar_C";
            this.btnBuscar_C.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar_C.TabIndex = 8;
            this.btnBuscar_C.Text = "Buscar";
            this.btnBuscar_C.UseVisualStyleBackColor = true;
            // 
            // tabControlBakeBooker
            // 
            this.tabControlBakeBooker.Controls.Add(this.tabPageClientes);
            this.tabControlBakeBooker.Controls.Add(this.tabPageEmpleados);
            this.tabControlBakeBooker.Controls.Add(this.tabPageProductos);
            this.tabControlBakeBooker.Controls.Add(this.tabPageProovedores);
            this.tabControlBakeBooker.Controls.Add(this.tabPagePedidos);
            this.tabControlBakeBooker.Controls.Add(this.tabPageDetallePedidos);
            this.tabControlBakeBooker.Controls.Add(this.tabPageInventario);
            this.tabControlBakeBooker.Location = new System.Drawing.Point(8, 66);
            this.tabControlBakeBooker.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlBakeBooker.Name = "tabControlBakeBooker";
            this.tabControlBakeBooker.SelectedIndex = 0;
            this.tabControlBakeBooker.Size = new System.Drawing.Size(776, 353);
            this.tabControlBakeBooker.TabIndex = 0;
            this.tabControlBakeBooker.SelectedIndexChanged += new System.EventHandler(this.tabControlBakeBooker_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 438);
            this.Controls.Add(this.tabControlBakeBooker);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(812, 477);
            this.MinimumSize = new System.Drawing.Size(812, 477);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.VisibleChanged += new System.EventHandler(this.Form2_VisibleChanged);
            this.tabPageInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.tabPageDetallePedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido_detalles)).EndInit();
            this.tabPagePedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabPageProovedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProovedores)).EndInit();
            this.tabPageProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabPageEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tabPageClientes.ResumeLayout(false);
            this.tabPageClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabControlBakeBooker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.TabPage tabPageDetallePedidos;
        private System.Windows.Forms.DataGridView dgvPedido_detalles;
        private System.Windows.Forms.TabPage tabPagePedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TabPage tabPageProovedores;
        private System.Windows.Forms.DataGridView dgvProovedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROOVEDOR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PROOVEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO_ELECTRONICO_P;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TabPage tabPageEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TabPage tabPageClientes;
        private System.Windows.Forms.Button btnBuscar_C;
        private System.Windows.Forms.Button btnModificar_C;
        private System.Windows.Forms.Button btnEliminar_C;
        private System.Windows.Forms.Button btnInsertar_C;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_A_Paterno_C;
        private System.Windows.Forms.Label lblCliente_ID_C;
        private System.Windows.Forms.TextBox txt_Fecha_Alta_C;
        private System.Windows.Forms.TextBox txt_Codigo_Postal_C;
        private System.Windows.Forms.TextBox txt_Colonia_C;
        private System.Windows.Forms.TextBox txt_Direccion_C;
        private System.Windows.Forms.TextBox txtCorreo_Electronico_C;
        private System.Windows.Forms.TextBox txtRfc_C;
        private System.Windows.Forms.TextBox txtTelefono_C;
        private System.Windows.Forms.TextBox txtNombre_C;
        private System.Windows.Forms.TextBox txtA_Materno_C;
        private System.Windows.Forms.TextBox txtA_Paterno_C;
        private System.Windows.Forms.TextBox txtCliente_ID_C;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabControl tabControlBakeBooker;
    }
}