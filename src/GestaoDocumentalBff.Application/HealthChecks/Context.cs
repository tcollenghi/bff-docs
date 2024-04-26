using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace GestaoDocumentalBff.Application.HeathChecks
{
    public interface ICheckService
    {
        string Name { get; }
        string Version { get; }
        string Date { get; }
        string Status { get; }
        ICheckService[] Dependencies { get; set; }

        public ICheckService Add(params ICheckService[] dependency)
        {
            Dependencies = (Dependencies ?? new ICheckService[] { }).Concat(dependency).ToArray();
            return this;
        }
    }

    public class CheckService : ICheckService
    {
        public CheckService()
        {
            var assembly = GetType().Assembly;
            var assemblyName = assembly.GetName();
            Name = assemblyName.Name;
            Version = assemblyName.Version?.ToString();
            Date = (new FileInfo(assembly.Location)).LastWriteTime.ToString("o");
        }

        public string Name { get; }
        public string Version { get; }
        public string Date { get; }
        public string Status { get => Dependencies?.Any(d => d.Status == "DOWN") == true ? "DOWN" : "UP"; }
        public ICheckService[] Dependencies { get; set; }


    }

    public class CheckServiceDeep : ICheckService
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public ICheckService[] Dependencies { get; set; }

        public CheckServiceDeep() { }
        public CheckServiceDeep(string name, string host, StringValues token)
        {
            Name = name;
            try
            {
                var request = WebRequest.Create($"{host}/hc/deep");
                request.Method = "GET";
                request.ContentType = "application/json";

                if (token != StringValues.Empty)
                    request.Headers.Add("Authorization", token.ToString());

                using var response = request.GetResponse() as HttpWebResponse;

                var result = response?.StatusCode ?? default(HttpStatusCode);

                if (result != HttpStatusCode.OK)
                    throw new Exception($"Expected {nameof(HttpStatusCode)} {HttpStatusCode.OK} '{result}'");

                using var responseStream = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

                var responseStr = responseStream.ReadToEnd();

                Dependencies = new[]
                {
                    JsonConvert.DeserializeObject<CheckServiceDeep>(
                        responseStr,
                        new JsonSerializerSettings()
                        {
                            ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
                            Converters = {
                                new AbstractConverter<CheckServiceDeep, ICheckService>()
                            }
                        })
                };


                Status = Dependencies?.Any(d => d.Status == "DOWN") == true ? "DOWN" : "UP"; ;
            }
            catch (Exception ex)
            {
                //logger.Error(ex, $"Erro ao validar: {Name}");
                Status = "DOWN";
            }
        }
        public class AbstractConverter<TReal, TAbstract> : JsonConverter where TReal : TAbstract
        {
            public override Boolean CanConvert(Type objectType)
                => objectType == typeof(TAbstract);

            public override Object ReadJson(JsonReader reader, Type type, Object value, JsonSerializer jser)
                => jser.Deserialize<TReal>(reader);

            public override void WriteJson(JsonWriter writer, Object value, JsonSerializer jser)
                => jser.Serialize(writer, value);
        }
    }
}
