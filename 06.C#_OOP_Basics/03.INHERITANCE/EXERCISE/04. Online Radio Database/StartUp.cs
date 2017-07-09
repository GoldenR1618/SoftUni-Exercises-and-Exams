using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<Song> playlist = new List<Song>();

        int n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            try
            {
                string[] input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string artistName = input[0];
                string songName = input[1];

                try
                {
                    List<long> timeTokens = input[2].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
                }
                catch (Exception)
                {
                    throw new ArgumentException("Invalid song length.");
                }
            
                Song song = new Song(artistName, songName, input[2]);
                playlist.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine($"Songs added: {playlist.Count}");
        TimeSpan result = PlaylistLength(playlist);
        Console.WriteLine($"Playlist length: {result.Hours}h {result.Minutes}m {result.Seconds}s");
    }

    private static TimeSpan PlaylistLength(List<Song> list)
    {
        long totalLength = 0;

        foreach (var song in list)
        {
            string[] split = song.SongLength.Split(':');
            int minutes = int.Parse(split[0]);
            int seconds = int.Parse(split[1]);

            totalLength += minutes * 60 + seconds;
        }

        return TimeSpan.FromSeconds(totalLength);
    }
}
