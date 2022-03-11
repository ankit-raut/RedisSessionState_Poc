using System;

namespace RedisSessionState_Poc
{
    public class RealTime : Attribute
    {
        public string Name { get; set; }

        public RealTime(string name)
        {
            Name = name;
        }
    }
}
