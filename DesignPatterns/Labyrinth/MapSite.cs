using System;

namespace DesignPatterns.Labyrinth
{
    public abstract class MapSite : ICloneable
    {
        public abstract void Enter();

        public abstract object Clone();
    }
}
