using System.Collections.Generic;

public interface IClient
{
    IList<ITweet> Tweets { get; set; }

    string Tweet(ITweet tweet);

    string ShowLastTweet();
}