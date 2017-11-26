using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Client.MusicStreamingService;

namespace Client
{
    class Program
    {

        private static int countMusicsByClient1 = 0;
        private static int countMusicsByClient2 = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to start consuming musics...");
            Console.ReadLine();


            Music[] musics;

            using (var cli = new MusicStreamingClient())
            {
                cli.Open();
                musics = cli.GetAvaiableMusics();
                cli.Close();
            }

            Thread client1 = new Thread(ExecuteAsClient);
            client1.Start();
            Thread client2 = new Thread(ExecuteAsClient2);
            client2.Start();

            while (client1.IsAlive || client2.IsAlive)
            {
                //Do something
            }

            Console.WriteLine($"Quantidade de Musicas consumidas pela primeira thread = {countMusicsByClient1}");
            Console.WriteLine($"Quantidade de Musicas consumidas pela segunda thread = {countMusicsByClient2}");

            Console.ReadLine();

        }

        private static void ExecuteAsClient()
        {
            Music music;
            using (var cli = new MusicStreamingClient())
            {
                cli.Open();
                do
                {
                    try
                    {
                        music = cli.StreamMusic();
                    }
                    catch (FaultException<EmptyQueueException> ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                    if (music != null)
                        countMusicsByClient1++;
                } while (music != null);
                cli.Close();
            }

        }
        private static void ExecuteAsClient2()
        {
            Music music;
            using (var cli = new MusicStreamingClient())
            {
                cli.Open();
                do
                {
                    try
                    {
                        music = cli.StreamMusic();
                    }
                    catch (FaultException<EmptyQueueException> ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                    if (music != null)
                        countMusicsByClient2++;
                } while (music != null);
                cli.Close();
            }
        }
    }
}
