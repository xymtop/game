using System.Collections;
using UnityEngine;

namespace Assets.Scenes.code.service
{
    public class BaseService 
    {
        public Conn conn;

       

        public BaseService()
        {
            if (this.conn == null)
            {
                this.conn = Conn.GetConn();
            }
        }
    }
}