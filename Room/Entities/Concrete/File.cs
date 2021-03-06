﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class File : IEntity
    {
        public int Id { get; set; }
        public DateTime LastAccessTime { get; set; }
        public int AccessCount { get; set; }
        public string Url { get; set; }
    }
}
