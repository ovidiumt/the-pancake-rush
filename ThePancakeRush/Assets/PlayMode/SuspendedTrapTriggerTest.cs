using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace Tests
{
    public class SuspendedTrapTriggerTest
    {
        private GameObject trap = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Environment/Traps/Prefabs/Suspended_TrapVariant.prefab");
        private GameObject player = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Character/Player.prefab");

        [UnityTest]
        public IEnumerator SuspendedTrapTriggerTestWithEnumeratorPasses()
        {
            var trapInstance = Object.Instantiate(trap, new Vector3(0, 0, 0), Quaternion.identity);
            var playerInstance = Object.Instantiate(player, new Vector3(0, 0, 0), Quaternion.identity);

            yield return new WaitForSeconds(3f);

            var value = playerInstance.GetComponent<Player_attack>().viataRamasa;
            Assert.AreEqual(500, value);
        }
    }
}