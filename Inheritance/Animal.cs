using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public string noise { get; set; }
        public int runningSpeed { get; set; }
        public string skinColor { get; set; }
        public int legNum { get; set; }

    }
    public class Bird: Animal
    {
        public bool canFly  { get; set; }
        public bool canSwin { get; set; }
        public bool isNocturnal { get; set; }
        public int wingSpan { get; set; }

    }
    public class Reptile : Animal
    {
        public bool coldBlood { get; set; }

        public bool liveInSwamp { get; set; }
        public int fangCount { get; set; }
        public bool layEggs { get; set; }
    }
}
