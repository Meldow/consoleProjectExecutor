namespace ProjectSelector.MenuContext
{
    using System;

    public class MenuItem : IMenuItem
    {
        public string Text { get; set; }

        private MenuItemState state;

        public MenuItem(string text)
        {
            this.Text = text;
        }

        public void Update()
        {
        }

        public void Draw()
        {
            switch (this.state)
            {
                case MenuItemState.Enabled:
                    Console.WriteLine($"{this.Text}");
                    break;
                case MenuItemState.Selected:
                    Console.WriteLine($"> {this.Text} <");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Select()
        {
            this.state = MenuItemState.Selected;
        }

        public void Enable()
        {
            this.state = MenuItemState.Enabled;
        }
    }
}