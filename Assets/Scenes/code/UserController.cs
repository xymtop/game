using Assets.Scenes.code.entity;
using Assets.Scenes.code.service;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scenes.code
{
    public class UserController : MonoBehaviour
    {

        public Text usernameText;
        public Text passwordText;


        public void UserLogin()
        {
            string username =  usernameText.text;
            string password = passwordText.text;

            UserService userService = new UserService();
            User user =   userService.Login(username, password);

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