using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

namespace Tests
{
    public class HealthPotion
    {
        private GameObject healthPotion = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Collectable/Prefabs/Health_Potion.prefab");
        // A Test behaves as an ordinary method
        [Test]
        public void HealthPotionHealingValue()
        {
            var valueOfHealing = healthPotion.GetComponent<Health_Potion>().healingValue;

            Assert.AreEqual(20, valueOfHealing);
        }

    }
}
