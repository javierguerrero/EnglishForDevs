﻿using Infrastructure.GenerativeAI.DTOs;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Text.Json;

namespace Infrastructure.GenerativeAI
{
    public class ChatGPT : IChatbot
    {
        private IConfiguration _configuration;

        public ChatGPT(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GenerateResponse()
        {
            var result = string.Empty;

            string? key = _configuration.GetSection("ChatGPT:Key").Value;
            string? url = _configuration.GetSection("ChatGPT:Url").Value;
            string? prompt = _configuration.GetSection("ChatGPT:Prompt").Value;

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
                        result = completionText;
                    }
                }
            }

            //TODO: Validate result's value
            return result;
        }
    }
}