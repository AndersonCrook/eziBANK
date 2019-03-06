using SQLite;
using System.Collections.Generic;
using Xamarin.Forms;

namespace eziBANK.Data
{
    public abstract class BaseData<T>
    {
        protected SQLiteConnection db;
        private string dbName = "EziBank.db3";
        public BaseData()
        {
            this.db = DependencyService.Get<ISQLite>().GetConnection(this.dbName);
            this.db.CreateTable<T>();
        }

        public abstract int Save(T entity);

        public abstract int Delete(T entity);

        public abstract int Update(T entity);

        public abstract T GetById(int id);

        public abstract List<T> GetAll();

        public abstract void Dispose();
    }
}
