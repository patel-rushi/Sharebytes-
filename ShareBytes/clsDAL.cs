using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Datastore.V1;

namespace ShareBytes
{
    class clsDAL
    {
        public string DatastoreId = "sharebyte-256510";

        public string DatastoreKey1 = "userinfo";
        public string DatastoreColumn11 = "User Id";
        public string DatastoreColumn12 = "Full Name";
        public string DatastoreColumn13 = "Email";
        public string DatastoreColumn14 = "Password";

        public string DatastoreKey2 = "UserFolder";
        public string DatastoreColumn21 = "Id";
        public string DatastoreColumn22 = "Folders";

        //========================================================================
        public string GoogleStorage_projectId = "sharebyte-256510";

    }
}
