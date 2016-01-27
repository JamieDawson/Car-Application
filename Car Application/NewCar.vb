Public Class NewCar
    Public carName As String
    Public carColor As String
    Public carDoors As Integer
    Public carHorse As String
    Private Sub txtCarName_TextChanged(sender As Object, e As EventArgs) Handles txtCarName.TextChanged
        carName = txtCarName.Text
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        carColor = TextBox1.Text
    End Sub
    Private Sub numerDoors_ValueChanged(sender As Object, e As EventArgs) Handles numerDoors.ValueChanged
        carDoors = numerDoors.Value
    End Sub
    Private Sub txtHorse_TextChanged(sender As Object, e As EventArgs) Handles txtHorse.TextChanged
        carHorse = txtHorse.Text
    End Sub
    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        Me.Close()
    End Sub
End Class