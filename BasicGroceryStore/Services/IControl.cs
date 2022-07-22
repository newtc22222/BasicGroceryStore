namespace BasicGroceryStore
{
    public interface IControl<T>
    {
        /// <summary>
        /// INSERT data to DBMS
        /// </summary>
        /// <param name="t"></param>
        /// <returns>true or false</returns>
        bool Create(T t);

        /// <summary>
        /// CHANGE data in DBMS
        /// </summary>
        /// <param name="t"></param>
        /// <returns>true or false</returns>
        bool Update(T t);

        /// <summary>
        /// DELETE data from DBMS
        /// </summary>
        /// <param name="t"></param>
        /// <returns>true or false</returns>
        bool Delete(T t);
    }
}
