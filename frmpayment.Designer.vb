<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayment
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
        Me.btnpay = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.cboMOP = New System.Windows.Forms.ComboBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.txtpaid = New System.Windows.Forms.TextBox()
        Me.lblChange = New Guna.UI.WinForms.GunaLabel()
        Me.btnplus = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnpay
        '
        Me.btnpay.Animated = True
        Me.btnpay.AnimationHoverSpeed = 0.07!
        Me.btnpay.AnimationSpeed = 0.03!
        Me.btnpay.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnpay.BorderColor = System.Drawing.Color.Black
        Me.btnpay.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnpay.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnpay.CheckedForeColor = System.Drawing.Color.White
        Me.btnpay.CheckedImage = Nothing
        Me.btnpay.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnpay.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnpay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnpay.FocusedColor = System.Drawing.Color.Empty
        Me.btnpay.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpay.ForeColor = System.Drawing.Color.White
        Me.btnpay.Image = Nothing
        Me.btnpay.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnpay.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnpay.Location = New System.Drawing.Point(0, 283)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnpay.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnpay.OnHoverForeColor = System.Drawing.Color.White
        Me.btnpay.OnHoverImage = Nothing
        Me.btnpay.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnpay.OnPressedColor = System.Drawing.Color.Black
        Me.btnpay.Size = New System.Drawing.Size(622, 49)
        Me.btnpay.TabIndex = 0
        Me.btnpay.Text = "Pay"
        Me.btnpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(254, 26)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(98, 24)
        Me.GunaLabel9.TabIndex = 5
        Me.GunaLabel9.Text = "Payment"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(97, 78)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(157, 21)
        Me.GunaLabel1.TabIndex = 6
        Me.GunaLabel1.Text = "Mode of Payment: "
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(97, 117)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(161, 21)
        Me.GunaLabel2.TabIndex = 7
        Me.GunaLabel2.Text = "Reference Number:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(97, 156)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(108, 21)
        Me.GunaLabel3.TabIndex = 8
        Me.GunaLabel3.Text = "Grand Total:"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(97, 194)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(117, 21)
        Me.GunaLabel4.TabIndex = 9
        Me.GunaLabel4.Text = "Amount Paid:"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(97, 230)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(148, 21)
        Me.GunaLabel5.TabIndex = 10
        Me.GunaLabel5.Text = "Amount Change:"
        '
        'cboMOP
        '
        Me.cboMOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMOP.FormattingEnabled = True
        Me.cboMOP.Location = New System.Drawing.Point(343, 75)
        Me.cboMOP.Name = "cboMOP"
        Me.cboMOP.Size = New System.Drawing.Size(159, 24)
        Me.cboMOP.TabIndex = 11
        '
        'txtRefNo
        '
        Me.txtRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(343, 114)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(159, 24)
        Me.txtRefNo.TabIndex = 12
        '
        'txtpaid
        '
        Me.txtpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaid.Location = New System.Drawing.Point(343, 193)
        Me.txtpaid.Name = "txtpaid"
        Me.txtpaid.Size = New System.Drawing.Size(159, 24)
        Me.txtpaid.TabIndex = 14
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(339, 230)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(41, 21)
        Me.lblChange.TabIndex = 15
        Me.lblChange.Text = "0.00"
        '
        'btnplus
        '
        Me.btnplus.Animated = True
        Me.btnplus.AnimationHoverSpeed = 0.07!
        Me.btnplus.AnimationSpeed = 0.03!
        Me.btnplus.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnplus.BorderColor = System.Drawing.Color.Black
        Me.btnplus.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnplus.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnplus.CheckedForeColor = System.Drawing.Color.White
        Me.btnplus.CheckedImage = Nothing
        Me.btnplus.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnplus.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnplus.FocusedColor = System.Drawing.Color.Empty
        Me.btnplus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplus.ForeColor = System.Drawing.Color.White
        Me.btnplus.Image = Nothing
        Me.btnplus.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnplus.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnplus.Location = New System.Drawing.Point(508, 75)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnplus.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnplus.OnHoverForeColor = System.Drawing.Color.White
        Me.btnplus.OnHoverImage = Nothing
        Me.btnplus.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnplus.OnPressedColor = System.Drawing.Color.Black
        Me.btnplus.Size = New System.Drawing.Size(39, 24)
        Me.btnplus.TabIndex = 16
        Me.btnplus.Text = "+"
        Me.btnplus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblGrandTotal.Location = New System.Drawing.Point(339, 156)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(41, 21)
        Me.lblGrandTotal.TabIndex = 17
        Me.lblGrandTotal.Text = "0.00"
        '
        'frmpayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(622, 332)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtpaid)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.cboMOP)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.btnpay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmpayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnpay As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblChange As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpaid As TextBox
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents cboMOP As ComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnplus As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblGrandTotal As Label
End Class
