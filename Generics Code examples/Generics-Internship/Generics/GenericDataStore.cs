namespace Generics
{
    public class GenericDataStore<T>
    {
        private List<T> _list = new();

        public void Add(T x)
        {
            _list.Add(x);
        }

        public List<T> GetList()
        {
            return _list;
        }
    }
}
