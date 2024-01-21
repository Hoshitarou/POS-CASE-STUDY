<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.lblcashiername = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lblbrand = New Guna.UI.WinForms.GunaLabel()
        Me.lblPOS = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btncancel = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnsave = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnpay = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnremove = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.btnAddToCart = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lbltime = New Guna.UI.WinForms.GunaLabel()
        Me.lbldate = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.lblTransNo = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.cboDiscount = New System.Windows.Forms.ComboBox()
        Me.lblDisc = New Guna.UI.WinForms.GunaLabel()
        Me.lblVsale = New Guna.UI.WinForms.GunaLabel()
        Me.lblVAT = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel30 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel29 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel28 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel27 = New Guna.UI.WinForms.GunaLabel()
        Me.lblRefnum = New Guna.UI.WinForms.GunaLabel()
        Me.lblMOP = New Guna.UI.WinForms.GunaLabel()
        Me.lblChange = New Guna.UI.WinForms.GunaLabel()
        Me.lblAmountPaid = New Guna.UI.WinForms.GunaLabel()
        Me.lbltotalprod = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel21 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel19 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel18 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel17 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblgtotal = New System.Windows.Forms.Label()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.txtCritlevel = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtProdCode = New System.Windows.Forms.TextBox()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblStatus = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.lblcashiername)
        Me.GunaPanel1.Controls.Add(Me.GunaCirclePictureBox2)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Controls.Add(Me.lblbrand)
        Me.GunaPanel1.Controls.Add(Me.lblPOS)
        Me.GunaPanel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1223, 70)
        Me.GunaPanel1.TabIndex = 0
        '
        'lblcashiername
        '
        Me.lblcashiername.AutoSize = True
        Me.lblcashiername.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcashiername.Location = New System.Drawing.Point(1036, 41)
        Me.lblcashiername.Name = "lblcashiername"
        Me.lblcashiername.Size = New System.Drawing.Size(130, 22)
        Me.lblcashiername.TabIndex = 5
        Me.lblcashiername.Text = "--------------------"
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(1174, 14)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(37, 32)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 4
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(1036, 14)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(122, 21)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Cashier name:"
        '
        'lblbrand
        '
        Me.lblbrand.AutoSize = True
        Me.lblbrand.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbrand.Location = New System.Drawing.Point(104, 41)
        Me.lblbrand.Name = "lblbrand"
        Me.lblbrand.Size = New System.Drawing.Size(274, 17)
        Me.lblbrand.TabIndex = 2
        Me.lblbrand.Text = "DOMG the anime merch and brand store" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPOS
        '
        Me.lblPOS.AutoSize = True
        Me.lblPOS.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOS.Location = New System.Drawing.Point(90, 9)
        Me.lblPOS.Name = "lblPOS"
        Me.lblPOS.Size = New System.Drawing.Size(305, 32)
        Me.lblPOS.TabIndex = 1
        Me.lblPOS.Text = "POINT OF SALE SYSTEM"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(72, 64)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 0
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnpay)
        Me.Panel1.Controls.Add(Me.btnremove)
        Me.Panel1.Controls.Add(Me.btnAddToCart)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 579)
        Me.Panel1.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.AnimationHoverSpeed = 0.07!
        Me.btnLogout.AnimationSpeed = 0.03!
        Me.btnLogout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnLogout.BorderColor = System.Drawing.Color.Black
        Me.btnLogout.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnLogout.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnLogout.CheckedForeColor = System.Drawing.Color.White
        Me.btnLogout.CheckedImage = CType(resources.GetObject("btnLogout.CheckedImage"), System.Drawing.Image)
        Me.btnLogout.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogout.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogout.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(12, 533)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogout.OnHoverImage = Nothing
        Me.btnLogout.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnLogout.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogout.Size = New System.Drawing.Size(111, 31)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log Out"
        '
        'btncancel
        '
        Me.btncancel.Animated = True
        Me.btncancel.AnimationHoverSpeed = 0.07!
        Me.btncancel.AnimationSpeed = 0.03!
        Me.btncancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btncancel.BorderColor = System.Drawing.Color.Black
        Me.btncancel.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btncancel.CheckedBorderColor = System.Drawing.Color.Black
        Me.btncancel.CheckedForeColor = System.Drawing.Color.White
        Me.btncancel.CheckedImage = CType(resources.GetObject("btncancel.CheckedImage"), System.Drawing.Image)
        Me.btncancel.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btncancel.FocusedColor = System.Drawing.Color.Empty
        Me.btncancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageSize = New System.Drawing.Size(52, 52)
        Me.btncancel.LineColor = System.Drawing.Color.Transparent
        Me.btncancel.Location = New System.Drawing.Point(12, 399)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btncancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btncancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btncancel.OnHoverImage = Nothing
        Me.btncancel.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btncancel.OnPressedColor = System.Drawing.Color.Black
        Me.btncancel.Size = New System.Drawing.Size(97, 100)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "Cancel"
        '
        'btnsave
        '
        Me.btnsave.Animated = True
        Me.btnsave.AnimationHoverSpeed = 0.07!
        Me.btnsave.AnimationSpeed = 0.03!
        Me.btnsave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnsave.BorderColor = System.Drawing.Color.Black
        Me.btnsave.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnsave.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnsave.CheckedForeColor = System.Drawing.Color.White
        Me.btnsave.CheckedImage = CType(resources.GetObject("btnsave.CheckedImage"), System.Drawing.Image)
        Me.btnsave.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnsave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsave.FocusedColor = System.Drawing.Color.Empty
        Me.btnsave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnsave.LineColor = System.Drawing.Color.Transparent
        Me.btnsave.Location = New System.Drawing.Point(12, 293)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsave.OnHoverImage = Nothing
        Me.btnsave.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnsave.OnPressedColor = System.Drawing.Color.Black
        Me.btnsave.Size = New System.Drawing.Size(97, 100)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "Save"
        '
        'btnpay
        '
        Me.btnpay.Animated = True
        Me.btnpay.AnimationHoverSpeed = 0.07!
        Me.btnpay.AnimationSpeed = 0.03!
        Me.btnpay.BaseColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnpay.BorderColor = System.Drawing.Color.Black
        Me.btnpay.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnpay.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnpay.CheckedForeColor = System.Drawing.Color.White
        Me.btnpay.CheckedImage = CType(resources.GetObject("btnpay.CheckedImage"), System.Drawing.Image)
        Me.btnpay.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnpay.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnpay.FocusedColor = System.Drawing.Color.Empty
        Me.btnpay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpay.ForeColor = System.Drawing.Color.White
        Me.btnpay.Image = CType(resources.GetObject("btnpay.Image"), System.Drawing.Image)
        Me.btnpay.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnpay.LineColor = System.Drawing.Color.Transparent
        Me.btnpay.Location = New System.Drawing.Point(12, 187)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnpay.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnpay.OnHoverForeColor = System.Drawing.Color.White
        Me.btnpay.OnHoverImage = Nothing
        Me.btnpay.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnpay.OnPressedColor = System.Drawing.Color.Black
        Me.btnpay.Size = New System.Drawing.Size(97, 100)
        Me.btnpay.TabIndex = 7
        Me.btnpay.Text = "Payment"
        '
        'btnremove
        '
        Me.btnremove.Animated = True
        Me.btnremove.AnimationHoverSpeed = 0.07!
        Me.btnremove.AnimationSpeed = 0.03!
        Me.btnremove.BaseColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnremove.BorderColor = System.Drawing.Color.Black
        Me.btnremove.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnremove.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnremove.CheckedForeColor = System.Drawing.Color.White
        Me.btnremove.CheckedImage = CType(resources.GetObject("btnremove.CheckedImage"), System.Drawing.Image)
        Me.btnremove.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnremove.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnremove.FocusedColor = System.Drawing.Color.Empty
        Me.btnremove.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.ForeColor = System.Drawing.Color.White
        Me.btnremove.Image = CType(resources.GetObject("btnremove.Image"), System.Drawing.Image)
        Me.btnremove.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnremove.LineColor = System.Drawing.Color.Transparent
        Me.btnremove.Location = New System.Drawing.Point(12, 97)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnremove.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnremove.OnHoverForeColor = System.Drawing.Color.White
        Me.btnremove.OnHoverImage = Nothing
        Me.btnremove.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnremove.OnPressedColor = System.Drawing.Color.Black
        Me.btnremove.Size = New System.Drawing.Size(97, 84)
        Me.btnremove.TabIndex = 6
        Me.btnremove.Text = "Remove"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Animated = True
        Me.btnAddToCart.AnimationHoverSpeed = 0.07!
        Me.btnAddToCart.AnimationSpeed = 0.03!
        Me.btnAddToCart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnAddToCart.BorderColor = System.Drawing.Color.Black
        Me.btnAddToCart.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAddToCart.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAddToCart.CheckedForeColor = System.Drawing.Color.White
        Me.btnAddToCart.CheckedImage = CType(resources.GetObject("btnAddToCart.CheckedImage"), System.Drawing.Image)
        Me.btnAddToCart.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnAddToCart.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddToCart.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddToCart.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.ForeColor = System.Drawing.Color.White
        Me.btnAddToCart.Image = CType(resources.GetObject("btnAddToCart.Image"), System.Drawing.Image)
        Me.btnAddToCart.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnAddToCart.LineColor = System.Drawing.Color.Transparent
        Me.btnAddToCart.Location = New System.Drawing.Point(12, 6)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnAddToCart.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddToCart.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddToCart.OnHoverImage = Nothing
        Me.btnAddToCart.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAddToCart.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddToCart.Size = New System.Drawing.Size(97, 86)
        Me.btnAddToCart.TabIndex = 5
        Me.btnAddToCart.Text = "Add to Cart"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 3
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.lbltime)
        Me.GunaElipsePanel1.Controls.Add(Me.lbldate)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaElipsePanel1.Controls.Add(Me.lblTransNo)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(866, 76)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 15
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(345, 157)
        Me.GunaElipsePanel1.TabIndex = 2
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(170, 109)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(64, 22)
        Me.lbltime.TabIndex = 9
        Me.lbltime.Text = "******"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(26, 109)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(64, 22)
        Me.lbldate.TabIndex = 8
        Me.lbldate.Text = "******"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(26, 77)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(155, 22)
        Me.GunaLabel5.TabIndex = 7
        Me.GunaLabel5.Text = "DATE AND TIME:"
        '
        'lblTransNo
        '
        Me.lblTransNo.AutoSize = True
        Me.lblTransNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransNo.Location = New System.Drawing.Point(26, 39)
        Me.lblTransNo.Name = "lblTransNo"
        Me.lblTransNo.Size = New System.Drawing.Size(87, 22)
        Me.lblTransNo.TabIndex = 6
        Me.lblTransNo.Text = "1000000"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(20, 15)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(228, 22)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "TRANSACTION NUMBER:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.cboDiscount)
        Me.GunaElipsePanel2.Controls.Add(Me.lblDisc)
        Me.GunaElipsePanel2.Controls.Add(Me.lblVsale)
        Me.GunaElipsePanel2.Controls.Add(Me.lblVAT)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel30)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel29)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel28)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel27)
        Me.GunaElipsePanel2.Controls.Add(Me.lblRefnum)
        Me.GunaElipsePanel2.Controls.Add(Me.lblMOP)
        Me.GunaElipsePanel2.Controls.Add(Me.lblChange)
        Me.GunaElipsePanel2.Controls.Add(Me.lblAmountPaid)
        Me.GunaElipsePanel2.Controls.Add(Me.lbltotalprod)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel21)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel20)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel19)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel18)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel17)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(866, 239)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 15
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(345, 276)
        Me.GunaElipsePanel2.TabIndex = 3
        '
        'cboDiscount
        '
        Me.cboDiscount.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiscount.FormattingEnabled = True
        Me.cboDiscount.Items.AddRange(New Object() {"Senior Citizen ", "PWD"})
        Me.cboDiscount.Location = New System.Drawing.Point(167, 243)
        Me.cboDiscount.Name = "cboDiscount"
        Me.cboDiscount.Size = New System.Drawing.Size(100, 22)
        Me.cboDiscount.TabIndex = 26
        '
        'lblDisc
        '
        Me.lblDisc.AutoSize = True
        Me.lblDisc.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisc.Location = New System.Drawing.Point(171, 220)
        Me.lblDisc.Name = "lblDisc"
        Me.lblDisc.Size = New System.Drawing.Size(28, 16)
        Me.lblDisc.TabIndex = 25
        Me.lblDisc.Text = "0.00"
        '
        'lblVsale
        '
        Me.lblVsale.AutoSize = True
        Me.lblVsale.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVsale.Location = New System.Drawing.Point(171, 198)
        Me.lblVsale.Name = "lblVsale"
        Me.lblVsale.Size = New System.Drawing.Size(28, 16)
        Me.lblVsale.TabIndex = 24
        Me.lblVsale.Text = "0.00"
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.Location = New System.Drawing.Point(171, 174)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(28, 16)
        Me.lblVAT.TabIndex = 23
        Me.lblVAT.Text = "0.00"
        '
        'GunaLabel30
        '
        Me.GunaLabel30.AutoSize = True
        Me.GunaLabel30.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel30.Location = New System.Drawing.Point(13, 245)
        Me.GunaLabel30.Name = "GunaLabel30"
        Me.GunaLabel30.Size = New System.Drawing.Size(89, 16)
        Me.GunaLabel30.TabIndex = 22
        Me.GunaLabel30.Text = "Discount Types:"
        '
        'GunaLabel29
        '
        Me.GunaLabel29.AutoSize = True
        Me.GunaLabel29.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel29.Location = New System.Drawing.Point(13, 220)
        Me.GunaLabel29.Name = "GunaLabel29"
        Me.GunaLabel29.Size = New System.Drawing.Size(56, 16)
        Me.GunaLabel29.TabIndex = 21
        Me.GunaLabel29.Text = "Discount:"
        '
        'GunaLabel28
        '
        Me.GunaLabel28.AutoSize = True
        Me.GunaLabel28.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel28.Location = New System.Drawing.Point(13, 198)
        Me.GunaLabel28.Name = "GunaLabel28"
        Me.GunaLabel28.Size = New System.Drawing.Size(74, 16)
        Me.GunaLabel28.TabIndex = 20
        Me.GunaLabel28.Text = "VAT Amount:"
        '
        'GunaLabel27
        '
        Me.GunaLabel27.AutoSize = True
        Me.GunaLabel27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel27.Location = New System.Drawing.Point(13, 174)
        Me.GunaLabel27.Name = "GunaLabel27"
        Me.GunaLabel27.Size = New System.Drawing.Size(84, 16)
        Me.GunaLabel27.TabIndex = 19
        Me.GunaLabel27.Text = "Vatable Sales:"
        '
        'lblRefnum
        '
        Me.lblRefnum.AutoSize = True
        Me.lblRefnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefnum.Location = New System.Drawing.Point(208, 140)
        Me.lblRefnum.Name = "lblRefnum"
        Me.lblRefnum.Size = New System.Drawing.Size(40, 21)
        Me.lblRefnum.TabIndex = 18
        Me.lblRefnum.Text = "*****"
        '
        'lblMOP
        '
        Me.lblMOP.AutoSize = True
        Me.lblMOP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMOP.Location = New System.Drawing.Point(208, 107)
        Me.lblMOP.Name = "lblMOP"
        Me.lblMOP.Size = New System.Drawing.Size(40, 21)
        Me.lblMOP.TabIndex = 17
        Me.lblMOP.Text = "*****"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(208, 75)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(41, 21)
        Me.lblChange.TabIndex = 16
        Me.lblChange.Text = "0.00"
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.Location = New System.Drawing.Point(208, 42)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(41, 21)
        Me.lblAmountPaid.TabIndex = 15
        Me.lblAmountPaid.Text = "0.00"
        '
        'lbltotalprod
        '
        Me.lbltotalprod.AutoSize = True
        Me.lbltotalprod.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalprod.Location = New System.Drawing.Point(208, 9)
        Me.lbltotalprod.Name = "lbltotalprod"
        Me.lbltotalprod.Size = New System.Drawing.Size(19, 21)
        Me.lbltotalprod.TabIndex = 14
        Me.lbltotalprod.Text = "0"
        '
        'GunaLabel21
        '
        Me.GunaLabel21.AutoSize = True
        Me.GunaLabel21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel21.Location = New System.Drawing.Point(12, 140)
        Me.GunaLabel21.Name = "GunaLabel21"
        Me.GunaLabel21.Size = New System.Drawing.Size(161, 21)
        Me.GunaLabel21.TabIndex = 13
        Me.GunaLabel21.Text = "Reference Number:"
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.Location = New System.Drawing.Point(12, 107)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(153, 21)
        Me.GunaLabel20.TabIndex = 12
        Me.GunaLabel20.Text = "Mode of Payment:"
        '
        'GunaLabel19
        '
        Me.GunaLabel19.AutoSize = True
        Me.GunaLabel19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel19.Location = New System.Drawing.Point(12, 75)
        Me.GunaLabel19.Name = "GunaLabel19"
        Me.GunaLabel19.Size = New System.Drawing.Size(148, 21)
        Me.GunaLabel19.TabIndex = 11
        Me.GunaLabel19.Text = "Amount Change:"
        '
        'GunaLabel18
        '
        Me.GunaLabel18.AutoSize = True
        Me.GunaLabel18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel18.Location = New System.Drawing.Point(12, 42)
        Me.GunaLabel18.Name = "GunaLabel18"
        Me.GunaLabel18.Size = New System.Drawing.Size(117, 21)
        Me.GunaLabel18.TabIndex = 10
        Me.GunaLabel18.Text = "Amount Paid:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLabel17
        '
        Me.GunaLabel17.AutoSize = True
        Me.GunaLabel17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel17.Location = New System.Drawing.Point(12, 9)
        Me.GunaLabel17.Name = "GunaLabel17"
        Me.GunaLabel17.Size = New System.Drawing.Size(173, 21)
        Me.GunaLabel17.TabIndex = 9
        Me.GunaLabel17.Text = "Total Product(s) Sold:"
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GunaElipsePanel3.Controls.Add(Me.lblgtotal)
        Me.GunaElipsePanel3.Controls.Add(Me.GunaLabel7)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(866, 521)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 15
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(345, 122)
        Me.GunaElipsePanel3.TabIndex = 4
        '
        'lblgtotal
        '
        Me.lblgtotal.AutoSize = True
        Me.lblgtotal.Font = New System.Drawing.Font("Century Gothic", 27.75!)
        Me.lblgtotal.Location = New System.Drawing.Point(142, 50)
        Me.lblgtotal.Name = "lblgtotal"
        Me.lblgtotal.Size = New System.Drawing.Size(92, 44)
        Me.lblgtotal.TabIndex = 10
        Me.lblgtotal.Text = "0.00"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(26, 15)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(158, 24)
        Me.GunaLabel7.TabIndex = 9
        Me.GunaLabel7.Text = "GRAND TOTAL:"
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GunaElipsePanel4.Controls.Add(Me.txtCritlevel)
        Me.GunaElipsePanel4.Controls.Add(Me.txtQuantity)
        Me.GunaElipsePanel4.Controls.Add(Me.txtAmount)
        Me.GunaElipsePanel4.Controls.Add(Me.txtProdName)
        Me.GunaElipsePanel4.Controls.Add(Me.txtProdCode)
        Me.GunaElipsePanel4.Controls.Add(Me.GunaLabel16)
        Me.GunaElipsePanel4.Controls.Add(Me.ListView1)
        Me.GunaElipsePanel4.Controls.Add(Me.lblStatus)
        Me.GunaElipsePanel4.Controls.Add(Me.GunaLabel14)
        Me.GunaElipsePanel4.Controls.Add(Me.GunaLabel13)
        Me.GunaElipsePanel4.Controls.Add(Me.GunaLabel12)
        Me.GunaElipsePanel4.Controls.Add(Me.GunaLabel11)
        Me.GunaElipsePanel4.Controls.Add(Me.GunaLabel10)
        Me.GunaElipsePanel4.Controls.Add(Me.GunaLabel9)
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(139, 76)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Radius = 10
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(714, 548)
        Me.GunaElipsePanel4.TabIndex = 5
        '
        'txtCritlevel
        '
        Me.txtCritlevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCritlevel.Location = New System.Drawing.Point(514, 38)
        Me.txtCritlevel.Name = "txtCritlevel"
        Me.txtCritlevel.ReadOnly = True
        Me.txtCritlevel.Size = New System.Drawing.Size(105, 22)
        Me.txtCritlevel.TabIndex = 22
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(434, 38)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(74, 22)
        Me.txtQuantity.TabIndex = 21
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(358, 38)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(74, 22)
        Me.txtAmount.TabIndex = 20
        '
        'txtProdName
        '
        Me.txtProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdName.Location = New System.Drawing.Point(170, 38)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(182, 22)
        Me.txtProdName.TabIndex = 19
        '
        'txtProdCode
        '
        Me.txtProdCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdCode.Location = New System.Drawing.Point(9, 38)
        Me.txtProdCode.Name = "txtProdCode"
        Me.txtProdCode.Size = New System.Drawing.Size(151, 22)
        Me.txtProdCode.TabIndex = 18
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.Location = New System.Drawing.Point(5, 77)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(58, 21)
        Me.GunaLabel16.TabIndex = 17
        Me.GunaLabel16.Text = "CART:"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Snow
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(9, 101)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(698, 438)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Code"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Amount"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Quantity"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sub Total"
        Me.ColumnHeader5.Width = 100
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(629, 39)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(44, 17)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "******"
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.Location = New System.Drawing.Point(629, 10)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(63, 21)
        Me.GunaLabel14.TabIndex = 14
        Me.GunaLabel14.Text = "Status:"
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.Location = New System.Drawing.Point(510, 10)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(113, 21)
        Me.GunaLabel13.TabIndex = 12
        Me.GunaLabel13.Text = "Critical Level:"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.Location = New System.Drawing.Point(430, 10)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(80, 21)
        Me.GunaLabel12.TabIndex = 10
        Me.GunaLabel12.Text = "Quantity"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(353, 10)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(79, 21)
        Me.GunaLabel11.TabIndex = 8
        Me.GunaLabel11.Text = "Amount:"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(166, 10)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(128, 21)
        Me.GunaLabel10.TabIndex = 6
        Me.GunaLabel10.Text = "Product Name:"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(5, 10)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(124, 21)
        Me.GunaLabel9.TabIndex = 4
        Me.GunaLabel9.Text = "Product Code:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1223, 649)
        Me.Controls.Add(Me.GunaElipsePanel4)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        Me.GunaElipsePanel4.ResumeLayout(False)
        Me.GunaElipsePanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPOS As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblbrand As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblcashiername As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblTransNo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbldate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnAddToCart As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btncancel As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnsave As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnpay As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnremove As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents btnLogout As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblStatus As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel18 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblRefnum As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblMOP As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblChange As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblAmountPaid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbltotalprod As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel30 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel29 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel28 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel27 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel21 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cboDiscount As ComboBox
    Friend WithEvents lblDisc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblVsale As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblVAT As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtCritlevel As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtProdCode As TextBox
    Friend WithEvents lbltime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblgtotal As Label
End Class
