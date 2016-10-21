using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using System.IO;

namespace LoggerBot
{
    class Program
    {
        static void Main(string[] args) => new Program().Start();

        private DiscordClient _client;

        public void Start()
        {
            _client = new DiscordClient();

            _client.Log.Message += (s, e) => Console.WriteLine($"[{e.Severity}] {e.Source}: {e.Message}");

            _client.MessageReceived += (s, e) =>
            {
                /*string mydocuments = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}";
                string path = mydocuments + @"\LoggerBot-Logs";
                string logpath = $"{path}\\{e.Server.Id}-chatlog.txt";
                DirectoryInfo di = Directory.CreateDirectory(path);
                File.Create(logpath);*/
                using (StreamWriter text = File.AppendText($"{e.Server.Id}-chatlog.txt"))
                {
                    text.WriteLine($"{e.User.Name} ({e.User.Id}) in #{e.Channel.Name} ({e.Channel.Id}): {e.Message.RawText}");                                       //log msg to txt file
                }
                Console.WriteLine($"{e.User.Name} ({e.User.Id}) in #{e.Channel.Name} ({e.Channel.Id}) on {e.Server.Name} ({e.Server.Id}): {e.Message.RawText}");     //log msg to console
            };

            _client.MessageUpdated += (s, e) =>
            {
                /*string mydocuments = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}";
                string path = mydocuments + @"\LoggerBot-Logs";
                string logpath = $"{path}\\{e.Server.Id}-chatlog.txt";
                DirectoryInfo di = Directory.CreateDirectory(path);
                File.Create(logpath);*/
                using (StreamWriter text = File.AppendText($"{e.Server.Id}-chatlog.txt"))
                {
                    text.WriteLine($"{e.User.Name} ({e.User.Id}) edited their message in #{e.Channel.Name} ({e.Channel.Id}) | Before: - {e.Before.RawText} | After: - {e.After.RawText}");                                       //log msg to txt file

                }
                Console.WriteLine($"{e.User.Name} ({e.User.Id}) edited their message in #{e.Channel.Name} ({e.Channel.Id}) on {e.Server.Name} ({e.Server.Id}) | Before: - {e.Before.RawText} | After: - {e.After.RawText}");     //log msg to console
            };

            string token = File.ReadAllText("token.txt");
            _client.ExecuteAndWait(async () => {
                await _client.Connect(token, TokenType.Bot);
            });
        }
    }
}
