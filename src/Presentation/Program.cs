using Domain.User.Validators;
using FluentValidation.Validators;

namespace Presentation;

public class Program
{
  public static void Main(string[] args)
  {
    var userType = "Teacher";

    var validation = new UserTypeValidator();

    var a = validation.Validate(userType);

    System.Console.WriteLine(a.IsValid);
  }
}
