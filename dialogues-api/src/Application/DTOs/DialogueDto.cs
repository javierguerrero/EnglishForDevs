using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class DialogueDto
    {
        public int Id { get; set; }
        public ICollection<TurnDto> Turns { get; set; }
    }
}
