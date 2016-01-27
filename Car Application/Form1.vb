Public Class Form1

    Private defaultCar As New AllCars.Car
    Private defaultSportsCar As New AllCars.SportsCar
    Private cars As New ArrayList
    Private selectedCar As AllCars.Car

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        defaultCar.carName = "Honda CR-V"
        defaultSportsCar.carName = "Mustang GT"
        cars.Add(defaultCar)
        cars.Add(defaultSportsCar)
        addAllCars()
    End Sub
    'subs created by me
    Private Sub addAllCars()
        For Each car As AllCars.Car In cars
            listCars.Items.Add(car.carName)
        Next
    End Sub

    Private Sub showCarInfo(ByVal argCar As AllCars.Car)
        MessageBox.Show(argCar.ToString(), "Info")
    End Sub

    Private Sub listCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listCars.SelectedIndexChanged
        If listCars.SelectedIndex <> -1 Then
            selectedCar = cars(listCars.SelectedIndex)
        End If
    End Sub

    'Button Click events 
    Private Sub btnSetname_Click(sender As Object, e As EventArgs) Handles btnSetname.Click
        defaultSportsCar.carName = InputBox("Please enter the name of your car", "Name")
    End Sub
    Private Sub btnSetColor_Click(sender As Object, e As EventArgs) Handles btnSetColor.Click
        defaultSportsCar.Color = InputBox("Please enter the color of our car.", "Color")
    End Sub
    Private Sub btnShowCarInfo_Click(sender As Object, e As EventArgs) Handles btnShowCarInfo.Click
        showCarInfo(selectedCar)
    End Sub
    Private Sub btnSetDoors_Click(sender As Object, e As EventArgs) Handles btnSetDoors.Click
        defaultSportsCar.propNumberOfDoors = CType(InputBox("Please enter number of doors", "Doors"), Integer)
    End Sub
    Private Sub btnAccelerate_Click(sender As Object, e As EventArgs) Handles btnAccelerate.Click
        defaultSportsCar.Accelerate(CType(InputBox("Please enter the speed in mph to Accelerate", "Speed"), Integer))
    End Sub
    Private Sub btnGetPowerWeight_Click(sender As Object, e As EventArgs) Handles btnGetPowerWeight.Click
        MessageBox.Show(Convert.ToString(defaultSportsCar.getPowerToWeightRatio()), "P/W Ratio")
    End Sub
    Private Sub btnCreateCar_Click(sender As Object, e As EventArgs) Handles btnCreateCar.Click
        Dim addNewCar As New NewCar
        addNewCar.ShowDialog()
        Using newCar1 As New AllCars.Car

            With newCar1
                .carName = addNewCar.carName
                .Color = addNewCar.carColor
                .HorsePower = addNewCar.carHorse
                .propNumberOfDoors = addNewCar.carDoors
            End With
            cars.Add(newCar1)
            listCars.Items.Add(newCar1.carName)
        End Using
    End Sub
End Class
