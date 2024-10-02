Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Public Class Form3
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Passport.Click
        Using OpenFileDialog As New OpenFileDialog()
            OpenFileDialog.InitialDirectory = "C:\"
            OpenFileDialog.Filter = "Images Files|*.jpg;*.jpeg;*.png;*.bmp"
            OpenFileDialog.Title = "Select an Image"

            If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                Passport.Image = Image.FromFile(OpenFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If FirstName.Text = "" Or LastName.Text = "" Or Department.Text = "" Or Course.Text = "" Or sNumber.Text = "" Or ExamYear.Text = "" Or UnitsName.Text = "" Or ExamType.Text = "" Or ExamSeries.Text = "" Or NumberOfUnits.Text = "" Then
            MsgBox("All fields are required")

        Else

            Dim fname As String = FirstName.Text
            Dim lname As String = LastName.Text
            Dim depart As String = Department.Text
            Dim coz As String = Course.Text
            Dim sNO As String = sNumber.Text
            Dim examT As String = ExamType.Text
            Dim examY As String = ExamYear.Text
            Dim nOfUnits As String = NumberOfUnits.Text
            Dim examS As String = ExamSeries.Text
            Dim units As String = UnitsName.Text


            Dim query As String = "insert into ExamBookingRecords values(@fName,@lName,@department,@course,@studentNO,@examYear,@examType,@numberOfUnits,@examSeries,@units)"


            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-LH64PJC\SQLEXPRESS;Initial Catalog=ExamBooking;Integrated Security=True")
                Using cnn As SqlCommand = New SqlCommand(query, con)
                    cnn.Parameters.AddWithValue("@fName", fname)
                    cnn.Parameters.AddWithValue("@lName", lname)
                    cnn.Parameters.AddWithValue("@department", depart)
                    cnn.Parameters.AddWithValue("@course", coz)
                    cnn.Parameters.AddWithValue("@studentNO", sNO)
                    cnn.Parameters.AddWithValue("@examYear", examY)
                    cnn.Parameters.AddWithValue("@examType", examT)
                    cnn.Parameters.AddWithValue("@numberOfUnits", nOfUnits)
                    cnn.Parameters.AddWithValue("@examSeries", examS)
                    cnn.Parameters.AddWithValue("@units", units)


                    con.Open()

                    cnn.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Your have successfully booked the exam for " + examY + " " + examS + " series")




                End Using
            End Using

        End If


        FirstName.Text = String.Empty
        LastName.Text = String.Empty
        Department.Text = String.Empty
        Course.Text = String.Empty
        sNumber.Text = String.Empty
        ExamType.Text = String.Empty
        ExamYear.Text = String.Empty
        ExamSeries.Text = String.Empty
        NumberOfUnits.Text = String.Empty
        UnitsName.Text = String.Empty


    End Sub


End Class