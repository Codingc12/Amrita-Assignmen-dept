using MySql.Data;
using System;


namespace Sept.Data;
public class DeptView
{
    MySql.Data.MySqlClient.MySqlConnection conn;
    string myConnectionString;
    public DeptView()
    {
        this.myConnectionString = "server=localhost;uid=root;" +
    "pwd=10032004@Ra;database=project01";

        try
        {
            this.conn = new MySql.Data.MySqlClient.MySqlConnection();
            this.conn.ConnectionString = myConnectionString;
            this.conn.Open();
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            System.Console.Write("Ramanan");
        }
    }


    public void Insert(string name_)
    {
        string name_p = $"CALL insert_(name_);";
        MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(name_p,conn);
        command.ExecuteReader();
       

    }


    public void Delete_(string name_)
    {
        string name_p = $"CALL delete_(name_);";
        MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(name_p, conn);
        command.ExecuteReader();

    }

    public MySql.Data.MySqlClient.MySqlDataReader  Select(int id)
    {
        string name_p = $"CALL find_name(id);";
        MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(name_p, conn);
        MySql.Data.MySqlClient.MySqlDataReader dt = command.ExecuteReader();
        return dt; 
    }

    public int closeconnection()
    {
        conn.Close();
        return 1;

    }

    



}