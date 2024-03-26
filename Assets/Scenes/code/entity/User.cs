using System.Collections;
using UnityEngine;

namespace Assets.Scenes.code.entity
{

/* user entity */
    public class User
    {
        public string _id {  get; set; }
        public string username {  get; set; }

        public string password { get; set; }

        public string create_time { get; set; }

        public string role { get; set; }

        public string deleted {  get; set; }

    }
}