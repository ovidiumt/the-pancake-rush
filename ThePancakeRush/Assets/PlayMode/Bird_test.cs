using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

namespace Tests
{
    public class Bird_test
    {
        private GameObject Bird = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Enemies/Prefabs/Bird.prefab");

        [UnityTest]
        public IEnumerator Bird_testMaxHealth()
        {
            var instance = Object.Instantiate(Bird, new Vector3(0, 0, 0), Quaternion.identity);

            yield return new WaitForSeconds(0.5f);

            Assert.AreEqual(100, instance.GetComponent<Bird_hit>().viataRamasa);
        }
    }
}
