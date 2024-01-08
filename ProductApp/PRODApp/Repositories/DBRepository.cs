using PRODApp.Models;
using MySql.Data.MySqlClient;

namespace PRODApp.Repository;

public class MySqlDBManger{

        public MySqlDBManger(){

        }

   public List<Product> GetAll(){
        List<Product> products = new List<Product>();
//To Get Connection create obj of MySqlConnection
        MySqlConnection con = new MySqlConnection();
// 
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


}