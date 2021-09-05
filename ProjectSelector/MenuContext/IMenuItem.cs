namespace ProjectSelector.MenuContext
{
    using ProjectSelector.ObjectManagement;

    public interface IMenuItem : IObject
    {
        public string Text { get; set; }

        void Select();

        void Enable();
    }
}