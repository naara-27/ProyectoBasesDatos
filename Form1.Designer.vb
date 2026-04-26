<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnInsertarCliente = New System.Windows.Forms.Button()
        Me.btnActualizarCliente = New System.Windows.Forms.Button()
        Me.btnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTelefonoCliente = New System.Windows.Forms.Label()
        Me.btnSeleccionarProducto = New System.Windows.Forms.Button()
        Me.btnActualizarProducto = New System.Windows.Forms.Button()
        Me.btnInsertarProducto = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.btnBorrarProducto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBorrarProveedor = New System.Windows.Forms.Button()
        Me.btnSeleccionarProveedor = New System.Windows.Forms.Button()
        Me.btnActualizarProveedor = New System.Windows.Forms.Button()
        Me.btnInsertarProveedor = New System.Windows.Forms.Button()
        Me.lblTelefonoProveedor = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.txtTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1096, 607)
        Me.DataGridView1.TabIndex = 0
        '
        'btnInsertarCliente
        '
        Me.btnInsertarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarCliente.Location = New System.Drawing.Point(914, 16)
        Me.btnInsertarCliente.Name = "btnInsertarCliente"
        Me.btnInsertarCliente.Size = New System.Drawing.Size(120, 28)
        Me.btnInsertarCliente.TabIndex = 3
        Me.btnInsertarCliente.Text = "Insertar&"
        Me.btnInsertarCliente.UseVisualStyleBackColor = True
        '
        'btnActualizarCliente
        '
        Me.btnActualizarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarCliente.Location = New System.Drawing.Point(914, 85)
        Me.btnActualizarCliente.Name = "btnActualizarCliente"
        Me.btnActualizarCliente.Size = New System.Drawing.Size(120, 28)
        Me.btnActualizarCliente.TabIndex = 4
        Me.btnActualizarCliente.Text = "Actualizar&"
        Me.btnActualizarCliente.UseVisualStyleBackColor = True
        '
        'btnSeleccionarCliente
        '
        Me.btnSeleccionarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCliente.Location = New System.Drawing.Point(914, 51)
        Me.btnSeleccionarCliente.Name = "btnSeleccionarCliente"
        Me.btnSeleccionarCliente.Size = New System.Drawing.Size(120, 28)
        Me.btnSeleccionarCliente.TabIndex = 5
        Me.btnSeleccionarCliente.Text = "Seleccionar"
        Me.btnSeleccionarCliente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblTelefonoCliente)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoCliente)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarCliente)
        Me.GroupBox1.Controls.Add(Me.btnActualizarCliente)
        Me.GroupBox1.Controls.Add(Me.btnInsertarCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1078, 191)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBorrarProducto)
        Me.GroupBox2.Controls.Add(Me.lblPrecio)
        Me.GroupBox2.Controls.Add(Me.lblProducto)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.txtProducto)
        Me.GroupBox2.Controls.Add(Me.btnSeleccionarProducto)
        Me.GroupBox2.Controls.Add(Me.btnActualizarProducto)
        Me.GroupBox2.Controls.Add(Me.btnInsertarProducto)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1078, 176)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTelefonoProveedor)
        Me.GroupBox3.Controls.Add(Me.lblProveedor)
        Me.GroupBox3.Controls.Add(Me.txtTelefonoProveedor)
        Me.GroupBox3.Controls.Add(Me.txtProveedor)
        Me.GroupBox3.Controls.Add(Me.btnBorrarProveedor)
        Me.GroupBox3.Controls.Add(Me.btnSeleccionarProveedor)
        Me.GroupBox3.Controls.Add(Me.btnActualizarProveedor)
        Me.GroupBox3.Controls.Add(Me.btnInsertarProveedor)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1078, 212)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(138, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(248, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.AcceptsTab = True
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(553, 48)
        Me.txtTelefonoCliente.MaxLength = 8
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(248, 20)
        Me.txtTelefonoCliente.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(38, 51)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(94, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre Completo:"
        '
        'lblTelefonoCliente
        '
        Me.lblTelefonoCliente.AutoSize = True
        Me.lblTelefonoCliente.Location = New System.Drawing.Point(495, 51)
        Me.lblTelefonoCliente.Name = "lblTelefonoCliente"
        Me.lblTelefonoCliente.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefonoCliente.TabIndex = 10
        Me.lblTelefonoCliente.Text = "Telefono:"
        '
        'btnSeleccionarProducto
        '
        Me.btnSeleccionarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProducto.Location = New System.Drawing.Point(914, 51)
        Me.btnSeleccionarProducto.Name = "btnSeleccionarProducto"
        Me.btnSeleccionarProducto.Size = New System.Drawing.Size(120, 28)
        Me.btnSeleccionarProducto.TabIndex = 8
        Me.btnSeleccionarProducto.Text = "Seleccionar"
        Me.btnSeleccionarProducto.UseVisualStyleBackColor = True
        '
        'btnActualizarProducto
        '
        Me.btnActualizarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarProducto.Location = New System.Drawing.Point(914, 85)
        Me.btnActualizarProducto.Name = "btnActualizarProducto"
        Me.btnActualizarProducto.Size = New System.Drawing.Size(120, 28)
        Me.btnActualizarProducto.TabIndex = 7
        Me.btnActualizarProducto.Text = "Actualizar&"
        Me.btnActualizarProducto.UseVisualStyleBackColor = True
        '
        'btnInsertarProducto
        '
        Me.btnInsertarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProducto.Location = New System.Drawing.Point(914, 17)
        Me.btnInsertarProducto.Name = "btnInsertarProducto"
        Me.btnInsertarProducto.Size = New System.Drawing.Size(120, 28)
        Me.btnInsertarProducto.TabIndex = 6
        Me.btnInsertarProducto.Text = "Insertar&"
        Me.btnInsertarProducto.UseVisualStyleBackColor = True
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(495, 69)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 14
        Me.lblPrecio.Text = "Precio:"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(38, 73)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(113, 13)
        Me.lblProducto.TabIndex = 13
        Me.lblProducto.Text = "Nombre del Producto: "
        '
        'txtPrecio
        '
        Me.txtPrecio.AcceptsTab = True
        Me.txtPrecio.Location = New System.Drawing.Point(541, 69)
        Me.txtPrecio.MaxLength = 8
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(248, 20)
        Me.txtPrecio.TabIndex = 12
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(157, 73)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(248, 20)
        Me.txtProducto.TabIndex = 11
        '
        'btnBorrarProducto
        '
        Me.btnBorrarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarProducto.Location = New System.Drawing.Point(914, 119)
        Me.btnBorrarProducto.Name = "btnBorrarProducto"
        Me.btnBorrarProducto.Size = New System.Drawing.Size(120, 28)
        Me.btnBorrarProducto.TabIndex = 15
        Me.btnBorrarProducto.Text = "Borrar"
        Me.btnBorrarProducto.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(914, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 28)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBorrarProveedor
        '
        Me.btnBorrarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarProveedor.Location = New System.Drawing.Point(914, 131)
        Me.btnBorrarProveedor.Name = "btnBorrarProveedor"
        Me.btnBorrarProveedor.Size = New System.Drawing.Size(120, 28)
        Me.btnBorrarProveedor.TabIndex = 20
        Me.btnBorrarProveedor.Text = "Borrar"
        Me.btnBorrarProveedor.UseVisualStyleBackColor = True
        '
        'btnSeleccionarProveedor
        '
        Me.btnSeleccionarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarProveedor.Location = New System.Drawing.Point(914, 63)
        Me.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor"
        Me.btnSeleccionarProveedor.Size = New System.Drawing.Size(120, 28)
        Me.btnSeleccionarProveedor.TabIndex = 19
        Me.btnSeleccionarProveedor.Text = "Seleccionar"
        Me.btnSeleccionarProveedor.UseVisualStyleBackColor = True
        '
        'btnActualizarProveedor
        '
        Me.btnActualizarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarProveedor.Location = New System.Drawing.Point(914, 97)
        Me.btnActualizarProveedor.Name = "btnActualizarProveedor"
        Me.btnActualizarProveedor.Size = New System.Drawing.Size(120, 28)
        Me.btnActualizarProveedor.TabIndex = 18
        Me.btnActualizarProveedor.Text = "Actualizar&"
        Me.btnActualizarProveedor.UseVisualStyleBackColor = True
        '
        'btnInsertarProveedor
        '
        Me.btnInsertarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProveedor.Location = New System.Drawing.Point(914, 29)
        Me.btnInsertarProveedor.Name = "btnInsertarProveedor"
        Me.btnInsertarProveedor.Size = New System.Drawing.Size(120, 28)
        Me.btnInsertarProveedor.TabIndex = 17
        Me.btnInsertarProveedor.Text = "Insertar&"
        Me.btnInsertarProveedor.UseVisualStyleBackColor = True
        '
        'lblTelefonoProveedor
        '
        Me.lblTelefonoProveedor.AutoSize = True
        Me.lblTelefonoProveedor.Location = New System.Drawing.Point(495, 48)
        Me.lblTelefonoProveedor.Name = "lblTelefonoProveedor"
        Me.lblTelefonoProveedor.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefonoProveedor.TabIndex = 24
        Me.lblTelefonoProveedor.Text = "Telefono:"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(38, 48)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(113, 13)
        Me.lblProveedor.TabIndex = 23
        Me.lblProveedor.Text = "Nombre del Proveedor"
        '
        'txtTelefonoProveedor
        '
        Me.txtTelefonoProveedor.AcceptsTab = True
        Me.txtTelefonoProveedor.Location = New System.Drawing.Point(553, 45)
        Me.txtTelefonoProveedor.MaxLength = 8
        Me.txtTelefonoProveedor.Name = "txtTelefonoProveedor"
        Me.txtTelefonoProveedor.Size = New System.Drawing.Size(248, 20)
        Me.txtTelefonoProveedor.TabIndex = 22
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(157, 45)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(248, 20)
        Me.txtProveedor.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1120, 633)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBorrarProducto As Button
    Friend WithEvents lblTelefonoProveedor As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents txtTelefonoProveedor As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents btnBorrarProveedor As Button
    Friend WithEvents btnSeleccionarProveedor As Button
    Friend WithEvents btnActualizarProveedor As Button
    Friend WithEvents btnInsertarProveedor As Button
End Class
