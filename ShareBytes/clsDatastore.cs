using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Datastore.V1;
using System.Data;

namespace ShareBytes
{
    class clsDatastore
    {
        public int SignUp(string CollegeId, string UserName, string EmailId,string Password)
        {
                clsDAL obj = new clsDAL();

                DatastoreDb db = DatastoreDb.Create(obj.DatastoreId);
                KeyFactory keyFactory = db.CreateKeyFactory(obj.DatastoreKey1);
                Key key = keyFactory.CreateKey(CollegeId);
                var entity = new Entity
                {
                    Key = key,
                    [obj.DatastoreColumn11] = CollegeId,
                    [obj.DatastoreColumn12] = UserName,
                    [obj.DatastoreColumn13] = EmailId,
                    [obj.DatastoreColumn14] = Password
                };
                using (DatastoreTransaction transaction = db.BeginTransaction())
                {
                    transaction.Upsert(entity);
                    transaction.Commit();
                }
                return 1;
                
        }

        public DatastoreQueryResults Login(string UserId, string Password)
        {
            
                clsDAL obj = new clsDAL();

                DatastoreDb db = DatastoreDb.Create(obj.DatastoreId);
                Query query = new Query(obj.DatastoreKey1)
                {
                    Filter = Filter.And(Filter.Equal(obj.DatastoreColumn11, UserId),
                        Filter.Equal(obj.DatastoreColumn14, Password)),
                };

                DatastoreQueryResults result = db.RunQuery(query);
                return result;
            
        }

        public string GetUserFolders()
        {
            string Folders = null;
            clsDAL obj = new clsDAL();
                DatastoreDb db = DatastoreDb.Create(obj.DatastoreId);
                Query query = new Query(obj.DatastoreKey2)
                {
                    Filter = Filter.Equal(obj.DatastoreColumn21, clsValues.UserID)
                };
                foreach (var entity in db.RunQuery(query).Entities)
                {
                    Folders = entity[obj.DatastoreColumn22].StringValue;

                }
            
            return Folders;
        }
        public void UpdateUserFolder(string Folders)
        {
            clsDAL obj = new clsDAL();
            DatastoreDb db = DatastoreDb.Create(obj.DatastoreId);
            KeyFactory keyFactory = db.CreateKeyFactory(obj.DatastoreKey2);
            Key key = keyFactory.CreateKey(clsValues.UserID);
            Entity task = new Entity()
            {
                Key = key,
                ["Id"] = clsValues.UserID,
                ["Folders"] =  Folders

            };
            try
            {
                db.Update(task);
            }
            catch { db.Insert(task); }
            
        }
        //public int InsertUserFolder(string Folders="")
        //{
        //    clsDAL obj = new clsDAL();
        //    DatastoreDb db = DatastoreDb.Create(obj.DatastoreId);
        //    KeyFactory keyFactory = db.CreateKeyFactory(obj.DatastoreKey2);
        //    Key key = keyFactory.CreateKey(clsValues.UserID);
        //    Entity task = new Entity()
        //    {
        //        Key = key,
        //        ["Id"] = clsValues.UserID,
        //        //["Folders"] = Folders

        //    };
            
        //    db.Insert(task);
        //    return 1;
        //}
    }
}
