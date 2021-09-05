namespace SampleProjectSolution
{
    using System;
    using System.Threading.Tasks;
    using Common;

    public class SampleProject : IProject
    {
        public string Id { get; set; } = "SampleProject";

        public SampleProject()
        {
        }

        public SampleProject(string id)
        {
            this.Id = id;
        }

        public async Task Execute()
        {
            Console.Write("\nLoading.");

            for (var i = 0; i < 5; i++)
            {
                await Task.Delay(1000);
                Console.Write(".");
            }

            Console.WriteLine("Finished SampleProject!");
        }
    }
}