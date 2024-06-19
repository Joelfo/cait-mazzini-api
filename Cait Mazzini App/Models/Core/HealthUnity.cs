﻿using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.Core
{
    public class HealthUnity : IId
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
