Public Class MazeGame
    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(320, 430)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label20.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label60.MouseEnter, Label59.MouseEnter
        MessageBox.Show("Try Again :)")
        MoveToStart()
    End Sub

    Private Sub Finish_MouseEnter(sender As Object, e As EventArgs)
        MessageBox.Show("Well Done!")
        Close()
    End Sub
End Class