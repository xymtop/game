using Assets.Scenes.code.db;
using Assets.Scenes.code.entity;
using MongoDB.Driver;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scenes.code.service
{
    public class UserService
    {
        private Conn conn;

        private const string TABLE_NAME = "user";
        public UserService()
        {
            if (conn == null)
            {
                conn = Conn.GetConn();
            } 
        }


        public User Login(string username, string password)
        {
               User user =  new User();
            user.userName = username;
            user.password = password;
            FilterDefinition<User> userFilter =  MongoDBHelper.BuildNonNullPropertiesFilter<User>(user);
             List<User> users =  conn.Find<User>(TABLE_NAME, userFilter);

            if(users==null&&users.Count == 0)
            {
                return null;
            }

            return users[0];
           
        }


        public bool Registe(User user)
        {
            if(user == null)
            {
                return false;
            }

            conn.InsertOne<User>(TABLE_NAME, user);

            return true;
        }
    }
}