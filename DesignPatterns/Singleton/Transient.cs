namespace SingletonTest
{
    public interface ITransient
    {
        public Task<int> GetRandom();
    }
    public class TransientRandomClass : ITransient    
    {
        private readonly int Random;
        public TransientRandomClass()
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
