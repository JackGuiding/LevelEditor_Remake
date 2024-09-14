using System;
using UnityEngine;

namespace LevelSample {

    public class GearEntity : MonoBehaviour {

        [SerializeField] public Transform body;

        public float moveSpeed;

        public int hp;
        public int hpMax;

        public GameObject mod;

        public void TF_SetPosition(Vector3 position) {
            transform.position = position;
        }

        public void TF_SetRotation(Vector3 eulerAngles) {
            transform.rotation = Quaternion.Euler(eulerAngles);
        }

        public void Mod_Init(GameObject mod) {
            this.mod = mod;
        }

    }

}