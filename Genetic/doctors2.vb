Public Class doctors2
    Dim Conn1 As New OleDb.OleDbConnection, conn2 As New OleDb.OleDbConnection
    Dim Cmd1 As New OleDb.OleDbCommand, cmd2 As New OleDb.OleDbCommand
    Dim ds As New DataSet, I As Integer, ds1 As New DataSet
    Private Sub doctors2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.user2' table. You can move, or remove it, as needed.
        Me.User2TableAdapter.Fill(Me.DatabaseDataSet.user2)
        DataGridView1.Refresh()
        Dim types As String
        types = "پزشک معالج"
        Conn1.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=|DataDirectory|\Database.mdb"
        Cmd1.Connection = Conn1
        Cmd1.CommandText = "SELECT * FROM user2 where Type ='" + types + "'"
        Dim da As New OleDb.OleDbDataAdapter(Cmd1.CommandText, Conn1)
        Conn1.Open()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Update()
        Me.DataGridView1.Columns.Item(1).Visible = False
        Me.DataGridView1.Columns.Item(2).Visible = False
        Me.DataGridView1.Columns.Item(3).Visible = False
        DataGridView1.Refresh()
        Conn1.Close()
    End Sub
End Class