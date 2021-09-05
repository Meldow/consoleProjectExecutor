namespace ProjectSelector.MenuContext
{
    using System.Collections.Generic;
    using ProjectSelector.ObjectManagement;

    public interface IMenu : IObject
    {
        public string Title { get; set; }

        public List<IMenuItem> MenuItems { get; set; }

        void Select(IMenuItem menuItem);

        void Select(int menuItemIndex);
    }
}