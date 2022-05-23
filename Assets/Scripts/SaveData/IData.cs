namespace Maze
{
    public interface IData<T> : IData
    {
        void Save(T data, string path = null);
        T Load(string path = null);
    }

    public interface IData
    {

    }
}