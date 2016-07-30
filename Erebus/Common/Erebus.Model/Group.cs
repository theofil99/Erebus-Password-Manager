﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erebus.Model
{
    public class Group : PersistableObject
    {
        public string Name { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Entry> Entries { get; set; }
    }
}