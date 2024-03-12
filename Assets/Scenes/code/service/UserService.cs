using Assets.Scenes.code.db;
using Assets.Scenes.code.entity;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scenes.code.service
{
    public class UserService:BaseService
    {
    

        private  string TABLE_NAME = "user";
        public UserService():base() 
        {
          
          
        }


        public User Login(string id, string password)
        {
               User user =  new();
            user._id = id;
            user.password = password;
            FilterDefinition<User> userFilter =  MongoDBHelper.BuildNonNullPropertiesFilter<User>(user);
             List<User> users =  conn.Find<User>(TABLE_NAME, userFilter);

            if(users==null&&users.Count == 0)
            {
                return null;
            }

            return users[0];
           
        }


        public User getUser(string id)
        {
            User user = new();
            user._id = id;
            FilterDefinition<User> userFilter = MongoDBHelper.BuildNonNullPropertiesFilter<User>(user);
            List<User> users = conn.Find<User>(TABLE_NAME, userFilter);

            if (users == null || users.Count == 0)
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