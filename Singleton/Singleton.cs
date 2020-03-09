namespace Singleton
{
    class Singleton
    {
        static Singleton _uniqueInstance;
        string _singletonData = string.Empty;

        public static Singleton Instance()
        {
            return _uniqueInstance ??= new Singleton();
        }

        public void SingletonOperation()
        {
            _singletonData = "SingletonData";
        }

        public string GetSingletonData()
        {
            return _singletonData;
        }
    }
}