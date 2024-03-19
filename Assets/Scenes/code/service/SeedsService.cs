using Assets.Scenes.code.db;
using Assets.Scenes.code.entity;
using MongoDB.Driver;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

namespace Assets.Scenes.code.service
{
    public class SeedsService : BaseService
    {
        private string TABLE_NAME = "seeds";
        public SeedsService():base()
        {
        }

        public Seeds getSeed(int id)
        {
            Seeds seeds = new Seeds();
            seeds.ID = id;
            FilterDefinition<Seeds> seedsFilter = MongoDBHelper.BuildNonNullPropertiesFilter<Seeds>(seeds);
            List<Seeds> seedList = conn.Find<Seeds>(TABLE_NAME, seedsFilter);

            if(seedList==null || seedList.Count == 0)
            {
                return null;
            }

            return seedList[0];
        }

        public List<Seeds> getSeeds()
        {
            Seeds seeds = new Seeds();
            FilterDefinition<Seeds> seedsFilter = MongoDBHelper.BuildNonNullPropertiesFilter<Seeds>(seeds);
            return conn.Find<Seeds>(TABLE_NAME, seedsFilter);
        }


        public List <Seeds> querySeed(Seeds seeds)
        {
            FilterDefinition<Seeds> seedsFilter = MongoDBHelper.BuildNonNullPropertiesFilter<Seeds>(seeds);
            return conn.Find<Seeds>(TABLE_NAME, seedsFilter);
        }

        public bool AddSeeds(Seeds seed)
        {
            conn.InsertOne<Seeds>(TABLE_NAME, seed);

            return true;
        }
    }
}