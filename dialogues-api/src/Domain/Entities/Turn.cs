﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Turn
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Speaker { get; set; }
        public string Message { get; set; }
        //public Translation Translation { get; set; }
    }
}
