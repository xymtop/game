using MongoDB.Driver;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conn : MonoBehaviour
{

    /*"mongodb://127.0.0.1:27017"*/
    private string MONGO_URI  { set; get; }

    /*game*/
    private string DATABASE_NAME {  set; get; }

    private MongoClient client;
    private IMongoDatabase db;


    private static Conn conn = null;

    public Conn(string MONGO_URI, string DATABASE_NAME)
    {
        this.MONGO_URI = MONGO_URI;
        this.DATABASE_NAME = DATABASE_NAME;
    }

    public static Conn GetConn()
    {
        if (conn == null)
        {
            Conn conn = new Conn("mongodb://127.0.0.1:27017", "game");
        }
        return conn;
    }

/*
 if you need to get a database ,you can use it
 */
    public IMongoDatabase GetDb()
    {
        if (client == null)
        {
               client = new MongoClient(MONGO_URI);
        }
        if (db == null)
        {
                 db = client.GetDatabase(DATABASE_NAME);
        }
        
        return db;
    }

    /*if you hava a database, you can use it to get a table*/
    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        return db.GetCollection<T>(collectionName);
    }



/*insert a data*/
    public void InsertOne<T>(string collectionName, T document)
    {
        GetCollection<T>(collectionName).InsertOne(document);
    }

/*find some data*/
    public List<T> Find<T>(string collectionName, FilterDefinition<T> filter)
    {
        return GetCollection<T>(collectionName).Find(filter).ToList();
    }


    public void UpdateOne<T>(string collectionName, FilterDefinition<T> filter, UpdateDefinition<T> update)
    {
        GetCollection<T>(collectionName).UpdateOne(filter, update);
    }


    public void DeleteOne<T>(string collectionName, FilterDefinition<T> filter)
    {
        GetCollection<T>(collectionName).DeleteOne(filter);
    }
}
