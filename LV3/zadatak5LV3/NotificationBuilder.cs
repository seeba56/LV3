using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak5LV3
{
    class NotificationBuilder : IBuilder
    {
        private String author;
        private String title;
        private DateTime time;
        private Category level;
        private ConsoleColor color;
        private String text;

        public IBuilder SetAuthor(String author) { this.author = author; return this; }
        public IBuilder SetTitle(String title) { this.title = title; return this; }
        public IBuilder SetTime(DateTime time)
        { this.time = DateTime.Now; return this; }
        public IBuilder SetLevel(Category level)
        { this.level = level; return this; }
        public IBuilder SetColor(ConsoleColor color)
        { this.color = color; return this; }
        public IBuilder SetText(String text)
        { this.text = text; return this; }

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, color);
        }
        public void Display(ConsoleNotification notification)
        {
            Console.ForegroundColor = notification.Color;
            Console.Write(notification.Author + ": ");
            Console.WriteLine(notification.Title);
            Console.WriteLine(notification.Timestamp.ToString());
            Console.WriteLine(notification.Text);
            Console.WriteLine(notification.Level);
            Console.ResetColor();
        }
    }
}

