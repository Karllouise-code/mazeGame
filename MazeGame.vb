Public Class MazeGame
    Dim Life As Integer = 5
    Public Sub New()
        InitializeComponent()
        MessageBox.Show("GUESS THE FINISH PATH" & Environment.NewLine & Environment.NewLine & "Use Mouse to control, avoid touching the LASERS!" & Environment.NewLine & Environment.NewLine & "You have " + Life.ToString + " chance to complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(20, 450)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label53.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label58.MouseEnter, PictureBox9.MouseEnter, PictureBox8.MouseEnter, PictureBox7.MouseEnter, PictureBox6.MouseEnter, PictureBox5.MouseEnter, PictureBox47.MouseEnter, PictureBox46.MouseEnter, PictureBox45.MouseEnter, PictureBox44.MouseEnter, PictureBox43.MouseEnter, PictureBox42.MouseEnter, PictureBox41.MouseEnter, PictureBox40.MouseEnter, PictureBox4.MouseEnter, PictureBox39.MouseEnter, PictureBox38.MouseEnter, PictureBox37.MouseEnter, PictureBox36.MouseEnter, PictureBox35.MouseEnter, PictureBox34.MouseEnter, PictureBox33.MouseEnter, PictureBox32.MouseEnter, PictureBox31.MouseEnter, PictureBox30.MouseEnter, PictureBox3.MouseEnter, PictureBox29.MouseEnter, PictureBox28.MouseEnter, PictureBox27.MouseEnter, PictureBox26.MouseEnter, PictureBox25.MouseEnter, PictureBox24.MouseEnter, PictureBox23.MouseEnter, PictureBox22.MouseEnter, PictureBox21.MouseEnter, PictureBox20.MouseEnter, PictureBox2.MouseEnter, PictureBox19.MouseEnter, PictureBox18.MouseEnter, PictureBox17.MouseEnter, PictureBox16.MouseEnter, PictureBox15.MouseEnter, PictureBox14.MouseEnter, PictureBox13.MouseEnter, PictureBox12.MouseEnter, PictureBox11.MouseEnter, PictureBox10.MouseEnter, PictureBox1.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label2.MouseEnter, Label1.MouseEnter, Label6.MouseEnter, Label5.MouseEnter
        Life -= 1
        MessageBox.Show("Try Again :) " & Environment.NewLine & "Remaining life: " + Life.ToString)
        If Life <> 0 Then
            MoveToStart()
        Else
            Me.Hide()
            My.Computer.Audio.Play(My.Resources.monsterAudio, AudioPlayMode.Background)
            Surprise.Show()
            BeLazy()
            Dim ans = MessageBox.Show("You are out of lives" & Environment.NewLine & "Do you want to try again?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ans = DialogResult.Yes Then
                Life = 5
                MoveToStart()
                Surprise.Hide()
                Me.Show()
            Else
                Close()
            End If
        End If
    End Sub

    Private Sub Finish_MouseEnter(sender As Object, e As EventArgs) Handles Finish.MouseEnter
        MessageBox.Show("Well Done!")
        Close()
    End Sub

    Public Sub BeLazy()
        For i = 1 To 30
            Threading.Thread.Sleep(100) ' 3 SECONDS DELAY
            Application.DoEvents()
        Next
    End Sub

End Class