using Core.AbstractClasses;
using Core.Interfaces;
using Domain.User.Validators;
using FluentValidation;

namespace Domain.User.ValueObjects;

public sealed class Password(IHashing hashing, string password) : ValueObject<string>(password)
{
  protected override AbstractValidator<string> Schema { get; } = new PasswordValidator();
  private IHashing Hashing { get; } = hashing;

  public static Password Make(IHashing crypto, string password)
  {
    return new(crypto, password);
  }

  protected override void Set(string value)
  {
    base.Set(value);
    RawValue = Hashing.Hash(value); 
  }
}