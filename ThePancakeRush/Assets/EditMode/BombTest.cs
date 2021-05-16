using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace Tests
{
    public class BombTest
    {
        private GameObject bomb = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Projectiles/Prefabs/Bomb.prefab");


        [Test]
        public void BombDamageValueTest()
        {
            var value = bomb.GetComponent<Bomb>().attackValue;

            Assert.AreEqual(40, value);
        }

        [Test]
        public void BombSpeedTest()
        {
            var value = bomb.GetComponent<Bomb>().speed;

            Assert.AreEqual(4, value);
        }
    }
}
