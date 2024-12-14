using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace AssaultRifle{
    public class Recoil : MonoBehaviour
    {
        void Update()
        {
            if(Input.GetMouseButton(0)){
                float rotY = Mathf.PingPong(Time.time * 10, 1);
                transform.rotation = quaternion.Euler(new Vector3(rotY/10, 0f, 0f));
            }
            
            if(Input.GetMouseButtonUp(0)){
                transform.rotation = quaternion.Euler(0, 0, 0);
            }
        }
    }
}
