class MainC
{
    public List<object> Insert(List<object> list, object obj, int n)
    {
        List<object> list_ = new List<object>();
        for (int i = 0; i < n; i++)
        {
            list_.Add(list[i]);
        }
        list_.Add(obj);
        for (int i = n + 1; n < list.Count; i++)
        {
            list_.Add(list[i]);
        }
        return list_;
    }
}