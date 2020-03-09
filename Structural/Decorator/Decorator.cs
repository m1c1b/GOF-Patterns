﻿namespace Decorator
{
    public abstract class Decorator : Component
    {
        public Component Component { get; set; }
        public override void Operation() => Component?.Operation();

        public void SetComponent(Component component)
        {
            Component = component;
        }
    }
}