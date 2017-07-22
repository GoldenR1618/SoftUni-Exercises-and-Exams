using System;

public class Mission
{
    private string codeName;
    private string state = "inProgress";   //inProgress or Finished

    public Mission(string codeName, string state)
    {
        this.CodeName = codeName;
        this.State = state;
    }

    public string CodeName
    {
        get { return this.codeName; }
        protected set { this.codeName = value; }
    }

    public string State
    {
        get { return this.state; }
        protected set
        {
            if (value == "inProgress" || value == "Finished")
            {
                this.state = value;
            }
            else
            {
                throw new ArgumentException("Invalid mission state");
            }          
        }
    }

    public void CompleteMission()
    {
        state = "Finished";
    }

    public override string ToString()
    {
        return $"Code Name: {this.CodeName} State: {this.State}";
    }
}
