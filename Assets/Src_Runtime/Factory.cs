using System;
using UnityEngine;

namespace LevelSample {

    public static class Factory {

        public static GearEntity CreateGearEntity() {
            GameObject go = new GameObject("GearEntity");
            GearEntity gearEntity = go.AddComponent<GearEntity>();
            return gearEntity;
        }

    }

}