namespace Generics
{
    public class IntDataStore
    {
        private List<int> _intList = new();

        public void Add(int x)
        {
            _intList.Add(x);
        }

        public List<int> GetList()
        {
            return _intList;
        }
    }

    public class StringDataStore
    {
        private List<string> _stringList = new();

        public void Add(string x)
        {
            _stringList.Add(x);
        }

        public List<string> GetList()
        {
            return _stringList;
        }
    }
}
