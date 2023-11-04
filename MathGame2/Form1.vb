'TAREA IV PROGRAMACIÓN II PARTE II
'JEFFERSON SALDAÑA CASTRO
'CUATRIMESTRE III UISIL 2023

Public Class Form1
    Dim random As New Random()
    Dim num1 As Integer
    Dim num2 As Integer
    Dim operacion As String
    Dim respuestaCorrecta As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarProblema()
    End Sub

    Private Sub GenerarProblema()
        num1 = random.Next(1, 101)
        num2 = random.Next(1, 101)
        Dim operaciones() As String = {"+", "-", "*", "/"}
        operacion = operaciones(random.Next(0, operaciones.Length))
        Select Case operacion
            Case "+"
                respuestaCorrecta = num1 + num2
            Case "-"
                respuestaCorrecta = num1 - num2
            Case "*"
                respuestaCorrecta = num1 * num2
            Case "/"
                ' Evitar división por cero
                If num2 = 0 Then
                    num2 = 1
                End If
                ' Asegurarse de que el resultado sea un número entero
                num1 = num2 * random.Next(1, 11)
                respuestaCorrecta = num1 / num2
        End Select

        lblProblema.Text = num1 & " " & operacion & " " & num2 & " = "
        txtRespuesta.Text = ""
    End Sub

    Private Sub BtnVerificar_Click(sender As Object, e As EventArgs) Handles BtnVerificar.Click
        Try
            Dim respuestaUsuario As Integer = Integer.Parse(txtRespuesta.Text)
            If respuestaUsuario = respuestaCorrecta Then
                MessageBox.Show("¡Respuesta Correcta!")
                GenerarProblema()
            Else
                MessageBox.Show("Respuesta Incorrecta. Inténtalo de nuevo.")
            End If
        Catch ex As Exception
            MessageBox.Show("Por favor, ingrese una respuesta válida.")
        End Try
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

End Class



