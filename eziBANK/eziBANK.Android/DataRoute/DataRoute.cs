using System;
using eziBANK.Data;
using eziBANK.Droid.DataRoute;
using Xamarin.Forms;
using SQLite;
using System.IO;

[assembly: Dependency(typeof(DataRoute))]
namespace eziBANK.Droid.DataRoute
{
    public class DataRoute : ISQLite
    {
        public DataRoute()
        {
        }

        public SQLiteConnection GetConnection(string dbName)
        {
            var documents = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documents, dbName);
            return new SQLiteConnection(path);
        }

    }
}