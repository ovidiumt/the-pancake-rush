using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

namespace Tests
{
    public class maxHealth
    {
        private GameObject Slime = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Enemies/Prefabs/Slime.prefab");
        // A Test behaves as an ordinary method
        [Test]
        public void maxHealthGoblinSimplePasses()
        {
             var maxSlimeHealth = Slime.GetComponent<Slime_hit>().viataMaxima;

             Assert.AreEqual(100, maxSlimeHealth);
        }
    }
}
