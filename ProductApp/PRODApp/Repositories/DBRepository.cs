using PRODApp.Models;
using MySql.Data.MySqlClient;

namespace PRODApp.Repository;

public class MySqlDBManger{

        public MySqlDBManger(){

        }

         List<Product> products = new List<Product>();
//To Get Connection create obj of MySqlConnection
        MySqlConnection con = new MySqlConnection();
// 
       

   public List<Product> GetAll(){

       con.ConnectionString=@"server=localhost; port=3306; user=root; password=Himanshu; database=dotnet";
        MySqlCommand cmd = new MySqlCommand();

        cmd.Connection=con;
        cmd.CommandText="SELECT * from products";

        try{
          con.Open();
          MySqlDataReader reader = cmd.ExecuteReader();
          while(reader.Read()){
            int id = int.Parse(reader["prodId"].ToString());
            String? prodName=reader["prodName"].ToString();
            String? prodDesc=reader["prodDesc"].ToString();
            float? prodPrice=float.Parse(reader["prodPrice"].ToString());

            Product prod = new Product{ProdID=id,ProdName=prodName,ProdDesc=prodDesc,ProdPrice= (float)prodPrice };
            products.Add(prod);





          }



        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
return products;
   }


   public bool Insert(Product prod){

    con.ConnectionString=@"server=localhost; port=3306; user=root; password=Himanshu; database=dotnet";
    MySqlCommand cmd = new MySqlCommand();

    cmd.Connection = con;
    
    // Assuming your products table has columns: prodId, prodName, prodDesc, prodPrice
    cmd.CommandText = "INSERT INTO products (prodId, prodName, prodDesc, prodPrice) VALUES (@prodId, @prodName, @prodDesc, @prodPrice)";

    // Add parameters to prevent SQL injection
    cmd.Parameters.AddWithValue("@prodId", prod.ProdID);
    cmd.Parameters.AddWithValue("@prodName", prod.ProdName);
    cmd.Parameters.AddWithValue("@prodDesc", prod.ProdDesc);
    cmd.Parameters.AddWithValue("@prodPrice", prod.ProdPrice);

    try{
        con.Open();
        int rowsAffected = cmd.ExecuteNonQuery();

        // Check if the insertion was successful
        return rowsAffected > 0;
    }
    catch(Exception e){
        Console.WriteLine(e.Message);
        return false;
    }
    finally{
        con.Close();
    }
}




   


}