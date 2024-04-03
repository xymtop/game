using Assets.Scenes.code.entity;
using Assets.Scenes.code.service;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

namespace Assets.Scenes.code
{
    public class UserController : MonoBehaviour
    {

        public InputField usernameText;

        public InputField passwordText;

        public Text LoginResultMsg;



        public InputField registUserNameText;
        public InputField registPasswordText;
        public Text RegistResultMsg;


        public void Start()
        {
        
        }

      
        public void UserLogin()
        {
            string username =  usernameText.text;
            string password = passwordText.text;
            UserService userService = new UserService();
            User user =   userService.Login(username, password);

     
            if (user == null)
            {
                //登录失败
                LoginResultMsg.text = "Fail!！！！";
                LoginResultMsg.color = Color.red;
                LoginResultMsg.gameObject.SetActive(true);
            }
            else
            {
                //登录成功
                LoginResultMsg.text = "Success!！！！";
                LoginResultMsg.color = Color.green;
                LoginResultMsg.gameObject.SetActive(true);

                Application.LoadLevel(0);
            
            }
        }

        public void UserRegister() {
            User user = new()
            {
                username = usernameText.text,
                password = passwordText.text,
                _id = usernameText.text,
                deleted = "0",
                role = "1",
                create_time = DateTime.Now.ToLocalTime().ToString()
            };


            UserService userService = new UserService();
            bool flag = userService.Registe(user);

            if (!flag)
            {
                RegistResultMsg.text = "Fail!！！！";
                RegistResultMsg.color = Color.red;
                RegistResultMsg.gameObject.SetActive(true);
            }
            else
            {
                RegistResultMsg.text = "Success!！！！";
                RegistResultMsg.color = Color.green;
                RegistResultMsg.gameObject.SetActive(true);
            }
        }
    }
}