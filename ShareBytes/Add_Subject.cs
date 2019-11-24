using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Datastore.V1;

namespace ShareBytes
{
    public partial class Add_Subject : Form
    {
        public Add_Subject()
        {
            InitializeComponent();
        }


        private void btnsub_Click(object sender, EventArgs e)
        {
            clsDAL obj = new clsDAL();
            DatastoreDb db = DatastoreDb.Create(obj.DatastoreId);
            KeyFactory keyFactory = db.CreateKeyFactory("UserFolder");
            Key key = keyFactory.CreateKey(clsValues.UserID);
            Entity task = new Entity()
            {
                Key = key,
                ["Id"] = clsValues.UserID,
                ["Folders"]= new ArrayValue() { Values = {txtsub.Text} }
                    
            };
            //db.Update(task);  
            db.Insert(task);
            //using (DatastoreTransaction transaction = db.BeginTransaction())
            //{
            //    transaction.Upsert(task);
            //    transaction.Commit();
            //}
        }
    }
}
