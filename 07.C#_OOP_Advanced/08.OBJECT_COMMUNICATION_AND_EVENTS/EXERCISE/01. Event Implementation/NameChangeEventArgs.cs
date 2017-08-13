namespace _01.Event_Implementation
{
    public class NameChangeEventArgs
    {
        private string name;

        public NameChangeEventArgs(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
    }
}