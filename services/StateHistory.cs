using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testApp2.models;

namespace testApp2.services
{
    public class StateHistory
    {
        private readonly List<StateTransition> _transitions = new List<StateTransition>();

        public void AddTransition(StateTransition transition)
        {
            if (transition == null) throw new ArgumentNullException(nameof(transition));
            _transitions.Add(transition);
        }

        public IEnumerable<StateTransition> GetHistory()
        {
            return _transitions;
        }

        public void DisplayHistory()
        {
            foreach (var transition in _transitions)
            {
                Console.WriteLine(transition);
            }
        }
    }
}
