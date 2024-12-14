using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndCrystal{
    public class OuterEdge : MonoBehaviour
    {
        private float degY = 0f;
        private float angleInc = 0.3f;
        void Update()
        {
            degY += angleInc;
            transform.rotation = Quaternion.Euler(new Vector3(45, degY, 0));
        }
    }
}
