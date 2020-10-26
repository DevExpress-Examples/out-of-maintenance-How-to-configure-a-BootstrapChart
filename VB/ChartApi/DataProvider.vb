Imports Microsoft.VisualBasic
Imports System
Imports System.Linq

Namespace ChartApi
	Public Class DataProvider
		Private Shared ReadOnly startDate As New DateTime(2020, 10, 01)
		Public Shared Function GetDataForArgNumeric() As Object
			Dim dataNumeric = Enumerable.Range(1, 9).Select(Function(i) New With {Key .X = i, Key .Y1 = i * 5, Key .Y2 = i * 5 + 1}).ToList()

			'emulate empty point for certain series
			dataNumeric.Add(New With {Key .X = 10, Key .Y1 = 50, Key .Y2 = 0})
			dataNumeric.Add(New With {Key .X = 11, Key .Y1 = 0, Key .Y2 = 56})

			dataNumeric.Add(New With {Key .X = 12, Key .Y1 = 60, Key .Y2 = 61})
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