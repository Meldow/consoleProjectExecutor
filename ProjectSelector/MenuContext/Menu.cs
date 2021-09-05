namespace ProjectSelector.MenuContext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Menu : IMenu
    {
        public string Title { get; set; }

        public List<IMenuItem> MenuItems { get; set; }

        public Menu(string title, List<IMenuItem> menuItems)
        {
            this.Title = title;
            this.MenuItems = menuItems;
        }

        public void Update()
        {
        }

        public void Draw()
        {
            Console.WriteLine($"{this.Title}\n");

            for (var i = 1; i < this.MenuItems.Count; i++)
            {
                this.MenuItems[i].Draw();
            }
        }

        public void Select(IMenuItem menuItem)
        {
            foreach (var item in this.MenuItems)
            {
                item.Enable();
                if (item == menuItem)
                {
                    item.Select();
                }
            }
        }

        public void Select(int menuItemIndex)
        {
            this.Select(this.MenuItems[menuItemIndex]);
        }
    }
}