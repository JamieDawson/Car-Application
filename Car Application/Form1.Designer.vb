<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSetname = New System.Windows.Forms.Button()
        Me.btnSetColor = New System.Windows.Forms.Button()
        Me.btnShowCarInfo = New System.Windows.Forms.Button()
        Me.btnSetDoors = New System.Windows.Forms.Button()
        Me.btnAccelerate = New System.Windows.Forms.Button()
        Me.btnGetPowerWeight = New System.Windows.Forms.Button()
        Me.listCars = New System.Windows.Forms.ListBox()
        Me.btnCreateCar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetname
        '
        Me.btnSetname.Location = New System.Drawing.Point(148, 61)
        Me.btnSetname.Name = "btnSetname"
        Me.btnSetname.Size = New System.Drawing.Size(75, 23)
        Me.btnSetname.TabIndex = 0
        Me.btnSetname.Text = "Name"
        Me.btnSetname.UseVisualStyleBackColor = True
        '
        'btnSetColor
        '
        Me.btnSetColor.Location = New System.Drawing.Point(148, 100)
        Me.btnSetColor.Name = "btnSetColor"
        Me.btnSetColor.Size = New System.Drawing.Size(75, 23)
        Me.btnSetColor.TabIndex = 1
        Me.btnSetColor.Text = "Color"
        Me.btnSetColor.UseVisualStyleBackColor = True
        '
        'btnShowCarInfo
        '
        Me.btnShowCarInfo.Location = New System.Drawing.Point(148, 238)
        Me.btnShowCarInfo.Name = "btnShowCarInfo"
        Me.btnShowCarInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnShowCarInfo.TabIndex = 2
        Me.btnShowCarInfo.Text = "Show Info"
        Me.btnShowCarInfo.UseVisualStyleBackColor = True
        '
        'btnSetDoors
        '
        Me.btnSetDoors.Location = New System.Drawing.Point(148, 140)
        Me.btnSetDoors.Name = "btnSetDoors"
        Me.btnSetDoors.Size = New System.Drawing.Size(75, 23)
        Me.btnSetDoors.TabIndex = 3
        Me.btnSetDoors.Text = "Doors"
        Me.btnSetDoors.UseVisualStyleBackColor = True
        '
        'btnAccelerate
        '
        Me.btnAccelerate.Location = New System.Drawing.Point(148, 169)
        Me.btnAccelerate.Name = "btnAccelerate"
        Me.btnAccelerate.Size = New System.Drawing.Size(75, 23)
        Me.btnAccelerate.TabIndex = 4
        Me.btnAccelerate.Text = "Accelerate"
        Me.btnAccelerate.UseVisualStyleBackColor = True
        '
        'btnGetPowerWeight
        '
        Me.btnGetPowerWeight.Location = New System.Drawing.Point(148, 209)
        Me.btnGetPowerWeight.Name = "btnGetPowerWeight"
        Me.btnGetPowerWeight.Size = New System.Drawing.Size(75, 23)
        Me.btnGetPowerWeight.TabIndex = 5
        Me.btnGetPowerWeight.Text = "Power/Weight"
        Me.btnGetPowerWeight.UseVisualStyleBackColor = True
        '
        'listCars
        '
        Me.listCars.FormattingEnabled = True
        Me.listCars.Location = New System.Drawing.Point(12, 30)
        Me.listCars.Name = "listCars"
        Me.listCars.Size = New System.Drawing.Size(120, 186)
        Me.listCars.TabIndex = 6
        '
        'btnCreateCar
        '
        Me.btnCreateCar.Location = New System.Drawing.Point(148, 30)
        Me.btnCreateCar.Name = "btnCreateCar"
        Me.btnCreateCar.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateCar.TabIndex = 7
        Me.btnCreateCar.Text = "New Car"
        Me.btnCreateCar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 299)
        Me.Controls.Add(Me.btnCreateCar)
        Me.Controls.Add(Me.listCars)
        Me.Controls.Add(Me.btnGetPowerWeight)
        Me.Controls.Add(Me.btnAccelerate)
        Me.Controls.Add(Me.btnSetDoors)
        Me.Controls.Add(Me.btnShowCarInfo)
        Me.Controls.Add(Me.btnSetColor)
        Me.Controls.Add(Me.btnSetname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSetname As Button
    Friend WithEvents btnSetColor As Button
    Friend WithEvents btnShowCarInfo As Button
    Friend WithEvents btnSetDoors As Button
    Friend WithEvents btnAccelerate As Button
    Friend WithEvents btnGetPowerWeight As Button
    Friend WithEvents listCars As ListBox
    Friend WithEvents btnCreateCar As Button
End Class
