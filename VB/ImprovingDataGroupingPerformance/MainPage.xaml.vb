Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace ImprovingDataGroupingPerformance
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = New ProductList()
			GroupData(New String(){"Country", "City", "Quantity", "UnitPrice"})
		End Sub
		Private Sub GroupData(ByVal fieldNames() As String)
			grid.BeginDataUpdate()
			Try
				grid.ClearGrouping()
				For i As Integer = 0 To fieldNames.Length - 1
					Dim col As GridColumn = grid.Columns(fieldNames(i))
					If col IsNot Nothing Then
						grid.GroupBy(col)
					End If
				Next i
			Finally
				grid.EndDataUpdate()
			End Try
		End Sub
	End Class
End Namespace
