namespace Common
{
    using System.Threading.Tasks;

    public interface IProject
    {
        public string Id { get; set; }

        public Task Execute();
    }
}