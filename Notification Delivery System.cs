using System;
class Notification
{
    public virtual void Send(string message)
    {
        Console.WriteLine("Sending notification: " + message);
    }
}
class EmailNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine("Email sent to registered address: " + message);
    }
}
class SmsNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine("SMS sent to mobile number: " + message);
    }
}
class PushNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine("Push notification delivered to device: " + message);
    }
}
class Program
{
    static void Main()
    {
        Notification notificationRef;
        notificationRef = new EmailNotification();
        notificationRef.Send("Server maintenance scheduled at 10 PM");
        notificationRef = new SmsNotification();
        notificationRef.Send("Your OTP is 123456");
        notificationRef = new PushNotification();
        notificationRef.Send("New update available in your app");
    }
}
