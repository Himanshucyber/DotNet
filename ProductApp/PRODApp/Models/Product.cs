namespace PRODApp.Models;
[Serializable]
public class Product{

    public int prodID{get;set;}
    public String prodName{get;set;}
    public String prodDesc{get;set;}

    public float prodPrice{get;set;}


    
    /*public Product(int prodID,String prodName,String prodDesc,float prodPrice){
        this.prodID=prodID;
        this.prodName=prodName;
        this.prodDesc=prodDesc;
        this.prodPrice=prodPrice;
    }*/

}