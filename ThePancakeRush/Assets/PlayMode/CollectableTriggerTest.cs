using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace Tests
{
    public class CollectableTriggerTest
    {
        private GameObject egg = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Collectable/Prefabs/Egg.prefab");
        private GameObject player = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Character/Player.prefab");

        [UnityTest]
        public IEnumerator CollectableTriggerTestWithEnumeratorPasses()
        {
            var eggInstance = Object.Instantiate(egg, new Vector3(0, 0, 0), Quaternion.identity);
            var playerInstance = Object.Instantiate(player, new Vector3(0, 0, 0), Quaternion.identity);
            var eggInstance2 = Object.Instantiate(egg, new Vector3(20, 20, 20), Quaternion.identity);

            yield return new WaitForSeconds(1f);

            var value = eggInstance2.GetComponent<Collectable>().getScoreValue();

            Assert.AreEqual(1,value);
        }
    }
}
