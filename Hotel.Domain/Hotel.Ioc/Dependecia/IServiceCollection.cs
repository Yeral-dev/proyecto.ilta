namespace Hotel.Ioc.Dependecia
{
    public interface IServiceCollection
    {
        void AddScoped<T1, T2>();
        void AddTransient<T1, T2>();
    }
}