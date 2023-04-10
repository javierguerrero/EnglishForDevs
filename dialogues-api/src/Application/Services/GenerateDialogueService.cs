using Domain.Entities;
using Domain.Interfaces.GenerativeAI;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class GenerateDialogueService : IGenerateDialogueService
    {
        private readonly IDialogueGenerativeAI _generativeAI;

        public GenerateDialogueService(IDialogueGenerativeAI generativeAI)
        {
            _generativeAI = generativeAI;
        }

        public async Task<Dialogue> GenerateDialogue()
        {
            return await _generativeAI.GenerateDialogue();
        }
    }
}