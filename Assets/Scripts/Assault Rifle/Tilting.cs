using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace AssaultRifle{
    public class Tilting : MonoBehaviour
    {   
        Vector3 rot1 = new Vector3(0, 0, 1);
        Vector3 rot2 = new Vector3(0, 0, 0);
        void Update()
        {
            if(Input.GetKey(KeyCode.D)){
                rot2 += rot1;
                transform.rotation = quaternion.Euler(rot2 * Time.smoothDeltaTime);
            }

            if(Input.GetKey(KeyCode.A)){
                rot2 -= rot1;
                transform.rotation = quaternion.Euler(rot2 * Time.smoothDeltaTime);
            }
        }
    }
}
