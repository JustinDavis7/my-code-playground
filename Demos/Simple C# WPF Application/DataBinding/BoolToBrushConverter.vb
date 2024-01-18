Imports System
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Media

' The BoolToBrushConverter class is a value converter 
' that helps to bind a bool value to a brush property. 
<ValueConversion(GetType(Boolean), GetType(Brush))>
Public Class BoolToBrushConverter
    Implements IValueConverter

    Public Function Convert(
                            ByVal value As Object,
                            ByVal targetType As Type,
                            ByVal parameter As Object,
                            ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert

        Dim b As Brush = Nothing

        ' Only apply the conversion if value is assigned and 
        ' is of type bool. 
        If value IsNot Nothing AndAlso value.[GetType]() Is GetType(Boolean) Then
            ' true is painted with a green brush, 
            ' false with a red brush. 
            b = If(CBool(value), Brushes.Green, Brushes.Red)
        End If

        Return b
    End Function

    ' Not used. 
    Public Function ConvertBack(
                                ByVal value As Object,
                                ByVal targetType As Type,
                                ByVal parameter As Object,
                                ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Return Nothing
    End Function

End Class