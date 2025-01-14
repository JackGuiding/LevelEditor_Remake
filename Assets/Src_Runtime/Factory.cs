using System;
using UnityEngine;

namespace LevelSample {

    public static class Factory {

        // TypeID + Position + Rotation
        public static GearEntity Gear_CreateBySpawner(AssetsCore assetsCore, GearSpawnerTM spawnerTM) {
            var gear = Gear_Create(assetsCore, spawnerTM.so.tm.typeID, spawnerTM.position, spawnerTM.rotation);
            if (spawnerTM.isHpModifiable) {
                gear.hp = spawnerTM.hp;
            }
            if (spawnerTM.isTipsModifiable) {
                gear.Tips_Set(spawnerTM.tipsText);
            }
            return gear;
        }

        static GearEntity Gear_Create(AssetsCore assetsCore, int typeID, Vector3 pos, Vector3 rot) {
            bool has = assetsCore.Entity_Gear_TryGet(out GameObject prefab);
            if (!has) {
                Debug.LogError("Factory.Gear_Create: Entity_Gear not found");
                return null;
            }

            GearTM tm; // 栈上开了个新的, 值拷贝
            has = assetsCore.Gear_TryGet(typeID, out tm);
            if (!has) {
                Debug.LogError("Factory.Gear_Create: Gear not found: " + typeID);
                return null;
            }

            GameObject go = GameObject.Instantiate(prefab);
            GearEntity gearEntity = go.GetComponent<GearEntity>();

            // - TF(Transform)
            gearEntity.TF_SetPosition(pos);
            gearEntity.TF_SetRotation(rot);

            // - Mod
            GameObject mod = GameObject.Instantiate(tm.modPrefab, gearEntity.body);

            // - Attribute
            gearEntity.moveSpeed = tm.moveSpeed;
            gearEntity.hp = tm.hpMax;
            gearEntity.hpMax = tm.hpMax;

            // - Tips
            gearEntity.Tips_Show(tm.isTips);

            return gearEntity;
        }

    }

}