using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssaultRifle{
    public class Fire : MonoBehaviour
    {
        Vector3 scale = new Vector3(1, 1, 1);
        void Update()
        {
            if(Input.GetMouseButtonDown(0)){
                transform.localScale = scale;
            }

            if(Input.GetMouseButtonUp(0)){
                transform.localScale = Vector3.zero;
            }
        }
    }
}
