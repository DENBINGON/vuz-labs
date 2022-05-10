using System.Collections.Generic;

namespace CourseworkASD
{
    public class LinealSearch : ISearch
    {
        private readonly List<(string word, int hash)> _data;
        public LinealSearch(List<(string word, int hash)> data) => _data = data;
        public (bool exist, int iterCount) Find(string item)
        {
            bool exist = false;
            int iterCount = 0;
            int hash = item.GetHashCode();
            for (int counter = 0; counter < _data.Count; counter++)
            {
                iterCount++;
                if (_data[counter].hash == hash)
                {
                    exist = true;
                    break;
                }
            }

            return (exist, iterCount);
        }
    }
}