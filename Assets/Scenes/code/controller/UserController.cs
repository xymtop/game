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

        public Text LoginResultMsg;

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

        }
    }
}