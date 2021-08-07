using System;

namespace dependency_with_sourcelink
{
    public class Class1
    {
        public string GetHelloText(string name)
        {
            return name is null
                ? "Hello."
                : $"Hello {name}!";
        }
    }
}
