namespace BLL.Interface.Interfaces
{
    public interface IConverter<TSource, TResult>
    {
        TResult Convert(TSource source);
    }
}