using Mapster;

namespace FullStackPortfolio.DTO.Configuration;

public class BaseDTO<TDto, TEntity> : IRegister where TDto : class, new() where TEntity : class, new()
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<TDto, TEntity>().TwoWays();
    }
}
