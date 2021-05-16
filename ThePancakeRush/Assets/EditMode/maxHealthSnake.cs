using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

namespace Tests
{
    public class maxHealthSnake
    {
        private GameObject Snake = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Enemies/Prefabs/Snake.prefab");
        // A Test behaves as an ordinary method
        [Test]
        public void maxHealthSnakeSimplePasses()
        {
            var maxSnakeHealth = Snake.GetComponent<Snake_hit>().viataMaxima;
            // Use the Assert class to test conditions
            Assert.AreEqual(100, maxSnakeHealth);
        }
    }
}
