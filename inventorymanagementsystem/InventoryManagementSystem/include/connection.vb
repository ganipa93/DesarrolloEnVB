Imports MySql.Data.MySqlClient
Module connection
    Public Function mysqldb() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=2012116664;database=db_inventory;sslMode=none")
    End Function
    Public con As MySqlConnection = mysqldb()
End Module
