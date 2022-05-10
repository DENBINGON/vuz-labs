namespace CourseworkASD
{
    public interface ISearch
    {
        (bool exist, int iterCount) Find(string word);
    }
}