Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Thank you for ordering with Jamess Foo", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form1.TextBox1.Text = Label1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim home As Double
        home = ComboBox1.SelectedIndex

        If ComboBox1.SelectedIndex = 0 Then
            home = 0.00
        ElseIf ComboBox1.SelectedIndex = 1 Then
            home = 20.0
        End If

        If RadioButton1.Checked = True Then
            Dim price As Double = 35
            Dim qty = Convert.ToInt32(TextBox1.Text)
            Dim tot As Double = (price * qty) + home
            TextBox2.Text = "You have selected " & TextBox1.Text & " set of " & RadioButton1.Text()
            TextBox3.Text = "Total price is RM " & tot
        ElseIf RadioButton2.Checked = True Then
            Dim price As Double = 25
            Dim qty = Convert.ToInt32(TextBox1.Text)
            Dim tot As Double = (price * qty) + home
            TextBox2.Text = "You have selected " & TextBox1.Text & " set of " & RadioButton2.Text()
            TextBox3.Text = "Total price is RM " & tot
        ElseIf RadioButton3.Checked = True Then
            Dim price As Double = 20
            Dim qty = Convert.ToInt32(TextBox1.Text)
            Dim tot As Double = (price * qty) + home
            TextBox2.Text = "You have selected " & TextBox1.Text & " set of " & RadioButton3.Text()
            TextBox3.Text = "Total price is RM " & tot
        ElseIf RadioButton4.Checked = True Then
            Dim price As Double = 15
            Dim qty = Convert.ToInt32(TextBox1.Text)
            Dim tot As Double = (price * qty) + home
            TextBox2.Text = "You have selected " & TextBox1.Text & " set of " & RadioButton4.Text()
            TextBox3.Text = "Total price is RM " & tot
        ElseIf RadioButton5.Checked = True Then
            Dim price As Double = 9
            Dim qty = Convert.ToInt32(TextBox1.Text)
            Dim tot As Double = (price * qty) + home
            TextBox2.Text = "You have selected " & TextBox1.Text & " set of " & RadioButton5.Text()
            TextBox3.Text = "Total price is RM " & tot
        End If



    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Pick-Up")
        ComboBox1.Items.Add("Home Delivery (Add RM20.00)")
    End Sub
End Class