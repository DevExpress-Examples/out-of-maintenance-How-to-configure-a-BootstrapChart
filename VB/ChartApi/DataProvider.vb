Imports Microsoft.VisualBasic
Imports System
Imports System.Linq

Namespace ChartApi
	Public Class NumericDataPoint
		Public Property X As Integer
		Public Property Y1 As Integer?
		Public Property Y2 As Integer?
	End Class
	Public Class DataProvider
		Private Shared ReadOnly startDate As New DateTime(2020, 10, 1)
        Public Shared Function GetDataForArgNumeric() As Object
            Dim dataNumeric = Enumerable.Range(1, 9).[Select](Function(i) New NumericDataPoint With {
                .X = i,
                .Y1 = i * 5,
                .Y2 = i * 5 + 1
            }).ToList()

            'emulate empty point for certain series
            dataNumeric.Add(New NumericDataPoint With {.X = 10, .Y1 = 50, .Y2 = Nothing})
            dataNumeric.Add(New NumericDataPoint With {.X = 11, .Y1 = Nothing, .Y2 = 56})

			dataNumeric.Add(New NumericDataPoint With {.X = 12, .Y1 = 60, .Y2 = 61})
			Return dataNumeric
        End Function
        Public Shared Function GetDataForArgDate() As Object
			Dim dataDate = Enumerable.Range(0, 9).Select(Function(i) New With {Key .X = startDate.AddDays(i), Key .Y = i * 5}).ToList()

			Return dataDate
		End Function
		Public Shared Function GetDataForArgString() As Object
			Dim dataString = Enumerable.Range(1, 9).Select(Function(i) New With {Key .X = i.ToString(), Key .Y = (i * 5).ToString()}).ToList()

			Return dataString
		End Function
	End Class
End Namespace