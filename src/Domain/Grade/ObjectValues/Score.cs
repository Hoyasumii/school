using Core.AbstractClasses;
using Domain.Grade.Validations;
using FluentValidation;

namespace Domain.Grade.ObjectValues;

public sealed class Score(double initialValue) : ObjectValue<double>(initialValue)
{
  protected override AbstractValidator<double> Schema { get; } = new ScoreValidator();
}