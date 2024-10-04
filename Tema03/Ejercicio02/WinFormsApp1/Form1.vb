Imports System.Security.Cryptography.X509Certificates
Imports BibliotecaClases

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim persona As New ClsPersona
        persona.Nombre = tbName.Text

        MsgBox("Hola " & persona.Nombre)

    End Sub
End Class
