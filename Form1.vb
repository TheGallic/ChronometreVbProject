Imports System.Threading

Public Class Form1
    Public secondesCompte As Integer
    Public minutesCompte As Integer
    Public heuresCompte As Integer

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Me.cpbSecondes.Value = 0
        Me.cpbMinutes.Value = 0
        Me.cpbHeures.Value = 0
        BtnStart.Enabled = False
        BtnPause.Enabled = True

        TimerChrono.Enabled = True
        TimerChrono.Start()

        If BtnPause.Enabled = True Then
            TimerChrono.Start()
        ElseIf BtnPause.Enabled = False Then

            TimerChrono.Stop()
            TimerChrono.Enabled = False
        End If
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        BtnPause.Enabled = False
        BtnStart.Enabled = True
        BtnStart.Text = "Redémarrer"
        TimerChrono.Stop()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        secondesCompte = 0
        minutesCompte = 0
        heuresCompte = 0
        BtnPause.Enabled = True
        BtnStart.Enabled = True
        BtnStart.Text = "Démarrer"
        cpbSecondes.Value = secondesCompte
        cpbSecondes.Text = secondesCompte & " Seconde(s)"


        cpbMinutes.Value = minutesCompte
        cpbMinutes.Text = minutesCompte & " Minute(s)"

        cpbHeures.Value = heuresCompte
        cpbHeures.Text = heuresCompte & " Heure(s)"
        TimerChrono.Stop()
        TimerChrono.Enabled = False
    End Sub








    Private Sub TimerChrono_Tick(sender As Object, e As EventArgs) Handles TimerChrono.Tick

        If secondesCompte <= 60 Then

            cpbSecondes.Value = secondesCompte
            cpbSecondes.Text = secondesCompte & " Seconde(s)"


            cpbMinutes.Value = minutesCompte
            cpbMinutes.Text = minutesCompte & " Minute(s)"

            cpbHeures.Value = heuresCompte
            cpbHeures.Text = heuresCompte & " Heure(s)"

            'Si on a plus de 60 secondes on rajoute 1 minute
            If secondesCompte = 60 Then
                minutesCompte += 1
                secondesCompte = 0
            End If

            'Si on a plus de 60 minutes, on rajoute 1 heures
            If minutesCompte = 60 Then
                heuresCompte += 1
                minutesCompte = 0
            End If

            'Si on a plus de 24 heures on reinitialise tout
            If heuresCompte > 24 Then
                secondesCompte = 0
                minutesCompte = 0
                heuresCompte = 0
                Return
            End If
            secondesCompte += 1

        End If
    End Sub
End Class
