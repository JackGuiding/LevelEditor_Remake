using System;
using UnityEngine;

namespace LevelSample {

    [Serializable]
    public struct GearSpawnerTM {

        public GearSO so;

        public Vector3 position;
        public Vector3 rotation;

        public bool isHpModifiable;
        public int hp;

        public bool isTipsModifiable;
        public string tipsText;

    }

}