using Assets.Scenes.code.entity;
using Assets.Scenes.code.service;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scenes.code
{
    public class UserController : MonoBehaviour
    {

        public InputField usernameText;

        public InputField passwordText;

        public void Start()
        {
        
        }

        public void UserLogin()
        {
            string username =  usernameText.text;
            string password = passwordText.text;


            Debug.Log(username + " " + password);
         
            UserService userService = new UserService();
            User user =   userService.Login(username, password);

            Debug.Log(user);
            if (user != null)
            {
                //登录失败

            }

            //登录成功
        }

        public void UserRegister() { 

        }
    }
}