namespace Banking;

public delegate void Handler();


public class NotificationManager{



    public void sendEmail(){
     Console.WriteLine("Email Send to Your Resister Address !");
    }

    public void sendSMS(){
         Console.WriteLine("SMS Send to Your Resister ! ");
    }

    public void blockAccount(){
         Console.WriteLine("Your Account is temporarly blocked ! ");
    }

    public void deducteTax(){
         Console.WriteLine("Your income tax is deducted from your Account ! ");
    }
}