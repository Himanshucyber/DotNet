namespace Banking;

public class Account{

public event Handler notify;
public  event Handler underBalance;
public event Handler overBalance;

private String  accountNum{get;set;}

private String holderName{get;set;}

private float balance{get;set;}

public Account(String accountNum,String holderName){
     this.accountNum=accountNum;
     this.holderName=holderName;
     this.balance=500;
}









}