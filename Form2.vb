Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "Original Flipped Digital Lab Produced "
        LinkLabel1.Links.Add(0, 37, "www.facebook.com/cljhofdl")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(e.Link.LinkData.ToString())
    End Sub

End Class