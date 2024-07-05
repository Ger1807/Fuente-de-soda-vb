<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        tbx_fecha = New TextBox()
        tbx_apellido = New TextBox()
        tbx_nombre = New TextBox()
        tbx_cedula = New TextBox()
        tbx_precio_item = New TextBox()
        btn_print = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Fecha = New Label()
        cb_nombre_item = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox8 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbx_fecha
        ' 
        tbx_fecha.Location = New Point(688, 27)
        tbx_fecha.Name = "tbx_fecha"
        tbx_fecha.Size = New Size(100, 23)
        tbx_fecha.TabIndex = 0
        ' 
        ' tbx_apellido
        ' 
        tbx_apellido.Location = New Point(195, 100)
        tbx_apellido.Name = "tbx_apellido"
        tbx_apellido.Size = New Size(100, 23)
        tbx_apellido.TabIndex = 1
        ' 
        ' tbx_nombre
        ' 
        tbx_nombre.Location = New Point(49, 100)
        tbx_nombre.Name = "tbx_nombre"
        tbx_nombre.Size = New Size(100, 23)
        tbx_nombre.TabIndex = 2
        ' 
        ' tbx_cedula
        ' 
        tbx_cedula.Location = New Point(124, 210)
        tbx_cedula.Name = "tbx_cedula"
        tbx_cedula.Size = New Size(100, 23)
        tbx_cedula.TabIndex = 3
        ' 
        ' tbx_precio_item
        ' 
        tbx_precio_item.Location = New Point(195, 151)
        tbx_precio_item.Name = "tbx_precio_item"
        tbx_precio_item.Size = New Size(100, 23)
        tbx_precio_item.TabIndex = 4
        ' 
        ' btn_print
        ' 
        btn_print.BackColor = Color.Transparent
        btn_print.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_print.ForeColor = Color.Yellow
        btn_print.Location = New Point(380, 353)
        btn_print.Name = "btn_print"
        btn_print.Size = New Size(75, 23)
        btn_print.TabIndex = 6
        btn_print.Text = "Facturar"
        btn_print.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label1.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(37, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 14)
        Label1.TabIndex = 7
        Label1.Text = "Nombre del Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label2.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(185, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 14)
        Label2.TabIndex = 8
        Label2.Text = "Apellido del Cliente"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label3.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(68, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 14)
        Label3.TabIndex = 9
        Label3.Text = "Producto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label4.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(224, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 14)
        Label4.TabIndex = 10
        Label4.Text = "Precio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label5.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(110, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 14)
        Label5.TabIndex = 11
        Label5.Text = "Cedula del Cliente"
        ' 
        ' Fecha
        ' 
        Fecha.AutoSize = True
        Fecha.BackColor = Color.Navy
        Fecha.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Fecha.ForeColor = Color.White
        Fecha.Location = New Point(683, 10)
        Fecha.Name = "Fecha"
        Fecha.Size = New Size(112, 14)
        Fecha.TabIndex = 12
        Fecha.Text = "Fecha(dd/mm/aa)"
        ' 
        ' cb_nombre_item
        ' 
        cb_nombre_item.DropDownStyle = ComboBoxStyle.DropDownList
        cb_nombre_item.FormattingEnabled = True
        cb_nombre_item.Items.AddRange(New Object() {"Coca-Cola", "Pepsi", "Nestea", "Cotufas", "Doritos", "Tequeños"})
        cb_nombre_item.Location = New Point(40, 151)
        cb_nombre_item.Name = "cb_nombre_item"
        cb_nombre_item.Size = New Size(121, 23)
        cb_nombre_item.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(503, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 15)
        Label6.TabIndex = 14
        Label6.Text = "30 Bs."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(592, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 15)
        Label7.TabIndex = 15
        Label7.Text = "12 Bs."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(678, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(37, 15)
        Label8.TabIndex = 16
        Label8.Text = "25 Bs."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.White
        Label9.Location = New Point(503, 304)
        Label9.Name = "Label9"
        Label9.Size = New Size(37, 15)
        Label9.TabIndex = 17
        Label9.Text = "25 Bs."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.White
        Label10.Location = New Point(592, 304)
        Label10.Name = "Label10"
        Label10.Size = New Size(37, 15)
        Label10.TabIndex = 18
        Label10.Text = "20 Bs."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.White
        Label11.Location = New Point(678, 304)
        Label11.Name = "Label11"
        Label11.Size = New Size(37, 15)
        Label11.TabIndex = 19
        Label11.Text = "15 Bs."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(482, 82)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(73, 99)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(571, 82)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(73, 99)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(658, 82)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(73, 99)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 22
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(482, 202)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(73, 99)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 23
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(571, 202)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(73, 99)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 24
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(658, 202)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(73, 99)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 25
        PictureBox6.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(31, 9)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(193, 50)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 27
        PictureBox8.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(cb_nombre_item)
        Controls.Add(Fecha)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_print)
        Controls.Add(tbx_precio_item)
        Controls.Add(tbx_cedula)
        Controls.Add(tbx_nombre)
        Controls.Add(tbx_apellido)
        Controls.Add(tbx_fecha)
        Name = "Form1"
        Text = "Fuente de Soda(Cinex)"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbx_fecha As TextBox
    Friend WithEvents tbx_apellido As TextBox
    Friend WithEvents tbx_nombre As TextBox
    Friend WithEvents tbx_cedula As TextBox
    Friend WithEvents tbx_precio_item As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btn_print As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Fecha As Label
    Protected WithEvents cb_nombre_item As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox

End Class
