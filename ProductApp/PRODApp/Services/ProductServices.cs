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
        products.Add(new Product {prodID=11,prodName="Caspian Bottle",prodDesc="BlackBottle",prodPrice=1999.24f});
        mgr.Serialize(products,filename);
        return products;
    }

    public bool Insert(Product prod){

        return true;
    }
    public bool Update(){
        return true;
    }
    public bool Delete(){
        return true;
    }

}