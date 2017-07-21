using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Robot : IId
{
    private string model;
    private string id;

    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }

    public string Model
    {
        get { return this.model; }
        protected set { this.model = value; }
    }

    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }
}
