namespace ProjectSelector.MenuContext
{
    public interface IMenuItem : IMenuObject
    {
        public string Text { get; set; }

        void Select();

        void Enable();
    }
}