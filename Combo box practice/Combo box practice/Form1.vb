Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Bussiness functioning")
        ComboBox1.Items.Add("Mangement")
        ComboBox1.Items.Add("online working")
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        ComboBox2.Text = "select"
    End Sub

    Public Sub ComboBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.Click
        If ComboBox1.Items.Item(0) Then
            Label3.Visible = True
            Label3.TextAlign = "fees of course is 1lakh"
        End If
        If ComboBox1.Items.Then Then
            Label3.Visible = True
            Label3.Enabled = ("fees of course is 2.5lakh")
        End If
        If ComboBox1.Items.Item(2) Then
            Label3.Visible = True
            Label3.Enabled("fees of course is 4lakh")
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        elect Case ComboBox1.SelectedIndex
            Case 0
        ComboBox2.Text = "select"
        ComboBox2.Items.Add("1 year")
            Case 1
        ComboBox2.Text = "select"
        ComboBox2.Items.Add("1.5 year")
            Case 2
        ComboBox2.Text = "select"
        ComboBox2.Items.Add("2 year")
        End Select
    End Sub
End Class
