﻿using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IGenerateDialogueService
    {
        Task<Dialogue> GenerateDialogue();
    }
}