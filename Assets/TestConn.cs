using Assets.Scenes.code.entity;
using Assets.Scenes.code.service;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConn : MonoBehaviour
{

    UserService service;

    public TestConn()
    {
        service = new UserService();
    }
    // Start is called before the first frame update
    void Start()
    {
     /*   for (int i = 1; i < 10; i++)
        {

      *//*      User admin =service.getUser(i.ToString());
            Console.WriteLine(admin);
            System.Console.WriteLine("Hello World!");
            //  User user = new User();
            // user._id = i.ToString();
            //user.username = i.ToString();
            // user.password = "123456";
            //service.Registe(user);*//*

        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
