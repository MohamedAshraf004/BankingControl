namespace Application.Contracts.Seeding
{
    public interface IDbInitializer
    {
        Task Initialize();
    }
}