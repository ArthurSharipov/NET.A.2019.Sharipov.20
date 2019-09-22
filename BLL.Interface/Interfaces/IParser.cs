namespace BLL.Interface.Interfaces
{
    public interface IParser<TSource, TResult>
    {
        TResult Parse(TSource sourse);
    }
}