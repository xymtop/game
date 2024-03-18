using Assets.Scenes.code.entity;
using Assets.Scenes.code.service;
using System;
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
                LoginResultMsg.text = "登录失败!！！！";
                LoginResultMsg.color = Color.red;
                LoginResultMsg.gameObject.SetActive(true);
            }
            else
            {
                //登录成功
                LoginResultMsg.text = "登录成功!！！！";
                LoginResultMsg.color = Color.green;
                LoginResultMsg.gameObject.SetActive(true);
            }

           
        }

        public void UserRegister() {
            User user = new();
            user.username = usernameText.text;
            user.password = passwordText.text;
            user._id = usernameText.text;
            user.deleted = "0";
            user.role = "1";
            user.create_time = DateTime.Now.ToLocalTime().ToString();


            UserService userService = new UserService();
            bool flag = userService.Registe(user);

            if (!flag)
            {
                RegistResultMsg.text = "注册失败!！！！";
                RegistResultMsg.color = Color.red;
                RegistResultMsg.gameObject.SetActive(true);
            }
            else
            {
                RegistResultMsg.text = "注册成功!！！！";
                RegistResultMsg.color = Color.green;
                RegistResultMsg.gameObject.SetActive(true);
            }
        }
    }
}