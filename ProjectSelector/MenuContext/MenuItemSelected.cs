namespace ProjectSelector.MenuContext
{
    using System;

    public class MenuItemSelected : IMenuItem
    {
        public string Text { get; set; }

        public MenuItemSelected(string text)
        {
            this.Text = text;
        }

        public void Draw()
        {
            Console.WriteLine($" > {this.Text} < ");
        }
    }
}