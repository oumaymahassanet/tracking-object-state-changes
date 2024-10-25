using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp2.models
{
    public class State
    {
        public string Name { get; private set; }

        public State(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Le nom de l'état ne peut pas être nul ou vide.");
            }
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
