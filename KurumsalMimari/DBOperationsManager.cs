using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari
{
    public class DBOperationsManager : IDBOperations
    {
        private IDBOperations db;

        public DBOperationsManager(IDBOperations _db)
        {
            this.db = _db;
        }

        public void Delete()
        {
            db.Delete();
        }

        public void Insert()
        {
            db.Insert();
        }

        public void Read()
        {
            db.Read();
        }

        public void Update()
        {
            db.Update();
        }
    }
}
