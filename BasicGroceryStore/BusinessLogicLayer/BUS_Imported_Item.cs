namespace BasicGroceryStore
{
    internal class BUS_Imported_Item : IControl<Imported_Item>
    {
        private DAO_Bill_Item dao;

        public BUS_Imported_Item()
        {
            dao = new DAO_Bill_Item("Imported");
        }

        public bool Create(Imported_Item item)
        {
            return dao.Create(item);
        }

        public bool Update(Imported_Item item)
        {
            return dao.Update(item);
        }

        public bool Delete(Imported_Item item)
        {
            return dao.Delete(item);
        }

    }
}
