namespace task3;

public interface MyList<T> where T : class
{
    List<T> ToString();
    MyList<T> Add(T item);
    MyList<T> Count(T item);
    MyList<T> Contains(T item);
}
