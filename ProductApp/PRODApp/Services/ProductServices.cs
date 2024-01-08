using PRODApp.Services;
using PRODApp.Models;
using PRODApp.Services;
using PRODApp.Repositories;
using PRODApp.Repository;

public class ProductServices:IProductService{

 List<Product> products = new List<Product>();

 RepositoryManager mgr = new RepositoryManager();
  String filename=@"C:\Users\HP\Desktop\Projects\DotNet\ProductApp/ProductApp.json";
  
   MySqlDBManger dbmgr=new MySqlDBManger();
    public List<Product> GetAll(){
        
    //    products= mgr.DeSerialize(filename); 

    products=dbmgr.GetAll();
        return products;
    }

    public bool Insert(Product prod){
       // products= mgr.DeSerialize(filename);
      bool result=dbmgr.Insert(prod);
        // products.Add(prod);
        //Serialize(List<Product> products,string fileName)
        // mgr.Serialize(products,filename);
        return result;
    }
    public bool Update(){
        return true;
    }
    public bool Delete(){
        return true;
    }

}