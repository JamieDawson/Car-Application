Namespace AllCars
    Class Car
        Implements IDisposable
        'Publc and Private members 
        Public Color As String
        Public carName As String
        Private intSpeed As Integer
        Private intNumberOfDoors As Integer
        Private intHorsePower As Integer
        'constructor 
        Sub New()
            Color = "Red"
            intSpeed = 0
            intNumberOfDoors = 5
        End Sub

        'Gets speed
        Public ReadOnly Property Speed() As Integer
            Get
                Return intSpeed
            End Get
        End Property
        'Gets and Sets HorsePower
        Public Property HorsePower() As Integer
            Get
                Return intHorsePower
            End Get
            Set(value As Integer)
                intHorsePower = value
            End Set
        End Property
        'Accelerates the car 
        Public Sub Accelerate(ByVal accelerateBy As Integer)
            intSpeed += accelerateBy
        End Sub
        'Overwrite ToString
        Public Overrides Function ToString() As String
            Return "Car Name:" & carName & Environment.NewLine & "Car Color:" & Color & Environment.NewLine & "Number ofdoors " & propNumberOfDoors & "Car Speed" & intSpeed
        End Function
        'Gets and sets number of Doors
        Public Property propNumberOfDoors() As Integer
            Get
                Return intNumberOfDoors
            End Get
            Set(value As Integer)
                If value >= 2 And value <= 5 Then
                    intNumberOfDoors = value
                Else
                    MessageBox.Show("The number of Doors you have entered is not valid")
                End If

            End Set
        End Property
        'is the car moving?
        Public Function isMoving() As Boolean
            If Speed = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            ' TODO: uncomment the following line if Finalize() is overridden above.
            ' GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class




    'SportsCar class 
    Class SportsCar
        Inherits Car


        Sub New()
            Color = "red"
            propNumberOfDoors = 2

        End Sub
        Public weight As Integer
        Public Function getSportsInfo()
            Return "Car Name:" & carName & Environment.NewLine & "Car Color:" & Color & Environment.NewLine & "Number ofdoors " & propNumberOfDoors & "Car Speed" & Speed & "HorsePower:" & HorsePower & "Weight:" & weight
        End Function
        'Get Power to weight ratio 
        Public Function getPowerToWeightRatio() As Double
            Return CType(HorsePower, Double) / CType(weight, Double)
        End Function

    End Class

    'truck class
    Class TruckCar
        Inherits Car
        Private truckBedLength As bedLength
        Private truckCabLength As cabLength


        'gets and sets theBedLength
        Public Property theBedLength As bedLength
            Get
                Return truckBedLength
            End Get
            Set(value As bedLength)
                If value >= 0 And value <= 2 Then
                    truckBedLength = value
                End If
            End Set
        End Property
        'gets and sets truckCabLength
        Public Property theCabLength() As cabLength
            Get
                Return truckCabLength
            End Get
            Set(value As cabLength)
                If value >= 0 And value <= 2 Then
                    truckCabLength = value
                End If
            End Set
        End Property
        'gives the infomation about truck
        Public Function getTruckInfo() As String
            Return "Car Name:" & carName & Environment.NewLine & "Car Color:" & Color & Environment.NewLine & "Cab Size: " & truckCabLength & Environment.NewLine & "Bed Length:" & truckBedLength & Environment.NewLine & "Number of doors " & propNumberOfDoors & "Car Speed" & Speed
        End Function

    End Class

    'bedlength enumeration: short medium long
    Enum bedLength As Integer
        ShortBed = 0
        MediumBed = 1
        LongBed = 2
    End Enum
    'cab length enumeration
    Enum cabLength As Integer
        SingleCab = 0
        ExtendedCab = 1
        CrewMax = 2

    End Enum


End Namespace
