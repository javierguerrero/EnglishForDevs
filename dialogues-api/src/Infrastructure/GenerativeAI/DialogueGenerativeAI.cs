using Domain.Entities;
using Domain.Interfaces.GenerativeAI;

namespace Infrastructure.GenerativeAI
{
    public class DialogueGenerativeAI : IDialogueGenerativeAI
    {
        public readonly IChatbot _chatbot;

        public DialogueGenerativeAI(IChatbot chatbot)
        {
            this._chatbot = chatbot;
        }

        public async Task<Dialogue> GenerateDialogue()
        {
            var completionText = await _chatbot.GenerateResponse();

            string[] lines = completionText.Split(new string[] { "\n", "\\n" }, StringSplitOptions.None);
            List<string> list = new List<string>(lines);
            var filteredList = list.Where(s => s != "").ToList();

            var dialogue = new Dialogue();
            foreach (var line in filteredList)
            {
                dialogue.Turns.Add(new Turn()
                {
                    Message = line
                });
            }

            return dialogue;
        }
    }
}