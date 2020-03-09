using System;

namespace Builder
{
    class Director
    {
        Builder.Builder builder;

        public Director(Builder.Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
