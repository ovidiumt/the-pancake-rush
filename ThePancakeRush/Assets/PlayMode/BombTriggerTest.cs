using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace Tests
{
    public class BombTriggerTest
    {
        private GameObject bomb = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Projectiles/Prefabs/Bomb.prefab");
        private GameObject player = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Character/Player.prefab");

        [UnityTest]
        public IEnumerator BombTriggersOnPlayerTest()
        {

            var bombInstance = Object.Instantiate(bomb, new Vector3(0, 0, 0), Quaternion.identity);
            var playerInstance = Object.Instantiate(player, new Vector3(0, 0, 0), Quaternion.identity);

            yield return new WaitForSeconds(1f);

            var value = playerInstance.GetComponent<Player_attack>().viataRamasa;
            Assert.AreEqual(460, value);
        }
    }
}
