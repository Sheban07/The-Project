Imports System.Data.SqlClient
Public Class Form1
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Email_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub

    Private Sub Email_GotFocus(sender As Object, e As EventArgs) Handles Email.GotFocus
        If Email.Text = "Enter your email" Then
            Email.Text = ""
            Email.ForeColor = Color.Black

        End If
    End Sub

    Private Sub Email_LostFocus(sender As Object, e As EventArgs) Handles Email.LostFocus
        If Email.Text = "" Then
            Email.Text = "Enter your email"
            Email.ForeColor = Color.DarkGray

        End If
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Password_GotFocus(sender As Object, e As EventArgs) Handles Password.GotFocus
        If Password.Text = "Enter your password" Then
            Password.Text = ""
            Password.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Password_LostFocus(sender As Object, e As EventArgs) Handles Password.LostFocus
        If Password.Text = "" Then
            Password.Text = "Enter your password"
            Password.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection("Data Source=DESKTOP-LH64PJC\SQLEXPRESS;Initial Catalog=ExamBooking;Integrated Security=True")

        Dim command As New SqlCommand("select * from Registration where Username = @username and Password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = Email.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Password.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count <= 0 Then
            MessageBox.Show("Username or Password are incorrect")

        Else
            MessageBox.Show("Login successfully")

            Me.Hide()
            Form3.Show()


        End If




    End Sub


End Class
