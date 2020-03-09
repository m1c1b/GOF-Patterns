namespace Prototype
{
    class Prototype
    {
        public string Class { get; set; }
        public string State { get; set; }

        public Prototype Clone()
        {
            return MemberwiseClone() as Prototype;
        }
    }

    class Program
    {
        static void Main()
        {
            var prototype = new Prototype();
            prototype.Class = "Animal System";
            prototype.State = "";

            var cat = prototype.Clone();
            cat.Class = "Cat";
            cat.State = "Default cat";

            var femaleCat = cat.Clone();
            femaleCat.Class = "Female cat";
            femaleCat.State = "Ready to borning new kitties";

            var manCat = cat.Clone();
            manCat.Class = "Man cat";
            manCat.State = "Ready to hunt";
        }
    }
}