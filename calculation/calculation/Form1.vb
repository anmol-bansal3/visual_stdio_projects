Friend Class Form1

    Dim b, r, total As Integer
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            Label2.Visible = True
            TextBox1.Visible = True
        Else
            Label2.Visible = False
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label3.Visible = True
            TextBox2.Visible = True
        Else
            Label3.Visible = False
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        b = Val(TextBox1.Text) * 600
        r = Val(TextBox2.Text) * 200
        total = r + b
        TextBox3.Text = total
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Visible = False
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox2.Visible = False
        CheckBox1.Checked = 0
        CheckBox2.Checked = 0
        TextBox3.Text = 0
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        TextBox2.Visible = False
        Label2.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox3.Text, True)
    End Sub
End Class
