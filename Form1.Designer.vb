<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnInsertarCliente = New System.Windows.Forms.Button()
        Me.btnActualizarCliente = New System.Windows.Forms.Button()
        Me.btnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBorrarCliente = New System.Windows.Forms.Button()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBorrarProducto = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarProducto = New System.Windows.Forms.Button()
        Me.btnActualizarProducto = New System.Windows.Forms.Button()
        Me.btnInsertarProducto = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTelefonoProveedor = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.txtTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.btnBorrarProveedor = New System.Windows.Forms.Button()
        Me.btnSeleccionarProveedor = New System.Windows.Forms.Button()
        Me.btnActualizarProveedor = New System.Windows.Forms.Button()
        Me.btnInsertarProveedor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 35)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1644, 934)
        Me.DataGridView1.TabIndex = 0
        '
        'btnInsertarCliente
        '
        Me.btnInsertarCliente.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnInsertarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarCliente.Location = New System.Drawing.Point(1371, 25)
        Me.btnInsertarCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInsertarCliente.Name = "btnInsertarCliente"
        Me.btnInsertarCliente.Size = New System.Drawing.Size(180, 43)
        Me.btnInsertarCliente.TabIndex = 3
        Me.btnInsertarCliente.Text = "Insertar&"
        Me.btnInsertarCliente.UseVisualStyleBackColor = False
        '
        'btnActualizarCliente
        '
        Me.btnActualizarCliente.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnActualizarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarCliente.Location = New System.Drawing.Point(1371, 131)
        Me.btnActualizarCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActualizarCliente.Name = "btnActualizarCliente"
        Me.btnActualizarCliente.Size = New System.Drawing.Size(180, 43)
        Me.btnActualizarCliente.TabIndex = 4
        Me.btnActualizarCliente.Text = "Actualizar&"
        Me.btnActualizarCliente.UseVisualStyleBackColor = False
        '
        'btnSeleccionarCliente
        '
        Me.btnSeleccionarCliente.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSeleccionarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCliente.Location = New System.Drawing.Point(1371, 78)
        Me.btnSeleccionarCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSeleccionarCliente.Name = "btnSeleccionarCliente"
        Me.btnSeleccionarCliente.Size = New System.Drawing.Size(180, 43)
        Me.btnSeleccionarCliente.TabIndex = 5
        Me.btnSeleccionarCliente.Text = "Seleccionar"
        Me.btnSeleccionarCliente.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox1.Controls.Add(Me.btnBorrarCliente)
        Me.GroupBox1.Controls.Add(Me.lblTelefonoCliente)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoCliente)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarCliente)
        Me.GroupBox1.Controls.Add(Me.btnActualizarCliente)
        Me.GroupBox1.Controls.Add(Me.btnInsertarCliente)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Peru
        Me.GroupBox1.Location = New System.Drawing.Point(28, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1617, 294)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'btnBorrarCliente
        '
        Me.btnBorrarCliente.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnBorrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarCliente.Location = New System.Drawing.Point(1371, 183)
        Me.btnBorrarCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBorrarCliente.Name = "btnBorrarCliente"
        Me.btnBorrarCliente.Size = New System.Drawing.Size(180, 43)
        Me.btnBorrarCliente.TabIndex = 16
        Me.btnBorrarCliente.Text = "Borrar"
        Me.btnBorrarCliente.UseVisualStyleBackColor = False
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.ForeColor = System.Drawing.Color.Peru
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(742, 78)
        Me.lblTelefonoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefonoCliente.TabIndex = 10
        Me.lblTelefonoCliente.Text = "Telefono:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.Color.Peru
        Me.lblNombre.Location = New System.Drawing.Point(57, 78)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(141, 20)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre Completo:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.AcceptsTab = True
        Me.txtTelefonoCliente.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(830, 74)
        Me.txtTelefonoCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefonoCliente.MaxLength = 8
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(370, 26)
        Me.txtTelefonoCliente.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtNombre.Location = New System.Drawing.Point(207, 74)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(370, 26)
        Me.txtNombre.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 291)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox2.Controls.Add(Me.btnBorrarProducto)
        Me.GroupBox2.Controls.Add(Me.lblPrecio)
        Me.GroupBox2.Controls.Add(Me.lblProducto)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.txtProducto)
        Me.GroupBox2.Controls.Add(Me.btnSeleccionarProducto)
        Me.GroupBox2.Controls.Add(Me.btnActualizarProducto)
        Me.GroupBox2.Controls.Add(Me.btnInsertarProducto)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Peru
        Me.GroupBox2.Location = New System.Drawing.Point(28, 338)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1617, 271)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'btnBorrarProducto
        '
        Me.btnBorrarProducto.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnBorrarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarProducto.Location = New System.Drawing.Point(1371, 183)
        Me.btnBorrarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBorrarProducto.Name = "btnBorrarProducto"
        Me.btnBorrarProducto.Size = New System.Drawing.Size(180, 43)
        Me.btnBorrarProducto.TabIndex = 15
        Me.btnBorrarProducto.Text = "Borrar"
        Me.btnBorrarProducto.UseVisualStyleBackColor = False
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.ForeColor = System.Drawing.Color.Peru
        Me.lblPrecio.Location = New System.Drawing.Point(742, 106)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(57, 20)
        Me.lblPrecio.TabIndex = 14
        Me.lblPrecio.Text = "Precio:"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.ForeColor = System.Drawing.Color.Peru
        Me.lblProducto.Location = New System.Drawing.Point(57, 112)
        Me.lblProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(166, 20)
        Me.lblProducto.TabIndex = 13
        Me.lblProducto.Text = "Nombre del Producto: "
        '
        'txtPrecio
        '
        Me.txtPrecio.AcceptsTab = True
        Me.txtPrecio.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtPrecio.Location = New System.Drawing.Point(812, 106)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecio.MaxLength = 8
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(370, 26)
        Me.txtPrecio.TabIndex = 12
        '
        'txtProducto
        '
        Me.txtProducto.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtProducto.Location = New System.Drawing.Point(236, 112)
        Me.txtProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(370, 26)
        Me.txtProducto.TabIndex = 11
        '
        'btnSeleccionarProducto
        '
        Me.btnSeleccionarProducto.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSeleccionarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProducto.Location = New System.Drawing.Point(1371, 78)
        Me.btnSeleccionarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSeleccionarProducto.Name = "btnSeleccionarProducto"
        Me.btnSeleccionarProducto.Size = New System.Drawing.Size(180, 43)
        Me.btnSeleccionarProducto.TabIndex = 8
        Me.btnSeleccionarProducto.Text = "Seleccionar"
        Me.btnSeleccionarProducto.UseVisualStyleBackColor = False
        '
        'btnActualizarProducto
        '
        Me.btnActualizarProducto.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnActualizarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarProducto.Location = New System.Drawing.Point(1371, 131)
        Me.btnActualizarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActualizarProducto.Name = "btnActualizarProducto"
        Me.btnActualizarProducto.Size = New System.Drawing.Size(180, 43)
        Me.btnActualizarProducto.TabIndex = 7
        Me.btnActualizarProducto.Text = "Actualizar&"
        Me.btnActualizarProducto.UseVisualStyleBackColor = False
        '
        'btnInsertarProducto
        '
        Me.btnInsertarProducto.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnInsertarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProducto.Location = New System.Drawing.Point(1371, 26)
        Me.btnInsertarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInsertarProducto.Name = "btnInsertarProducto"
        Me.btnInsertarProducto.Size = New System.Drawing.Size(180, 43)
        Me.btnInsertarProducto.TabIndex = 6
        Me.btnInsertarProducto.Text = "Insertar&"
        Me.btnInsertarProducto.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.lblTelefonoProveedor)
        Me.GroupBox3.Controls.Add(Me.lblProveedor)
        Me.GroupBox3.Controls.Add(Me.txtTelefonoProveedor)
        Me.GroupBox3.Controls.Add(Me.txtProveedor)
        Me.GroupBox3.Controls.Add(Me.btnBorrarProveedor)
        Me.GroupBox3.Controls.Add(Me.btnSeleccionarProveedor)
        Me.GroupBox3.Controls.Add(Me.btnActualizarProveedor)
        Me.GroupBox3.Controls.Add(Me.btnInsertarProveedor)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Peru
        Me.GroupBox3.Location = New System.Drawing.Point(28, 618)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(1617, 326)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proveedor"
        '
        'lblTelefonoProveedor
        '
        Me.lblTelefonoProveedor.AutoSize = True
        Me.lblTelefonoProveedor.ForeColor = System.Drawing.Color.Peru
        Me.lblTelefonoProveedor.Location = New System.Drawing.Point(742, 74)
        Me.lblTelefonoProveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefonoProveedor.Name = "lblTelefonoProveedor"
        Me.lblTelefonoProveedor.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefonoProveedor.TabIndex = 24
        Me.lblTelefonoProveedor.Text = "Telefono:"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.ForeColor = System.Drawing.Color.Peru
        Me.lblProveedor.Location = New System.Drawing.Point(57, 74)
        Me.lblProveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(166, 20)
        Me.lblProveedor.TabIndex = 23
        Me.lblProveedor.Text = "Nombre del Proveedor"
        '
        'txtTelefonoProveedor
        '
        Me.txtTelefonoProveedor.AcceptsTab = True
        Me.txtTelefonoProveedor.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtTelefonoProveedor.Location = New System.Drawing.Point(830, 69)
        Me.txtTelefonoProveedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefonoProveedor.MaxLength = 8
        Me.txtTelefonoProveedor.Name = "txtTelefonoProveedor"
        Me.txtTelefonoProveedor.Size = New System.Drawing.Size(370, 26)
        Me.txtTelefonoProveedor.TabIndex = 22
        '
        'txtProveedor
        '
        Me.txtProveedor.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtProveedor.Location = New System.Drawing.Point(236, 69)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(370, 26)
        Me.txtProveedor.TabIndex = 21
        '
        'btnBorrarProveedor
        '
        Me.btnBorrarProveedor.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnBorrarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarProveedor.ForeColor = System.Drawing.Color.Peru
        Me.btnBorrarProveedor.Location = New System.Drawing.Point(1371, 202)
        Me.btnBorrarProveedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBorrarProveedor.Name = "btnBorrarProveedor"
        Me.btnBorrarProveedor.Size = New System.Drawing.Size(180, 43)
        Me.btnBorrarProveedor.TabIndex = 20
        Me.btnBorrarProveedor.Text = "Borrar"
        Me.btnBorrarProveedor.UseVisualStyleBackColor = False
        '
        'btnSeleccionarProveedor
        '
        Me.btnSeleccionarProveedor.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSeleccionarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProveedor.ForeColor = System.Drawing.Color.Peru
        Me.btnSeleccionarProveedor.Location = New System.Drawing.Point(1371, 97)
        Me.btnSeleccionarProveedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor"
        Me.btnSeleccionarProveedor.Size = New System.Drawing.Size(180, 43)
        Me.btnSeleccionarProveedor.TabIndex = 19
        Me.btnSeleccionarProveedor.Text = "Seleccionar"
        Me.btnSeleccionarProveedor.UseVisualStyleBackColor = False
        '
        'btnActualizarProveedor
        '
        Me.btnActualizarProveedor.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnActualizarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarProveedor.ForeColor = System.Drawing.Color.Peru
        Me.btnActualizarProveedor.Location = New System.Drawing.Point(1371, 149)
        Me.btnActualizarProveedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActualizarProveedor.Name = "btnActualizarProveedor"
        Me.btnActualizarProveedor.Size = New System.Drawing.Size(180, 43)
        Me.btnActualizarProveedor.TabIndex = 18
        Me.btnActualizarProveedor.Text = "Actualizar&"
        Me.btnActualizarProveedor.UseVisualStyleBackColor = False
        '
        'btnInsertarProveedor
        '
        Me.btnInsertarProveedor.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnInsertarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProveedor.ForeColor = System.Drawing.Color.Peru
        Me.btnInsertarProveedor.Location = New System.Drawing.Point(1371, 44)
        Me.btnInsertarProveedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInsertarProveedor.Name = "btnInsertarProveedor"
        Me.btnInsertarProveedor.Size = New System.Drawing.Size(180, 43)
        Me.btnInsertarProveedor.TabIndex = 17
        Me.btnInsertarProveedor.Text = "Insertar&"
        Me.btnInsertarProveedor.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ProyectoBasesDatos.My.Resources.Resources.pasteles21
        Me.PictureBox1.Location = New System.Drawing.Point(-142, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1469, 161)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1680, 974)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panadería Dulce Trigo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnInsertarCliente As Button
    Friend WithEvents btnActualizarCliente As Button
    Friend WithEvents btnSeleccionarCliente As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblTelefonoCliente As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnSeleccionarProducto As Button
    Friend WithEvents btnActualizarProducto As Button
    Friend WithEvents btnInsertarProducto As Button
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents btnBorrarCliente As Button
    Friend WithEvents btnBorrarProducto As Button
    Friend WithEvents lblTelefonoProveedor As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents txtTelefonoProveedor As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents btnBorrarProveedor As Button
    Friend WithEvents btnSeleccionarProveedor As Button
    Friend WithEvents btnActualizarProveedor As Button
    Friend WithEvents btnInsertarProveedor As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
