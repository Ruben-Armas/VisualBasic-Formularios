Imports System.Data.SqlClient

Public Class Form1

    ' Cadena de conexión a la base de datos
    'Dim connectionString As String = "Data Source=localhost;Initial Catalog=test;Integrated Security=True"
    'Dim connectionString As String = "Data Source=localhost;Initial Catalog=test;User ID=root;Password="
    Dim connectionString As String = "Data Source=DESKTOP-KBV3VGU\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"

    ' Al cargar el formulario, actualizar el DataGridView
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComprobarConexion()
        ActualizarGrid()
    End Sub

    ' Función para comprobar la conexión a la base de datos
    Private Sub ComprobarConexion()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    ' Crear un nuevo registro en la base de datos
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim nombre As String = TxtName.Text
        Dim edad As Integer = Integer.Parse(TxtAge.Text)
        CrearPersona(nombre, edad)
        ActualizarGrid()
    End Sub

    '' Leer y mostrar todos los registros en el DataGridView
    'Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
    '    ActualizarGrid()
    'End Sub
    '
    ' Actualizar un registro existente en la base de datos
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim id As Integer = Integer.Parse(TxtId.Text)
        Dim nombre As String = TxtName.Text
        Dim edad As Integer = Integer.Parse(TxtAge.Text)
        ActualizarPersona(id, nombre, edad)
        ActualizarGrid()
    End Sub

    ' Eliminar un registro de la base de datos
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim id As Integer = Integer.Parse(TxtId.Text)
        EliminarPersona(id)
        ActualizarGrid()
    End Sub

    ' Función para crear un nuevo registro
    Private Sub CrearPersona(nombre As String, edad As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Personas (name, age) VALUES (@Nombre, @Edad)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Edad", edad)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
    End Sub

    ' Función para leer todos los registros y devolver un DataTable
    Private Function LeerPersonas() As DataTable
        Dim dataTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Personas"
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)

            connection.Open()
            adapter.Fill(dataTable)
            connection.Close()
        End Using
        Return dataTable
    End Function

    ' Función para actualizar un registro existente
    Private Sub ActualizarPersona(id As Integer, nombre As String, edad As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Personas SET name = @Nombre, age = @Edad WHERE Id = @Id"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Id", id)
            command.Parameters.AddWithValue("@Nombre", nombre)
            command.Parameters.AddWithValue("@Edad", edad)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
    End Sub

    ' Función para eliminar un registro
    Private Sub EliminarPersona(id As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM Personas WHERE Id = @Id"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Id", id)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using
    End Sub

    ' Función para actualizar el DataGridView con los datos de la base de datos
    Private Sub ActualizarGrid()
        Dim dataTable As DataTable = LeerPersonas()
        DataGridView1.DataSource = dataTable
    End Sub

End Class
