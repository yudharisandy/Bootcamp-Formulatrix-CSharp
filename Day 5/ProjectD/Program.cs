
// Delegate : A way to call many functions from different classes at once
// Also called as "Function Pointer"
// Requirements: Each method must have same return type (ex: void), and same parameter (ex: parameter less)
// Add method to a delegates: delegates += method;
// Run the delegate: delegate() or delegate.invoke();
// Usually implemented in the "void" return type.

//Delegate
//Function Pointer

//Publisher-Subscriber Pattern
public delegate void MyDelegate();
void Main()
{
	Email email = new();
	SMS sms = new();
	MyDelegate delegates = email.EmailNotify;
	delegates += sms.SMSNotify;
	delegates += email.SendEmailToOther;
	
	delegates();
	delegates.Invoke();
}
class Email {
	public void EmailNotify() {
		"Email got notified".Dump();
	}
	public void SendEmailToOther() {
		"Email send notification".Dump();
	}
}
class SMS {
	public void SMSNotify() {
		"SMS got notified".Dump();
	}
}