using System.Collections.Generic;

namespace CourseworkASD
{
    public class LinealSearch
    {
        private List<(string word, int hash)> _data;
        public LinealSearch(List<(string word, int hash)> data) => _data = data;

        public bool Find(string item)
        {
            bool _exist = false;
            int _hash = item.GetHashCode();
            for (int counter = 0; counter < _data.Count; counter++)
                if (_data[counter].hash == _hash)
                    _exist = true;
            return _exist;
        }
    }
}