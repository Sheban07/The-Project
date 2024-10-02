Imports System.Data.SqlClient

Public Class Form2

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Form1.Show()
        Me.Hide()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub Username_GotFocus(sender As Object, e As EventArgs) Handles Username.GotFocus
        If Username.Text = "Enter your email" Then
            Username.Text = ""
            Username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Username_LostFocus(sender As Object, e As EventArgs) Handles Username.LostFocus
        If Username.Text = "" Then
            Username.Text = "Enter your email"
            Username.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub StudentNO_TextChanged(sender As Object, e As EventArgs) Handles StudentNO.TextChanged

    End Sub

    Private Sub StudentNO_GotFocus(sender As Object, e As EventArgs) Handles StudentNO.GotFocus
        If StudentNO.Text = "Enter your Student Number" Then
            StudentNO.Text = ""
            StudentNO.ForeColor = Color.Black
        End If
    End Sub

    Private Sub StudentNO_LostFocus(sender As Object, e As EventArgs) Handles StudentNO.LostFocus
        If StudentNO.Text = "" Then
            StudentNO.Text = "Enter your Student Number"
            StudentNO.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Pword.TextChanged

    End Sub

    Private Sub Password_GotFocus(sender As Object, e As EventArgs) Handles Pword.GotFocus
        If Pword.Text = "Enter your password" Then
            Pword.Text = ""
            Pword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Password_LostFocus(sender As Object, e As EventArgs) Handles Pword.LostFocus
        If Pword.Text = "" Then
            Pword.Text = "Enter your password"
            Pword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub ConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles ConPword.TextChanged

    End Sub

    Private Sub ConfirmPassword_GotFocus(sender As Object, e As EventArgs) Handles ConPword.GotFocus
        If ConPword.Text = "Confirm your password" Then
            ConPword.Text = ""
            ConPword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ConfirmPassword_LostFocus(sender As Object, e As EventArgs) Handles ConPword.LostFocus
        If ConPword.Text = "" Then
            ConPword.Text = "Confirm your password"
            ConPword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If Username.Text = "" Or StudentNO.Text = "" Or Pword.Text = "" Or ConPword.Text = "" Then
            MsgBox("All fields are required")

        ElseIf Pword.Text <> ConPword.Text Then
            MsgBox("Password did not match")
        Else

            Dim Email As String = Username.Text
            Dim StudentNumber As String = StudentNO.Text
            Dim Password As String = Pword.Text
            Dim ConfirmPassword As String = ConPword.Text

            Dim query As String = "insert into Registration values(@username,@studentNo,@password,@confirmPassword)"



            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-LH64PJC\SQLEXPRESS;Initial Catalog=ExamBooking;Integrated Security=True")
                Using cnn As SqlCommand = New SqlCommand(query, con)
                    cnn.Parameters.AddWithValue("@username", Email)
                    cnn.Parameters.AddWithValue("@studentNo", StudentNumber)
                    cnn.Parameters.AddWithValue("@password", Password)
                    cnn.Parameters.AddWithValue("@confirmPassword", ConfirmPassword)

                    con.Open()

                    cnn.ExecuteNonQuery()

                    con.Close()


                    MessageBox.Show("Registration Successful please login to your account")
                    Me.Dispose()
                    Form3.Show()



                End Using
            End Using


        End If

    End Sub
End Class