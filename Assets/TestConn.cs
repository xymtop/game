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
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            User user = new User();
            user.username = i.ToString();
            user.password = "derÍõ";
            service.Registe(user);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
