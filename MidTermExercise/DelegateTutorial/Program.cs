// Delegate
    // Pointer function

public delegate void MyDelegate();
class Program
{
    static void Main(){
        SMS sms = new();
        Email email = new();
        
        // Assign methods to delegate
        MyDelegate delegates = sms.SMSNotify;
        delegates += email.EmailNotify;
        delegates += email.SendEmailToOther;

        // Run the delegate
        // delegates.Invoke();
        delegates();
    }
}

public class SMS{
    public void SMSNotify(){
        System.Console.WriteLine("SMS notify");
    }
}
public class Email{
    public void EmailNotify(){
        System.Console.WriteLine("Email notify");
    }
    public void SendEmailToOther(){
        System.Console.WriteLine("Send email to other");
    }
}
