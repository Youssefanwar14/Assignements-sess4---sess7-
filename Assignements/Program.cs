using Assignements.Classes;
using Assignements.Interfaces;
using System.Threading.Channels;

namespace Assignements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment - Session 4
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1);

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2);

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3);

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4);

            //D3 = D1 + D2;

            //Console.WriteLine("---------------------------");

            //Console.WriteLine("After adding D3 =>");
            //Console.WriteLine(D3);

            //Console.WriteLine("If number right D4 =>");
            //D4 = D1 + 7800;
            //Console.WriteLine(D4);

            //Console.WriteLine("If number left D4 =>");
            //D4 = 3600 + D1;
            //Console.WriteLine(D4);

            //Console.WriteLine("Increase one minute");
            //D4 = ++D3;
            //Console.WriteLine(D4);

            //Console.WriteLine("Decrease one minute");
            //D4 = --D3;
            //Console.WriteLine(D4);

            //Console.WriteLine("Subtraction: ");
            //D4 = D1 - D2;
            //Console.WriteLine(D4);

            //Console.WriteLine("greater or less than:");
            //Console.WriteLine(D1 > D2);

            #endregion

            #region Assignment - Session 5

            // Question 1

            //ICircle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //Console.WriteLine("--------------------------");

            //IRectangle rec = new Rectangle(20, 10);
            //rec.DisplayShapeInfo();

            // Question 2

            //IAuthenticationService authService = new BasicAuthenticationService();
            //bool IsAuthenticated = authService.AuthenticateUser("Youssef","123467");
            //Console.WriteLine($"User Authentication : {IsAuthenticated}");

            //bool IsAuthorized = authService.AuthorizeUser("Youssef","Admin");
            //Console.WriteLine($"User Authorization : {IsAuthorized}");

            // Question 3

            //INotificationService EmailService = new EmailNotificationService();
            //INotificationService SmsService = new SmsNotificationService();
            //INotificationService PushService = new PushNotificationService();

            //EmailService.SendNotification("youssef@example.com", "Hello from Email!");
            //SmsService.SendNotification("+201012345678", "Hello from SMS!");
            //PushService.SendNotification("YoussefDevice123", "Hello from Push Notification!");

            #endregion

            #region Task
            ICartoonCharacter tom = new Tom("Tom");
            tom.ShowTalent();
            Console.WriteLine();

            ICartoonCharacter jerry = new Jerry("Jerry");
            jerry.ShowTalent();
            Console.WriteLine();

            ICartoonCharacter spike = new Spike("Spike");
            spike.ShowTalent();
            Console.WriteLine();
            #endregion

        } 
    }
}

