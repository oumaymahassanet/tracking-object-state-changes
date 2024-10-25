using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp2.models
{
    public class StateTransition
    {
        public DateTime TransitionDate { get; private set; }
        public State State { get; private set; }
        public string Description { get; private set; }

        public StateTransition(State state, string description)
        {
            State = state ?? throw new ArgumentNullException(nameof(state));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            TransitionDate = DateTime.Now;
        }

        public override string ToString()
        {
            return "State: " + State.Name + ", Date: " + TransitionDate + ", Description: " + (Description ?? "No description");
        }
    }
}
