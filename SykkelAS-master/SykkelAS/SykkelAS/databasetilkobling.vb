Imports MySql.Data.MySqlClient
Module databasetilkobling
    Public tilkobling As MySqlConnection
    Public Function databaseTilkobling()
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_iini1010_04;Uid=g_iini1010_04;Pwd=QXXLn0wu")
        Return tilkobling
    End Function
End Module
