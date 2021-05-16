using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

namespace Tests
{
    public class MaxHealthBird
    {
        private GameObject Bird = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Enemies/Prefabs/Bird.prefab");

        [Test]
        public void MaxHealthBirdSimplePasses()
        {
           var maxBirdHealth = Bird.GetComponent<Bird_hit>().viataMaxima;

           Assert.AreEqual(100, maxBirdHealth);
        }

    }
}
