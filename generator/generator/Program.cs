using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace AccountCreator
{
    public class Server : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Program.Create(e.Data);
        }
    }

    public class Program
    {
        private static Dictionary<string, int> httpProxies = new Dictionary<string, int>();
        private static Dictionary<string, int> checkedHttpProxies = new Dictionary<string, int>();
        private static int totalHttp;

        public static void Main(string[] args)
        {
            //LoadHttp();
            Console.Title = "Gerador de Contas";
            WebSocketServer _server = new WebSocketServer(8080);
            _server.AddWebSocketService<Server>("/");
            _server.Start();

            LoadEmails();

            Console.ReadLine();
        }

        public static async void Create(string token)
        {
            /*if (httpProxies.Count == 0)
            {
                Console.WriteLine($"Sem proxies disponíveis.");
                return;
            } */

            int tries = 5;
        retry:
            tries--;
            /* 
            string ip = httpProxies.First().Key;
            int port = httpProxies.First().Value;
            string ip = "177.75.96.74";
            int port = 3128; */ // definição dos tipos para o proxy
            // var proxy = new WebProxy(string.Format("{0}:{1}", ip, port), false); // definição do webproxy
            var httpClientHandler = new HttpClientHandler();
            /*{
                Proxy = proxy,
            }; */
            HttpClient client = new HttpClient(handler: httpClientHandler, disposeHandler: true);
            string email = GenMail();
            string pass = "exalemao2k22";
            string json = "{\"captchaToken\":\"" + token + "\",\"email\":\"" + email + "\",\"password\":\"" + pass + "\",\"passwordRepeated\":\"" + pass + "\",\"birthdate\":{\"day\":1,\"month\":1,\"year\":2000},\"termsOfServiceAccepted\":true}";
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36");
            try
            {
                HttpResponseMessage response = await client.PostAsync("https://www.habbo.com.br/api/public/registration/new", new StringContent(json, Encoding.UTF8, "application/json"));
                Console.WriteLine(response.StatusCode);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    // httpProxies.Remove(ip);
                    // Console.Title = $"HTTP: {httpProxies.Count}/{totalHttp}"; // numero de proxies disponiveis
                    Console.Title = "Gerador de Contas";
                    File.AppendAllText("accounts.txt", $"{email}:{pass}\n");
                    Console.WriteLine($"Conta criada => {email}:{pass} ");
                }
                else
                {
                    // httpProxies.Remove(ip);
                    // Console.Title = $"HTTP: {httpProxies.Count}/{totalHttp}"; // numero de proxies disponiveis
                    Console.Title = "Gerador de Contas";
                    if (tries != 0)
                        goto retry;
                }
            }
            catch
            {
                // httpProxies.Remove(ip);
                // Console.Title = $"HTTP: {httpProxies.Count}/{totalHttp}"; // numero de proxies disponiveis
                Console.Title = "Gerador de Contas";
                Console.WriteLine($"Houve algo de errado. Tentativas: {tries}");
                if (tries != 0)
                    goto retry;
            }
        }

        private static async void LoadHttp()
        {
            await Task.Delay(1500);
            if (!File.Exists("http.txt"))
                File.Create("http.txt").Dispose();

            try
            {
                foreach (var line in File.ReadAllLines("http.txt"))
                {
                    if (!httpProxies.Keys.Contains(line.Split(':')[0]))
                        httpProxies.Add(line.Split(':')[0], int.Parse(line.Split(':')[1]));
                }
            }
            catch (Exception err) { Console.WriteLine(err); }

            try
            {
                await Task.Run(async () =>
                {
                    var tasks = new List<Task>();
                    foreach (var proxy in httpProxies)
                    {
                        var task = CheckProxyHTTP(proxy.Key, proxy.Value);
                        tasks.Add(task);
                        totalHttp++;
                    }
                    await Task.WhenAll(tasks.ToArray());
                });
            }
            catch { }
        } 

        private static async Task CheckProxyHTTP(string server, int port)
        {
            try
            {
                var proxy = new WebProxy(string.Format("{0}:{1}", server, port), false);
                var httpClientHandler = new HttpClientHandler()
                {
                    Proxy = proxy,
                };
                var h = new System.Net.Http.HttpClient(handler: httpClientHandler, disposeHandler: true);
                h.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36");
                var resp = await h.GetAsync("https://www.habbo.com.br");
                var respCont = await resp.Content.ReadAsStringAsync();
                if (respCont.Contains("seu check-in no maior Hotel virtual do mundo"))
                {
                    checkedHttpProxies.Add(server, port);
                    httpProxies = checkedHttpProxies;
                    Console.Title = $"HTTP: {httpProxies.Count}/{totalHttp}";
                }
                else
                {
                    httpProxies = checkedHttpProxies;
                    Console.Title = $"HTTP: {httpProxies.Count}/{totalHttp}";
                }
                h.Dispose();
            }
            catch
            {
                httpProxies = checkedHttpProxies;
                Console.Title = $"HTTP: {httpProxies.Count}/{totalHttp}";
            }
        }

        private static List<string> emails = new List<string>();
        private static void LoadEmails()
        {
            foreach (string line in File.ReadAllLines("emails.txt"))
            {
                if (!emails.Contains(line))
                    emails.Add(line);
            }
        }

        private static string GenMail()
        {
            string email = emails.First();
            emails.Remove(email);
            return email;
        }
    }
}