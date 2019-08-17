Module Module1
    Sub Showvalue(ByVal butt As Button)
        Form1.Result.Text = Val(Form1.Result.Text & butt.Text)
        Form1.Collector.Text = Val(Form1.Collector.Text & butt.Text)
    End Sub
    Sub arithematic(ByVal butt As Button)
        Form1.value1 = Val(Form1.Result.Text)
        Form1.oper = butt.Text
        Select Case Form1.oper
            Case "+"
                Form1.Collector.Text = Form1.Collector.Text & "+"
            Case "-"
                Form1.Collector.Text = Form1.Collector.Text & "-"
            Case "*"
                Form1.Collector.Text = Form1.Collector.Text & "*"
            Case "/"
                Form1.Collector.Text = Form1.Collector.Text & "/"
            Case "x^2"
                Form1.Collector.Text = Form1.Collector.Text & "^2"
            Case "v"
                Form1.Collector.Text = "v" & Form1.Collector.Text
            Case "%"
                Form1.Collector.Text = Form1.Collector.Text & "%"
        End Select
        Form1.Result.Text = ""
        Select Case Form1.oper
            Case "+"
                Form1.Result.Text = "+"
            Case "-"
                Form1.Result.Text = "-"
            Case "*"
                Form1.Result.Text = "*"
            Case "/"
                Form1.Result.Text = "/"
            Case "x^2"
                Form1.Result.Text = "^2"
            Case "v"
                Form1.Result.Text = "v"
            Case "%"
                Form1.Result.Text = "%"
        End Select
        Form1.Result.Text = ""
    End Sub

    Sub calculate()
        Select Case Form1.oper
            Case "+"
                Form1.Result.Text = Form1.value1 + Val(Form1.Result.Text)
            Case "-"
                Form1.Result.Text = Form1.value1 - Val(Form1.Result.Text)
            Case "*"
                Form1.Result.Text = Form1.value1 * Val(Form1.Result.Text)
            Case "/"
                Form1.Result.Text = Form1.value1 / Val(Form1.Result.Text)
            Case "x^2"
                Form1.Result.Text = Form1.value1 * Form1.value1
            Case "v"
                Form1.Result.Text = Math.Sqrt(Form1.value1)
            Case "%"
                Form1.Result.Text = Form1.Result.Text
        End Select
         End Sub
End Module
