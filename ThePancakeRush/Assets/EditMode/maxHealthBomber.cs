using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

namespace Tests
{
    public class maxHealthBomber
    {   
        private GameObject Bomber = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Enemies/Prefabs/bomber.prefab");
        // A Test behaves as an ordinary method
        [Test]
        public void maxHealthBomberSimplePasses()
        {
            var maxBomberHealth = Bomber.GetComponent<Bomber_hit>().viataMaxima;
            // Use the Assert class to test conditions
            Assert.AreEqual(100, maxBomberHealth);
        }
    }
}
