namespace Domain.Support.User.Dtos;

public sealed record AddressDTO
{
  public required string ZipCode { get; set; }
  public required string State { get; set; }
  public required string City { get; set; }
  public required string Neighborhood { get; set; }
  public required string Street { get; set; }
  public required int Number { get; set; }
}