using SQLite;

namespace eziBANK.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection(string dbName);
    }
}
