namespace ContactDatabase
{
    public interface IContactDatabase
    {
        Contact Add ( Contact contact, out string errorMessage );

        Contact Get ( int id );

        IEnumerable<Contact> GetAll ();

        void Remove ( int id );

        bool Update ( int id, Contact contact, out string errorMessage );
    }
}
