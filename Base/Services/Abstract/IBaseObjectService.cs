namespace Base.Services.Abstract
{
    public interface IBaseObjectService<T> where T : BaseObject
    {
        T Get(int id);
        T Create(T obj);
        T Update(T obj);
        void Delete(T obj);
        //TODO Реализовать такие же методы под коллекции
    }
}
