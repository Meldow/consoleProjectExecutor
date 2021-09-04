namespace SampleProjectSolution
{
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
    }
}