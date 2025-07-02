namespace SingletonTest
{
    public interface IScope
    {
        public Task<int> GetRandom();
    }
    public class ScopeRandomClass : IScope
    {
        private readonly int Random;
        public ScopeRandomClass()
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
