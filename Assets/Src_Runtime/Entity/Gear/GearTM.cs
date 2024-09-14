using System;
using UnityEngine;

namespace LevelSample {

    // 原型: 设计图纸
    [Serializable]
    public struct GearTM {

        public int typeID;
        public string typeName; // 开发者自己看的

        public float moveSpeed;
        public int hpMax;

        public GameObject modPrefab;

    }

}