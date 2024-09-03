
# Calculator Project with GTK



## Version

- GTK#2.0
- Monodevelop 7.8.4 (build 2)
- mono Mono JIT compiler version 6.12.0.200




## Deployment

To compile, use csc:
```bash
   csc MainWindow.cs
```
The compiler will create “MainWindow.exe”, which you can run using:
```bash
   mono MainWindow.exe
```


## Demo

![demo](https://github.com/user-attachments/assets/5843e105-0180-4dd7-b44e-3517c8c758d4)


video: 
https://github.com/user-attachments/assets/fab09dac-2238-40ab-bf5f-8cfb3e27648f


number divided by 0:

![0](https://github.com/user-attachments/assets/7a330cde-ffaf-43ad-a270-f572f9190650)


# Connect with mysql server in monodevelop
## install mysql server
### debian
```bash
   sudo apt-get update
   sudo apt-get install mysql-server
```
check
```bash
   sudo systemctl status mysql
```

use this to connect
```bash
   using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connStr = "server=localhost;user=root;database=nama_database;port=3306;password=kata_sandi";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();

            string sql = "SELECT * FROM nama_tabel";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " -- " + rdr[1]);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        conn.Close();
        Console.WriteLine("Done.");
    }
}

```
