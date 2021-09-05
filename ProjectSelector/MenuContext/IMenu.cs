namespace ProjectSelector.MenuContext
{
    using System.Collections.Generic;

    public interface IMenu : IMenuObject
    {
        public string Title { get; set; }

        public List<IMenuItem> MenuItems { get; set; }

        void Select(IMenuItem menuItem);

        void Select(int menuItemIndex);
    }
}