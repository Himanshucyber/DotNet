namespace PRODApp.Models;
[Serializable]
public class Product{

    public int ProdID{get;set;}
    public String ProdName{get;set;}
    public String ProdDesc{get;set;}

    public float ProdPrice{get;set;}


    
    /*public Product(int prodID,String prodName,String prodDesc,float prodPrice){
        this.prodID=prodID;
        this.prodName=prodName;
        this.prodDesc=prodDesc;
        this.prodPrice=prodPrice;
    }*/

}