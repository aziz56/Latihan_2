

Public Class Time
        Private _year As Integer
        Private _month As Integer
        Private _day As Integer
        Private _hour As Integer
        Private _minute As Integer
    Private _second As Integer
    Public Property year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property
    Public Property month As Integer
        Get
            Return _month
        End Get
        Set(value As Integer)
            _month = value
        End Set
    End Property
    Public Property day As Integer
        Get
            Return _day
        End Get
        Set(value As Integer)
            _day = value
        End Set
    End Property
    Public Property hour As Integer
        Get
            Return _hour
        End Get
        Set(value As Integer)
            _hour = value
        End Set
    End Property
    Public Property minute As Integer
        Get
            Return _minute
        End Get
        Set(value As Integer)
            _minute = value
        End Set
    End Property
    Public Property second As Integer
        Get
            Return _second
        End Get
        Set(value As Integer)
            _second = value
        End Set
    End Property
    Public Function ToDate() As Date
        Return New Date(_year, _month, _day, _hour, _minute, _second)
    End Function

    Public Sub New()
            _year = 0
            _month = 0
            _day = 0
            _hour = 0
            _minute = 0
            _second = 0
        End Sub
        Public Sub New(year As Integer, month As Integer, day As Integer, hour As Integer, minute As Integer, second As Integer)
            _year = year
            _month = month
            _day = day
            _hour = hour
            _minute = minute
            _second = second
        End Sub
        Public Sub New(dt As Date)
            _year = dt.Year
            _month = dt.Month
            _day = dt.Day
            _hour = dt.Hour
            _minute = dt.Minute
            _second = dt.Second
        End Sub
    End Class