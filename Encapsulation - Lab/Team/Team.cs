﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public IReadOnlyList<Person> FirstTeam
        {
            get
            {
                return this.firstTeam;
            }
        }

        public IReadOnlyList<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam;
            }
        }


        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }
    }
}
