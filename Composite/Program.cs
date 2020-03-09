namespace Composite
{
    class Program
    {
        static void Main()
        {
            Component root = new Composite("root");
            Component branch1 = new Composite("br1");
            Component branch2 = new Composite("br2");
            Component leaf1 = new Composite("leaf1");
            Component leaf2 = new Composite("leaf2");
            
            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch2.Add(leaf2);
            
            root.Operation();
        }
    }
}