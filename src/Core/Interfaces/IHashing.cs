namespace Core.Interfaces;

public interface IHashing
{
  public string Hash(string value);
  public string Matches(string encryptedValue, string valueToTesting);
}