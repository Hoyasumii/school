namespace Domain.User.Services;

public sealed class RemoveUser(IUserRepository repository)
{
  public IUserRepository Repository { get; } = repository;

  public async Task<bool> Run(string targetId)
  {
    var target = await Repository.FindById(targetId)
                ?? throw new Exception();

    return await Repository.Remove(target);
  }
}

// TODO Na camada de aplicação eu vou validar quem está requisitando a remoção. Nesse caso, apenas DIRETORES podem remover alunos