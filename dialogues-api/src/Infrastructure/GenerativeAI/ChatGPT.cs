using Domain.Entities;
using Domain.Interfaces.GenerativeAI;
using Infrastructure.GenerativeAI.DTOs;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Text.Json;

namespace Infrastructure.GenerativeAI
{
    public class ChatGPT : IDialogueGenerativeAI
    {
        private IConfiguration _configuration;

        public ChatGPT(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<Dialogue> GenerateDialogue()
        {
            string? key = _configuration.GetSection("ChatGPT:Key").Value;
            string? url = _configuration.GetSection("ChatGPT:Url").Value;

            var result = string.Empty;

            using (var client = new HttpClient())
            {
                var jsonObject = @"{
                    ""model"": ""gpt-3.5-turbo"",
                    ""messages"": [
                        {
                            ""role"": ""user"",
                            ""content"": ""genera una conversacion entre dos personas que estan hablando sobre el clima.""
                        }
                    ]
                }";

                var completionResponse = new CompletionResponse();
                var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + key);
                var httpResponse = await client.PostAsync(url, content);

                if (httpResponse is not null)
                {
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        string responseString = await httpResponse.Content.ReadAsStringAsync();
                        if (!string.IsNullOrWhiteSpace(responseString))
                        {
                            completionResponse = JsonSerializer.Deserialize<CompletionResponse>(responseString);
                        }
                    }
                }

                if (completionResponse is not null)
                {
                    string? completionText = completionResponse.choices?[0].message.content;

                    if (!string.IsNullOrEmpty(completionText))
                    {
                        var phrases = GetPhrases(completionText);
                        var foo = 0;
                    }
                }
            }

            return null;
        }

        private List<string> GetPhrases(string text)
        {
            string[] lines = text.Split(new string[] { "\n" }, StringSplitOptions.None);
            List<string> result = new List<string>(lines);
            var filtered = result.Where(s => s != "").ToList();
            return filtered;
        }
    }
}