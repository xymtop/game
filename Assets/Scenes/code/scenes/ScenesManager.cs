using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scenes.code
{
    public class ScenesManagers : MonoBehaviour
    {

         //页面编号
         private static int LoginViewId = 0;

         private static int MainViewId = 3;

        //场景跳转
        public static void Goto(int id)
        {
            //下面这个函数已经被废除
            // Application.LoadLevel(id);
            SceneManager.LoadScene(id);
            
        }

        //跳转到登录页面
        public static void GotoLoginView()
        {
            Goto(LoginViewId);
        }

        //跳转到主页面
        public static void GotoMainView()
        {
            Goto(MainViewId);
        }
    }
}