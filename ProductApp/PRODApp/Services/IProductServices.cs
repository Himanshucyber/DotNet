using PRODApp.Models;
namespace PRODApp.Services;

public interface IProductService{
    public List<Product> GetAll();

    public bool Insert(Product prod);

    public bool Update();

    public bool Delete();

    
}

