using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distributor.WCFMusicStreamManagerService;

namespace Distributor
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new MusicStreamingManagerServiceClient())
            {
                client.Open();
                client.AddMusic("Be Quick or Be Dead", "03:24", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("From Here to Eternity", "03:38", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("Afraid to Shoot Strangers", "06:56", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("Fear Is the Key", "05:35", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("Childhood's End", "04:40", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("Wasting Love", "05:50", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("The Fugitive", "04:54", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("Chains of Misery", "03:37", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("The Apparition", "03:54", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("Judas Be My Guide", "03:08", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("Weekend Warrior", "05:39", "Iron Maiden", "Fear of the Dark");
                client.AddMusic("Fear of the Dark", "07:16", "Iron Maiden", "Fear of the Dark");
                client.Close();
            }
            Console.WriteLine("Musicas Preenchidas! Click Enter to read the Musics...");
            Console.ReadLine();

            Music[] musics;

            using (var client = new MusicStreamingManagerServiceClient())
            {
                client.Open();
                musics = client.GetAllMusics();
                client.Close();
            }

            foreach (var music in musics)
                Console.WriteLine("Music - " + music.Name);

            Console.ReadLine();
        }
    }
}
