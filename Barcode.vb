Public Class Barcode

    Dim _value As String
    Dim _name As String

    Public Sub New(ByVal value As String, ByVal name As String)
        Me.Value = value
        Me.Name = name
    End Sub

    Public Property Value() As String
        Get
            Return _value
        End Get
        Set(ByVal value As String)
            _value = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal name As String)
            _name = name
        End Set
    End Property

End Class
