<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCar
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtCarName = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.numerDoors = New System.Windows.Forms.NumericUpDown()
        Me.lblDoors = New System.Windows.Forms.Label()
        Me.txtHorse = New System.Windows.Forms.TextBox()
        Me.lblHorse = New System.Windows.Forms.Label()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.numerDoors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name Of Car"
        '
        'txtCarName
        '
        Me.txtCarName.Location = New System.Drawing.Point(16, 37)
        Me.txtCarName.Name = "txtCarName"
        Me.txtCarName.Size = New System.Drawing.Size(206, 20)
        Me.txtCarName.TabIndex = 1
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(16, 75)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(64, 13)
        Me.lblColor.TabIndex = 2
        Me.lblColor.Text = "Color Of Car"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 20)
        Me.TextBox1.TabIndex = 3
        '
        'numerDoors
        '
        Me.numerDoors.Location = New System.Drawing.Point(16, 149)
        Me.numerDoors.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numerDoors.Name = "numerDoors"
        Me.numerDoors.Size = New System.Drawing.Size(120, 20)
        Me.numerDoors.TabIndex = 4
        '
        'lblDoors
        '
        Me.lblDoors.AutoSize = True
        Me.lblDoors.Location = New System.Drawing.Point(16, 133)
        Me.lblDoors.Name = "lblDoors"
        Me.lblDoors.Size = New System.Drawing.Size(87, 13)
        Me.lblDoors.TabIndex = 5
        Me.lblDoors.Text = "Number of Doors"
        '
        'txtHorse
        '
        Me.txtHorse.Location = New System.Drawing.Point(16, 207)
        Me.txtHorse.Name = "txtHorse"
        Me.txtHorse.Size = New System.Drawing.Size(206, 20)
        Me.txtHorse.TabIndex = 6
        '
        'lblHorse
        '
        Me.lblHorse.AutoSize = True
        Me.lblHorse.Location = New System.Drawing.Point(17, 191)
        Me.lblHorse.Name = "lblHorse"
        Me.lblHorse.Size = New System.Drawing.Size(65, 13)
        Me.lblHorse.TabIndex = 7
        Me.lblHorse.Text = "HorsePower"
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(16, 244)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(100, 23)
        Me.btnAddCar.TabIndex = 8
        Me.btnAddCar.Text = "Add"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(122, 244)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'NewCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 282)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddCar)
        Me.Controls.Add(Me.lblHorse)
        Me.Controls.Add(Me.txtHorse)
        Me.Controls.Add(Me.lblDoors)
        Me.Controls.Add(Me.numerDoors)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.txtCarName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "NewCar"
        Me.Text = "NewCar"
        CType(Me.numerDoors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtCarName As TextBox
    Friend WithEvents lblColor As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents numerDoors As NumericUpDown
    Friend WithEvents lblDoors As Label
    Friend WithEvents txtHorse As TextBox
    Friend WithEvents lblHorse As Label
    Friend WithEvents btnAddCar As Button
    Friend WithEvents btnCancel As Button
End Class
