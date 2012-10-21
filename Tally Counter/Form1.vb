Imports System.IO
Public Class Form1
    Dim x As Integer = 0
    Dim y As Boolean = False
    Dim SR As StreamReader
    Dim SW As StreamWriter
    Dim Chemin As String = "D:\Tally_Counter.txt"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        timer()
        x = 0
        Label1.Text = x
    End Sub

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        Label1.Text = "88888"
        y = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        timer()
        If x = "99999" Then
            x = 0
            Label1.Text = x
        Else
            x = x + 1
            Label1.Text = x
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Enregistrer()
        End
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Enregistrer()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If (File.Exists(Chemin)) Then
                SR = New StreamReader(Chemin)
                x = SR.ReadToEnd
                SR.Close()
                Timer1.Start()
                Label1.Text = x
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If x > "99999" Then
            x = 0
            Label1.Text = x
        End If
    End Sub

    Sub timer()
        Timer1.Stop()
        Timer1.Interval = 10000
        Timer1.Start()
    End Sub

    Sub Enregistrer()
        Try
            SW = New StreamWriter(Chemin)
            SW.Write(x)
            SW.Close()
            SR = New StreamReader(Chemin)
            x = SR.ReadToEnd
            SR.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As New ColorDialog
        Timer1.Stop()
        If a.ShowDialog = Windows.Forms.DialogResult.OK Then
            timer()
            Me.BackColor = a.Color
        End If
    End Sub
End Class
