using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testApp2.services;

namespace testApp2.models
{
    public class BusinessObject
    {
        public string Name { get; private set; }
        public State CurrentState { get; private set; }
        private readonly StateHistory _history;

        public BusinessObject(string name, State initialState)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Business object name cannot be null or empty.");
            }

            Name = name;
            CurrentState = initialState ?? throw new ArgumentNullException(nameof(initialState));
            _history = new StateHistory();

            // Log the initial state
            _history.AddTransition(new StateTransition(initialState, "Initial state"));
        }

        public void ChangeState(State newState, string description)
        {
            if (newState == null) throw new ArgumentNullException(nameof(newState));
            if (string.IsNullOrEmpty(description)) throw new ArgumentNullException(nameof(description));

            // Update the current state and log the transition
            CurrentState = newState;
            _history.AddTransition(new StateTransition(newState, description));
        }

        public IEnumerable<StateTransition> GetHistory()
        {
            return _history.GetHistory();
        }

        public void DisplayHistory()
        {
            _history.DisplayHistory();
        }
    }
}
