using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Key_Tracking_Class
{
    public class KeyListener
    {
        public event EventHandler EnterKeyPressed;
        public event EventHandler SpaceKeyPressed;
        public event EventHandler EscapeKeyPressed;
        public event EventHandler F1KeyPressed;
        public event EventHandler LeftKeyPressed;
        public event EventHandler RightKeyPressed;
        public event EventHandler UpKeyPressed;
        public event EventHandler DownKeyPressed;

        public void Listen()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        EnterKeyPressed?.Invoke(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.Spacebar:
                        SpaceKeyPressed?.Invoke(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.Escape:
                        EscapeKeyPressed?.Invoke(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.F1:
                        F1KeyPressed?.Invoke(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.LeftArrow:
                        LeftKeyPressed?.Invoke(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.RightArrow:
                        RightKeyPressed?.Invoke(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.UpArrow:
                        UpKeyPressed?.Invoke(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.DownArrow:
                        DownKeyPressed?.Invoke(this, EventArgs.Empty);
                        break;
                }
            }
        }
    }
    public class Person
    {
        private readonly KeyListener keyListener;

        public Person()
        {
            keyListener = new KeyListener();
            keyListener.EnterKeyPressed += OnEnterKeyPressed;
            keyListener.SpaceKeyPressed += OnSpaceKeyPressed;
            keyListener.Listen();
        }

        private void OnEnterKeyPressed(object sender, EventArgs e)
        {
            Select();
        }

        private void OnSpaceKeyPressed(object sender, EventArgs e)
        {
            Jump();
        }

        public void Jump()
        {
            Console.WriteLine("Jumping!");
        }

        public void Select()
        {
            Console.WriteLine("Selecting!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            KeyListener keyListener = new KeyListener();

            keyListener.EnterKeyPressed += (sender, e) =>
            {
                Console.WriteLine("Enter key pressed");
            };
            keyListener.SpaceKeyPressed += (sender, e) =>
            {
                Console.WriteLine("Space key pressed");
            };
            keyListener.EscapeKeyPressed += (sender, e) =>
            {
                Console.WriteLine("Escape key pressed");
            };
            keyListener.F1KeyPressed += (sender, e) =>
            {
                Console.WriteLine("F1 key pressed");
            };
            keyListener.LeftKeyPressed += (sender, e) =>
            {
                Console.WriteLine("Left arrow key pressed");
            };
            keyListener.RightKeyPressed += (sender, e) =>
            {
                Console.WriteLine("Right arrow key pressed");
            };
            keyListener.UpKeyPressed += (sender, e) =>
            {
                Console.WriteLine("Up arrow key pressed");
            };
            keyListener.DownKeyPressed += (sender, e) =>
            {
                Console.WriteLine("Down arrow key pressed");
            };
            keyListener.Listen();
            var pers = new Person();
        }
    }

}
