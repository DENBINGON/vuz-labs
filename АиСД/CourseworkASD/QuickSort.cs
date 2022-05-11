using System.Collections.Generic;

namespace CourseworkASD
{
    public class QuickSort
    {
        public List<(string word, int hash)> Sort(List<(string word, int hash)> data, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return data;
            }

            int propIndex = GetPropIndex(data, minIndex, maxIndex);

            Sort(data, minIndex, propIndex - 1);
            Sort(data, propIndex + 1, maxIndex);

            return data;
        }

        private int GetPropIndex(List<(string word, int hash)> data, int minIndex, int maxIndex)
        {
            int prop = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (data[i].hash < data[maxIndex].hash)
                {
                    prop++;
                    (data[prop], data[i]) = (data[i], data[prop]);
                }
            }

            prop++;

            (data[prop], data[maxIndex]) = (data[maxIndex], data[prop]);

            return prop;
        }
    }
}