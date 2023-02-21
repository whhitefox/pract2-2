using System;

namespace Pract2
{
    public class Zametka
    {
        public string name;
        public string description;
        public DateTime date;

        public Zametka(string name, string description, DateTime date)
        {
            this.name = name;
            this.description = description;
            this.date = date;
        }
    }
}
