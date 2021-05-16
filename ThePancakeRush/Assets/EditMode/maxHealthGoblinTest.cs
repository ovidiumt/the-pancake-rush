using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

namespace Tests
{
    public class maxHealthGoblin
    {
        private GameObject Goblin = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Enemies/Prefabs/Goblin.prefab");
        // A Test behaves as an ordinary method
        [Test]
        public void maxHealthGoblinSimplePasses()
        {
             var maxGoblinHealth = Goblin.GetComponent<Goblin_hit>().viataMaxima;

             Assert.AreEqual(200, maxGoblinHealth);
        }
    }
}
