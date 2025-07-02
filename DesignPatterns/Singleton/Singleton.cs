namespace SingletonTest
{
    public interface ISingleton
    {
        public Task<int> GetRandom();
    }
    public class SingletonRandomClass : ISingleton
    {
        private readonly int Random;
        public SingletonRandomClass()
        {
            this.Random = new Random().Next(0,100);
        }

        public async Task<int> GetRandom()
        {
            Task.Delay(0).Wait();
            return this.Random;
        }
    }
}
