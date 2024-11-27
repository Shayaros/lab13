Imports System.Globalization
Public Class Fmain
    Private Sub Fmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbx1min.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gv.CellContentClick

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Використання інваріантної культури для парсингу
        Dim ci As CultureInfo = CultureInfo.InvariantCulture

        ' Перетворення введених значень
        Dim x1min As Double = Double.Parse(tbx1min.Text.Replace(",", "."), ci)
        Dim x1max As Double = Double.Parse(tbx1max.Text.Replace(",", "."), ci)
        Dim x2min As Double = Double.Parse(tbx2min.Text.Replace(",", "."), ci)
        Dim x2max As Double = Double.Parse(tbx2max.Text.Replace(",", "."), ci)
        Dim dx1 As Double = Double.Parse(tbdx1.Text.Replace(",", "."), ci)
        Dim dx2 As Double = Double.Parse(tbdx2.Text.Replace(",", "."), ci)

        ' Налаштування DataGridView
        gv.ColumnCount = CInt(Math.Truncate((x2max - x2min) / dx2)) + 2  ' +1 для підсумкового стовпця
        gv.RowCount = CInt(Math.Truncate((x1max - x1min) / dx1)) + 2     ' +1 для підсумкового рядка

        ' Заповнення заголовків
        For i As Integer = 0 To gv.RowCount - 2
            gv.Rows(i).HeaderCell.Value = (x1min + i * dx1).ToString("0.000")
        Next

        For i As Integer = 0 To gv.ColumnCount - 2
            gv.Columns(i).HeaderCell.Value = (x2min + i * dx2).ToString("0.000")
        Next

        gv.Rows(gv.RowCount - 1).HeaderCell.Value = "Сума рядків"
        gv.Columns(gv.ColumnCount - 1).HeaderCell.Value = "Сума стовпців"

        ' Розрахунок значень
        Dim rowIdx As Integer = 0
        Dim x1 As Double = x1min
        While x1 <= x1max
            Dim x2 As Double = x2min
            Dim colIdx As Integer = 0
            While x2 <= x2max
                Dim y As Double = x1 + x2  ' Замініть на потрібну функцію
                gv.Rows(rowIdx).Cells(colIdx).Value = y.ToString("0.000")
                x2 += dx2
                colIdx += 1
            End While
            x1 += dx1
            rowIdx += 1
        End While

        ' Обчислення суми стовпців
        For col As Integer = 0 To gv.ColumnCount - 2
            Dim sum As Double = 0
            For row As Integer = 0 To gv.RowCount - 2
                sum += Double.Parse(gv.Rows(row).Cells(col).Value, ci)
            Next
            gv.Rows(gv.RowCount - 1).Cells(col).Value = sum.ToString("0.000")
        Next

        ' Обчислення суми рядків
        For row As Integer = 0 To gv.RowCount - 2
            Dim sum As Double = 0
            For col As Integer = 0 To gv.ColumnCount - 2
                sum += Double.Parse(gv.Rows(row).Cells(col).Value, ci)
            Next
            gv.Rows(row).Cells(gv.ColumnCount - 1).Value = sum.ToString("0.000")
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Очищення текстових полів
        tbx1min.Text = ""
        tbx1max.Text = ""
        tbx2min.Text = ""
        tbx2max.Text = ""
        tbdx1.Text = ""
        tbdx2.Text = ""

        ' Очищення таблиці
        gv.Rows.Clear()
        For cl As Integer = 0 To gv.ColumnCount - 1
            gv.Columns(cl).HeaderCell.Value = ""
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Закрити програму?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub
End Class
