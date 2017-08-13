namespace SOLID
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Solid
    {
        public static void Main(string[] args)
        {
            //SRP (Single Responsibility Principle) - Every object should have a single responsibility and that responsibility should be entirely encapsulated by the class.
            //  High Cohesion / Low Coupling:
            //      Cohesion
            //          Low: The convenience store.You go there for everything from gas to milk to ATM banking.Products and services have little in common, and the convenience of having them all in one place may not be enough to offset the resulting increase in cost and decrease in quality.
            //          High: The cheese store.They sell cheese.Nothing else. Can't beat 'em when it comes to cheese though.
            //      Coupling
            //          Loose: You and the guy at the convenience store.You communicate through a well - defined protocol to achieve your respective goals - you pay money, he lets you walk out with the bag of Cheetos.Either one of you can be replaced without disrupting the system.
            //          Tight: You and your wife.
            //  Approaches:
            //      Small number of instance variables inside a class.
            //      Each method of a class should manipulate one or more of those variables.
            //      Two modules should exchange as little information as possible.
            //      Is the subsystem easily reusable in another project?


            //OCP (Open/Closed Principle) - Software entities like classes, modules and functions should be open for extension but closed for modifications.
            //  Extensibility – adding new behavior doesn’t require changes over the existing source code.
            //  Reusability – subsystems are suitable for reusing in other projects – modularity.
            //  Approaches:
            //      Parameters - control behavior specifics via a parameter, delegate.
            //      Rely on abstraction, not implementation.
            //          Inheritance / Template Method Pattern.
            //      Composition / Strategy Pattern.
            //          Plug in model(insert new implementation of the interface).
            //          Client code depends on abstraction – utilize Composition to set a inner field.


            //LSP (Liskov Substitution Principle)
            //  Reference to the base class can be replaced with a derived class without affecting the functionality of the program module.
            //  Derived class only extends functionalities of the base class.
            //  Derived class must not remove base class behavior.
            //  Approaches:
            //      Tell Don’t Ask – if you need to check what is the object  - move the behavior inside the object.
            //      New Base Class - two classes share common behavior but are not substitutable, create third from which both derive.
            //      There shouldn’t be any virtual methods in constructors.


            //ISP (Interface Segregation Principle)
            //  Prefer small, cohesive (lean and focused) interfaces.
            //  Divide "fat" interfaces into "role" interfaces.
            //  Approaches:
            //      What does the client see and use?
            //      The “fat” interfaces implement a number of small interfaces with just what you need.
            //      All public members of a class divided in separate classes – again could be thought of as an interface.
            //      Let the client define interfaces – "role" interfaces.


        }
    }
}
