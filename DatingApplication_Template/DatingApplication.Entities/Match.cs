﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.Entities
{
    public class Match
    {
        public long MatchId { get; set; }
        public long UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
