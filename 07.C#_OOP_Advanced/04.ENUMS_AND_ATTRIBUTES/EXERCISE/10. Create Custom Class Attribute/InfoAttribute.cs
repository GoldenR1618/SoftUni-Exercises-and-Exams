using System;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Class)]
public class InfoAttribute : Attribute
{
    private string author;
    private int revision;
    private string description;
    private List<string> reviewers;

    public InfoAttribute(string author, int revision, string description, params string[] reviewers)
    {
        this.Author = author;
        this.Revision = revision;
        this.Description = description;
        this.Reviewers = new List<string>(reviewers);
    }

    public string Author
    {
        get { return this.author; }
        private set { this.author = value; }
    }

    public int Revision
    {
        get { return this.revision; }
        private set { this.revision = value; }
    }

    public string Description
    {
        get { return this.description; }
        private set { this.description = value; }
    }

    public List<string> Reviewers
    {
        get { return this.reviewers; }
        private set { this.reviewers = value; }
    }
}