using Banking;
int choice;

NotificationManager mgr=new NotificationManager();
#pragma warning disable CA1806 // Do not ignore method results
NotificationManager
//String accountNum,String holderName,float balance
//String accNum=Console.ReadLine();
Account act1=new Account("101","Himanshu");
#pragma warning restore CA1806 // Do not ignore method results

do
{
Console.WriteLine("Enter Your Choice of Action  1: Deposite 2:Withdraw 3: checkBalance 4: Exit");
choice=int.Parse(Console.ReadLine());
switch(choice){
    case 1:
    
    break;
}
}
while(choice!=4);