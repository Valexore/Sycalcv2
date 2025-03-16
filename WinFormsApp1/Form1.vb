Public Class Form1
    ' Declare variables for arithmetic operations
    Dim first_number As Double
    Dim second_number As Double
    Dim result As Double
    Dim Arithop As String

    ' Event handler for numeric buttons (0-9, dot)
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btndot.Click
        Try
            Dim b As Button = sender
            If output.Text = "0" Then
                output.Text = b.Text
            Else
                output.Text += b.Text
            End If
        Catch ex As Exception
            output.Text = "Error: Invalid input"
            history.Text = "Error: Invalid input"
        End Try
    End Sub

    ' Event handler for the clear button
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        Try
            output.Text = "0"
            history.Text = ""
        Catch ex As Exception
            output.Text = "Error: Clear operation failed"
            history.Text = "Error: Clear operation failed"
        End Try
    End Sub

    ' Event handler for the clear entry button
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Try
            If output.Text.Length > 1 Then
                output.Text = output.Text.Substring(0, output.Text.Length - 1)
            Else
                output.Text = "0"
            End If
        Catch ex As Exception
            output.Text = "Error: Delete operation failed"
            history.Text = "Error: Delete operation failed"
        End Try
    End Sub

    ' Event handler for arithmetic operation buttons (+, -, *, /, Mod, Exp)
    Private Sub Arithmetic_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnMinus.Click, btnMult.Click, btndiv.Click, btnMod.Click, btnExp.Click
        Try
            Dim ops As Button = sender
            output.Text += " " & ops.Text & " "
        Catch ex As Exception
            output.Text = "Error: Invalid operation"
            history.Text = "Error: Invalid operation"
        End Try
    End Sub

    ' Event handler for the equals button (=)
    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click
        Try
            Dim expression As String = output.Text
            Dim result As Object = New DataTable().Compute(expression, Nothing)

            output.Text = result.ToString()
            history.Text = expression & " = " & result.ToString()

            ' Add the solved problem to the past TextBox
            past.AppendText(history.Text & Environment.NewLine)
        Catch ex As Exception
            output.Text = "Error: Invalid expression"
            history.Text = "Error: Invalid expression"
        End Try
    End Sub

    ' Event handler for the square root button
    Private Sub squareroot_Click(sender As Object, e As EventArgs) Handles squareroot.Click
        Try
            Dim input As Double = Double.Parse(output.Text)
            If input >= 0 Then
                Dim result As Double = Math.Sqrt(input)
                output.Text = result.ToString()
                history.Text = "√(" & input & ") = " & result.ToString()
                past.AppendText(history.Text & Environment.NewLine)
            Else
                output.Text = "Error: Negative input"
                history.Text = "Error: Negative input for square root"
            End If
        Catch ex As Exception
            output.Text = "Error: Square root calculation failed"
            history.Text = "Error: Square root calculation failed"
        End Try
    End Sub

    ' Event handler for the factorial button
    Private Sub factorial_Click(sender As Object, e As EventArgs) Handles factorial.Click
        Try
            Dim input As Integer = Integer.Parse(output.Text)
            If input >= 0 Then
                Try
                    Dim result As Long = CalculateFactorial(input)
                    output.Text = result.ToString()
                    history.Text = input & "! = " & result.ToString()
                    past.AppendText(history.Text & Environment.NewLine)
                Catch ex As OverflowException
                    output.Text = "Error: Overflow"
                    history.Text = "Error: Factorial of " & input & " is too large"
                End Try
            Else
                output.Text = "Error: Negative input"
                history.Text = "Error: Negative input for factorial"
            End If
        Catch ex As Exception
            output.Text = "Error: Factorial calculation failed"
            history.Text = "Error: Factorial calculation failed"
        End Try
    End Sub

    ' Function to calculate factorial
    Private Function CalculateFactorial(n As Integer) As Long
        If n = 0 OrElse n = 1 Then
            Return 1
        Else
            Dim factorial As Long = 1
            For i As Integer = 2 To n
                factorial *= i
                If factorial < 0 Then
                    Throw New OverflowException("Factorial value too large.")
                End If
            Next
            Return factorial
        End If
    End Function

    ' Event handler for the plus/minus button
    Private Sub plusminus_Click(sender As Object, e As EventArgs) Handles plusminus.Click
        Try
            If output.Text.StartsWith("-") Then
                output.Text = output.Text.Substring(1)
            Else
                output.Text = "-" & output.Text
            End If
        Catch ex As Exception
            output.Text = "Error: Plus/minus operation failed"
            history.Text = "Error: Plus/minus operation failed"
        End Try
    End Sub

    ' Event handler for the pi button
    Private Sub pi_Click(sender As Object, e As EventArgs) Handles pi.Click
        Try
            output.Text = Math.PI.ToString()
        Catch ex As Exception
            output.Text = "Error: Pi operation failed"
            history.Text = "Error: Pi operation failed"
        End Try
    End Sub

    ' Event handler for the Euler's number button
    Private Sub euler_Click(sender As Object, e As EventArgs) Handles euler.Click
        Try
            output.Text = Math.E.ToString()
        Catch ex As Exception
            output.Text = "Error: Euler's number operation failed"
            history.Text = "Error: Euler's number operation failed"
        End Try
    End Sub

    ' Event handler for the absolute value button
    Private Sub abs_Click(sender As Object, e As EventArgs) Handles abs.Click
        Try
            Dim input As Double = Double.Parse(output.Text)
            Dim result As Double = Math.Abs(input)
            output.Text = result.ToString()
            history.Text = "|" & input & "| = " & result.ToString()
            past.AppendText(history.Text & Environment.NewLine)
        Catch ex As Exception
            output.Text = "Error: Absolute value calculation failed"
            history.Text = "Error: Absolute value calculation failed"
        End Try
    End Sub

    ' Event handler for the reciprocal button
    Private Sub reciprocalofanumber_Click(sender As Object, e As EventArgs) Handles reciprocalofanumber.Click
        Try
            Dim input As Double = Double.Parse(output.Text)
            If input = 0 Then
                output.Text = "Error: Division by zero"
                history.Text = "Error: Division by zero"
            Else
                Dim result As Double = 1 / input
                output.Text = result.ToString()
                history.Text = "1/" & input & " = " & result.ToString()
                past.AppendText(history.Text & Environment.NewLine)
            End If
        Catch ex As Exception
            output.Text = "Error: Reciprocal calculation failed"
            history.Text = "Error: Reciprocal calculation failed"
        End Try
    End Sub

    ' Event handler for the square button
    Private Sub btnsquare_Click(sender As Object, e As EventArgs) Handles btnsquare.Click
        Try
            Dim input As Double = Double.Parse(output.Text)
            Dim result As Double = input * input
            output.Text = result.ToString()
            history.Text = input & "² = " & result.ToString()
            past.AppendText(history.Text & Environment.NewLine)
        Catch ex As Exception
            output.Text = "Error: Square calculation failed"
            history.Text = "Error: Square calculation failed"
        End Try
    End Sub

    ' Event handler for the cube button
    Private Sub btnCube_Click(sender As Object, e As EventArgs) Handles btnCube.Click
        Try
            Dim input As Double = Double.Parse(output.Text)
            Dim result As Double = input * input * input
            output.Text = result.ToString()
            history.Text = input & "³ = " & result.ToString()
            past.AppendText(history.Text & Environment.NewLine)
        Catch ex As Exception
            output.Text = "Error: Cube calculation failed"
            history.Text = "Error: Cube calculation failed"
        End Try
    End Sub

    ' Event handler for the cube root button
    Private Sub btnCubeRoot_Click(sender As Object, e As EventArgs) Handles btnCubeRoot.Click
        Try
            Dim input As Double = Double.Parse(output.Text)
            Dim result As Double = Math.Pow(input, 1.0 / 3.0)
            output.Text = result.ToString()
            history.Text = "∛(" & input & ") = " & result.ToString()
            past.AppendText(history.Text & Environment.NewLine)
        Catch ex As Exception
            output.Text = "Error: Cube root calculation failed"
            history.Text = "Error: Cube root calculation failed"
        End Try
    End Sub

    ' Event handler for the natural logarithm button
    Private Sub natural_Click(sender As Object, e As EventArgs) Handles natural.Click
        Try
            Dim input As Double = Double.Parse(output.Text)
            If input > 0 Then
                Dim result As Double = Math.Log(input)
                output.Text = result.ToString()
                history.Text = "ln(" & input & ") = " & result.ToString()
                past.AppendText(history.Text & Environment.NewLine)
            Else
                output.Text = "Error: Invalid input"
                history.Text = "Error: Invalid input for natural logarithm"
            End If
        Catch ex As Exception
            output.Text = "Error: Natural logarithm calculation failed"
            history.Text = "Error: Natural logarithm calculation failed"
        End Try
    End Sub

    ' Event handler for the logarithm base 10 button
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Try
            Dim input As Double = Double.Parse(output.Text)
            If input > 0 Then
                Dim result As Double = Math.Log10(input)
                output.Text = result.ToString()
                history.Text = "log10(" & input & ") = " & result.ToString()
                past.AppendText(history.Text & Environment.NewLine)
            Else
                output.Text = "Error: Invalid input"
                history.Text = "Error: Invalid input for logarithm base 10"
            End If
        Catch ex As Exception
            output.Text = "Error: Logarithm base 10 calculation failed"
            history.Text = "Error: Logarithm base 10 calculation failed"
        End Try
    End Sub

    ' Event handler for the clear history button
    Private Sub btnClearHistory_Click(sender As Object, e As EventArgs) Handles btnClearHistory.Click
        Try
            past.Clear()
        Catch ex As Exception
            output.Text = "Error: Clear history failed"
            history.Text = "Error: Clear history failed"
        End Try
    End Sub
End Class
