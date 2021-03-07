using System;
using System.Collections.Generic;
using System.Text;

namespace BordedControl
{
    public class Citizens : IRobot, IPerson
    {
        private string name;
        private int age;
        private string id;

        public Citizens(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public Citizens(string name, int age, string id) 
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                this.name = value;
            }
        }

        public string Id
        {
            get => this.id;
            private set
            {
                this.id = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                this.age = value;
            }
        }
    }

}
