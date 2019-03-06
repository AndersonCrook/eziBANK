using System;
using System.IO;
using eziBANK.Data;
using eziBANK.iOS.DataRoute;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(DataRoute))]
namespace eziBANK.iOS.DataRoute
{
    class DataRoute : ISQLite
    {
        public DataRoute()
        {
        }

        public SQLiteConnection GetConnection(string dbName)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, "..", "Library", dbName);
            return new SQLiteConnection(path);

        }
    }
}