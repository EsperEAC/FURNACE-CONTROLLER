Public Class CLS_INTERPULATE
    ' Interpolation Class: Calculates the temperature between points in an array.
    ' This class is designed for a specific use case:
    ' Input: Time to observe
    ' Input arrays:
    '   - arrayOfDuration = {10.0, 10.0, 10.0, 10.0} (time durations)
    '   - arrayOfSetpoint = {20.0, 25.0, 30.0, 600.0} (corresponding setpoints)
    ' Output: The temperature at the specified time (SV)
    '
    ' For example, arrayOfDuration(0) represents the time it takes to change from 0 to 20 (in 10 minutes).
    ' Analogously, in a temperature controller, we set the SV (setpoint value) and the duration to reach that value.
    '
    ' Completed by Esper on 12th July 2024 at 3:37 AM.
    '
    ' Example usage:
    ' Private Function CalculateTemperature(ByVal time As Double) As Double
    '     Dim interp As New CLS_INTERPULATE()
    '     interp.ARR_TIME = {10.0, 10.0, 10.0, 10.0}
    '     interp.ARR_TEMP = {20.0, 25.0, 30.0, 600.0}
    '     Dim interpolatedTemp As Double = interp.InterpolateTemperature(time)
    '     Return interpolatedTemp
    ' End Function


    Private arrayOfSetpoint() As Double
    Private arrayOfDuration() As Double

    Private TempPoint(20) As Double
    Private TimePoint(20) As Double

    Public Property ARR_TEMP() As Double() ' Get Temperature array
        Get
            Return arrayOfSetpoint
        End Get
        Set(ByVal value As Double())
            arrayOfSetpoint = value
        End Set
    End Property

    Public Property ARR_TIME() As Double() ' Get Time duration array
        Get
            Return arrayOfDuration
        End Get
        Set(ByVal value As Double())
            arrayOfDuration = value
        End Set
    End Property

    Public Function InterpolateTemperature(GetTime As TimeSpan) As String
        Dim Thistime As Double = GetTime.TotalSeconds / 60
        Dim StepPoint As Integer
        'Dim Result As String

        CreatePoint() ' Update set point and duration to time and temperature point
        'For a As Integer = 0 To TimePoint.Length - 1
        '    Result += TimePoint(a) & ","
        'Next
        For cnt As Integer = 0 To arrayOfDuration.Length - 1
            If (TimePoint(cnt) < Thistime) Then ' The point is the next
                StepPoint = cnt + 1
            End If
        Next
        'So now i know the both point of my focused time
        'Create equation -- C(i) = mT + C(i-1)
        'Create m = [C(i) - C(i-1)] / [T(i)-T(i-1)]
        Dim m As Double = (TempPoint(StepPoint) - TempPoint(StepPoint - 1)) / (TimePoint(StepPoint) - TimePoint(StepPoint - 1))
        Dim C As Double = TempPoint(StepPoint)
        Dim T As Double = Thistime - TimePoint(StepPoint)
        Dim thisTemp As Double = m * T + C
        ' Round the temperature to 2 decimal places
        Dim roundedTemp As Double = Math.Round(thisTemp, 2)

        Return roundedTemp.ToString("F0")
    End Function


    Private Sub CreatePoint() 'Extractio of the array
        ReDim TempPoint(arrayOfSetpoint.Length)
        ReDim TimePoint(arrayOfDuration.Length)
        'Update Temp Point
        TempPoint(0) = 0
        For i As Integer = 1 To arrayOfSetpoint.Length
            TempPoint(i) = arrayOfSetpoint(i - 1)
        Next
        'Update Time point
        TimePoint(0) = 0
        For j As Integer = 1 To arrayOfDuration.Length
            TimePoint(j) = TimePoint(j - 1) + arrayOfDuration(j - 1)
        Next
    End Sub

End Class
