﻿using MorningCoffee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorningCoffee.Entities.Concrete
{
    public class Tea : IEntity
    {
        public int Id { get; set; }
        public int IcedTeaId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
    }
}
