using PRODApp.Services;
using PRODApp.Models;
using PRODApp.Services;
using PRODApp.Repositories;

public class ProductServices:IProductService{

 List<Product> products = new List<Product>();

 RepositoryManager mgr = new RepositoryManager();
  String filename=@"C:\Users\HP\Desktop\Projects\DotNet\ProductApp/ProductApp.json";
  
    public List<Product> GetAll(){
        
       products= mgr.DeSerialize(filename);
        products.Add(new Product {ProdID=11,ProdName="Caspian Bottle",ProdDesc="BlackBottle",ProdPrice=1999.24f});
        mgr.Serialize(products,filename);
        return products;
    }

    public bool Insert(Product prod){
        products= mgr.DeSerialize(filename);
        products.Add(prod);
        //Serialize(List<Product> products,string fileName)
        mgr.Serialize(products,filename);
        return true;
    }
    public bool Update(){
        return true;
    }
    public bool Delete(){
        return true;
    }

}