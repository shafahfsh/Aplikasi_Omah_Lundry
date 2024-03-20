Imports MySql.Data.MySqClient
Imports MySql.Data.MySqlClient
Imports System.Data.Common

Public Class Login

    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim SDA As MySqlDataAdapter
    Dim Reader As MySqlDataReader
    Dim DS As DataSet
    Sub koneksi()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "datasource=localhost;port=3306;username=root;password=;database=omahlaundry"
        If MySqlConn.State = ConnectionState.Closed Then MySqlConn.Open()

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.ClientSize = New System.Drawing.Size(480, 339)
        Me.Name = "Login"
        Me.ResumeLayout(False)

    End Sub
End Class