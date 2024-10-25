using System;
using testApp2.models;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some states
            State created = new State("Created");
            State inProgress = new State("In Progress");
            State completed = new State("Completed");

            // Create a business object with an initial state
            BusinessObject document = new BusinessObject("Document 1", created);

            // Change the state of the business object
            document.ChangeState(inProgress, "Document processing started.");
            document.ChangeState(completed, "Document processing finished.");

            // Display the history of state transitions
            document.DisplayHistory();

            Console.WriteLine("End of program :)");
        }
    }
}

