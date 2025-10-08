using Domain.User.Validators;

namespace Presentation;

public class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Hello World");

    var email = new EmailValidator();

    var myEmail = email.Validate("alanreisanjo@gmail.com");

    Console.WriteLine(myEmail.IsValid);
  }
}
