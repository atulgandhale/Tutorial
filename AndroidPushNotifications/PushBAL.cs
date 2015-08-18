using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AndroidPushNotifications
{
    public class PushBAL
    {
        PushDAL dal = new PushDAL();
        public DataSet GetAndroidRegIds()
        {
            return dal.GetAndroidRegIds();
        }

    }
}