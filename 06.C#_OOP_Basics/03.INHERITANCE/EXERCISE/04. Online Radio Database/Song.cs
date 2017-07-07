using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Song
{
    private string artistName;
    private string songName;
    private string songLength;

    public Song(string artistName, string songName, string songLength)
    {
        this.ArtisName = artistName;
        this.SongName = songName;
        this.SongLength = songLength;
    }

    public string ArtisName
    {
        get
        {
            return this.artistName;
        }
        private set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException($"Artist name should be between 3 and 20 symbols.");
            }

            this.artistName = value;
        }
    }
    public string SongName
    {
        get
        {
            return this.songName;
        }
        private set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException($"Song name should be between 3 and 30 symbols.");
            }

            this.songName = value;
        }
    }
    public string SongLength
    {
        get
        {
            return this.songLength;
        }
        private set
        {
            string[] split = value.Split(':');
            long minutes = long.Parse(split[0]);
            long seconds = long.Parse(split[1]);

            if (minutes < 0 || minutes > 14)
            {
                throw new ArgumentException($"Song minutes should be between 0 and 14.");
            }

            if (seconds < 0 || seconds > 59)
            {
                throw new ArgumentException($"Song seconds should be between 0 and 59.");
            }

            this.songLength = value;
        }
    }
}
