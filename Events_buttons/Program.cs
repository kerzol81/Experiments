using System;

namespace Events_buttons
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button();
            

            Console.ReadKey();
        }
    }
    class Button
    {
        public EventHandler ClickEvent;
        public void OnClick()
        {
            ClickEvent.Invoke(this, EventArgs.Empty);
        }
    }
}
