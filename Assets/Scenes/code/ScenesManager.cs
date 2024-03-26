using System.Collections;
using UnityEngine;

namespace Assets.Scenes.code
{
    public class ScenesManager : MonoBehaviour
    {

         //页面编号
         private static int LoginViewId = 0;

        //场景跳转
        public static void Goto(int id)
        {
            Application.LoadLevel(id);
        }

        //跳转到登录页面
        public static void GotoLoginView()
        {
            Goto(LoginViewId);
        }
    }
}