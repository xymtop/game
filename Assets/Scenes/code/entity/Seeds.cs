using UnityEditor;
using UnityEngine;

namespace Assets.Scenes.code.entity
{
    public class Seeds 
    {
        public int ID { get; set; }
        public int count { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string[] Prefab { get; set; }
        public string picPath { get; set; }
        public float firstStageTime { get; set; }
        public float secondStageTime { get; set; }
        public float thirdStageTime { get; set; }
        public int price { get; set; }
    }
}