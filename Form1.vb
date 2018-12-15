Imports System.Text.RegularExpressions
Imports System.Threading
Imports xNet

Public Class Form1
    Private V As Integer = 0

    Public Sub New()
        InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub Login()
        Using req As New HttpRequest
            req.UserAgent = Http.ChromeUserAgent
            req.Cookies = New CookieDictionary(False)
            req.Proxy = Nothing
            req.IgnoreProtocolErrors = True

            req.AddParam("login", cin.Text)
            req.AddParam("no_anti_inject_password", pass.Text)

            Try
                Dim Respo As String = req.Post("http://www.istic.rnu.tn/ent/login.php").ToString
                Dim Abs As String = req.Get("http://www.istic.rnu.tn/ent/mod_abs2/bilan_eleve.php").ToString
                Dim Notes As String = req.Get("http://www.istic.rnu.tn/ent/cahier_notes/visu_releve_notes_ter.php").ToString


                If Respo.Contains("Déconnexion") Then

                    ProgBar.Value = ProgBar.Value + 20
                    Label3.Text = "Loading % " & ProgBar.Value.ToString

                    ProgBar.Value = ProgBar.Value + 20
                    Label3.Text = "Loading % " & ProgBar.Value.ToString

                    ServerState.BackColor = Color.Green

                    ProgBar.Value = ProgBar.Value + 40
                    Label3.Text = "Loaded % " & ProgBar.Value.ToString

                    Dim NAME As Match = Regex.Match(Respo, "<a href="""" class=""strong"">(.*?)</a>")
                    EtudName.Text = "Name: " & NAME.Groups(1).Value

                    Dim Nbr As MatchCollection = Regex.Matches(Abs, "background:yellow;")
                    Absence.Text = "Absence : > " & Nbr.Count & " <"

                    If Integer.Parse(Nbr.Count) <= 1 Then
                        MsgBox("Bra7met omek afsa3 chway :)", vbExclamation, "Not an alert")
                    End If

                    If Integer.Parse(Nbr.Count) > 20 Then
                        MsgBox("Barchaaa absence  :)", vbCritical, "ALERT")
                    End If

                    Dim cls As Match = Regex.Match(Notes, "document.getElementById\(\'td_classe\'\).innerHTML\=\'LFSI\-(.*?)\'")
                    nomClass.Text = "Class: LFSI - " & cls.Groups(1).Value

                    cell0.Text = "Fondements.I.A"
                    cell1.Text = "Interfaces Homme Machines"
                    cell2.Text = "JEE"
                    cell3.Text = "Programmation Web dynamique"
                    cell4.Text = "Sécurité informatique"
                    cell5.Text = "Technique de communication"
                    cell6.Text = "Anglais"
                    cell7.Text = "Français"
                    cell8.Text = "Réseaux II"
                    cell9.Text = "Programmation Systéme"
                    cell10.Text = "Systéme Répartis"
                    cell11.Text = "Téchnique Multimédia"


                    Dim c00 As Match = Regex.Match(Notes, "DS: <b>(.*?)</b> \(<i><small>26/11/2018</small></i>\)</td>")
                    Dim c01 As Match = Regex.Match(Notes, "")
                    Dim c02 As Match = Regex.Match(Notes, "")
                    Dim c03 As Match = Regex.Match(Notes, "")
                    Dim c04 As Match = Regex.Match(Notes, "DS: <b>(.*?)</b> \(<i><small>27/11/2018</small></i>\)</td>")
                    Dim c05 As Match = Regex.Match(Notes, "")
                    Dim c06 As Match = Regex.Match(Notes, "Anglais: <b>(.*?)</b>")
                    Dim c07 As Match = Regex.Match(Notes, "")
                    Dim c08 As Match = Regex.Match(Notes, "")
                    Dim c09 As Match = Regex.Match(Notes, "Prog. Syst: <b>(.*?)</b>")
                    Dim c010 As Match = Regex.Match(Notes, "")
                    Dim c011 As Match = Regex.Match(Notes, "Nouvelle évaluation: <b>(.*?)</b>")

                    cell00.Text = c00.Groups(1).Value
                    cell01.Text = c01.Groups(1).Value
                    cell02.Text = c02.Groups(1).Value
                    cell03.Text = c03.Groups(1).Value
                    cell04.Text = c04.Groups(1).Value
                    cell05.Text = c05.Groups(1).Value
                    cell06.Text = c06.Groups(1).Value
                    cell07.Text = c07.Groups(1).Value
                    cell08.Text = c08.Groups(1).Value
                    cell09.Text = c09.Groups(1).Value
                    cell010.Text = c010.Groups(1).Value
                    cell011.Text = c011.Groups(1).Value

                End If
            Catch
                Label3.Text = "Loading % " & ProgBar.Value.ToString
                ServerState.BackColor = Color.Red
                MsgBox("No response from server! Try again later :\)")
            End Try

        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgBar.Value = 0
        Label3.Text = "Loading % " & ProgBar.Value.ToString
        If (V = 1) Then
            Reset()
            ResetText()
            V = 0
        End If

        Dim IM As New Thread(AddressOf Login) : IM.Start()

        V = 1
        ProgBar.Value = 20
        Label3.Text = "Loading % " & ProgBar.Value.ToString
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MsgBox("Created by" & vbCrLf & "Khalil Mejdi" & vbCrLf & "LFSI 3 Release", vbInformation, "Informations")
    End Sub

End Class
