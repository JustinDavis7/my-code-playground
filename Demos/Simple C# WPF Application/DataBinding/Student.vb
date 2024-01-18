Imports System
Imports System.Collections.ObjectModel
Imports System.Windows

' Student is a simple class that stores a name and an 
' IsEnrolled value. 
Public Class Student

    ' The default constructor is required for creation from XAML. 
    Public Sub New()
    End Sub

    ' The StudentName property is a string that holds the first and last name. 
    Public Property StudentName As String

    ' The IsEnrolled property gets or sets a value indicating whether 
    ' the student is currently enrolled. 
    Public Property IsEnrolled As Boolean

End Class

' The StudentList collection is declared for convenience, 
' because declaring generic types in XAML is inconvenient. 
Public Class StudentList
    Inherits ObservableCollection(Of Student)
End Class