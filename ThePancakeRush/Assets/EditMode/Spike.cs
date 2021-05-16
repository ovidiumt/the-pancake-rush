using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

namespace Tests
{
    public class Spike
    {

        private GameObject spike = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Models/Environment/Traps/Prefabs/Spike.prefab");
        // A Test behaves as an ordinary method
        [Test]
        public void SpikeDamageValueTest()
        {
            var valueAttack = spike.GetComponent<SpikeDamage>().valoareLovitura;

            Assert.AreEqual(20, valueAttack);
        }

        [Test]
        public void SpikeRateOfAttackTest()
        {
            var rateOfAttack = spike.GetComponent<SpikeDamage>().rataDeAtac;

            Assert.AreEqual(2, rateOfAttack);
        }
    }
}
