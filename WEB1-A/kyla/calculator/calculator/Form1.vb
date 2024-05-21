Public Class frCalculator
    Dim dblFirstNum As Double
    Dim dblSecondNum As Double
    Dim Operation As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub frCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        Dim button As Button = CType(sender, Button)

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = button.Text
        Else
            txtDisplay.Text += button.Text
        End If
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim button As Button = CType(sender, Button)

        dblFirstNum = Double.Parse(txtDisplay.Text)

        Operation = button.Text
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        Dim button As Button = CType(sender, Button)

        dblFirstNum = Double.Parse(txtDisplay.Text)

        Operation = button.Text
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        Dim button As Button = CType(sender, Button)

        dblFirstNum = Double.Parse(txtDisplay.Text)

        Operation = button.Text
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim button As Button = CType(sender, Button)

        dblFirstNum = Double.Parse(txtDisplay.Text)

        Operation = button.Text
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim dblresult As Double

        dblSecondNum = Double.Parse(txtDisplay.Text)

        Select Case Operation
            Case "+"
                dblresult = dblFirstNum + dblSecondNum

            Case "-"
                dblresult = dblFirstNum - dblSecondNum


            Case "*"
                dblresult = dblFirstNum * dblSecondNum


            Case "/"
                If dblSecondNum <> 0 Then
                    dblresult = dblFirstNum / dblSecondNum
                Else : MessageBox.Show("Cannot divide by zero")
                End If

        End Select

        txtDisplay.Text = dblresult.ToString()
    End Sub

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        End If

        If txtDisplay.Text = "" Then
            txtDisplay.Text = "0"
        End If
    End Sub
End Class
