﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Models
{
    public class Busket : BaseEntity
    {
        public virtual ICollection<BusketItem> BusketItems{ get; set; }

        public Busket()
        {
            this.BusketItems = new List<BusketItem>();
        }
    }
}
