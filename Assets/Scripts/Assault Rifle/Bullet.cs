using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssaultRifle{
    public class Bullet : MonoBehaviour
    {
        void Update()
        {
            if(Input.GetMouseButton(0)){
                transform.position -= new Vector3(0, 0, 1);
            }

            if(Input.GetMouseButtonUp(0)){
                transform.position = new Vector3(16.18f, 14.5f, 2.38f);
            }
        }
    }
}
