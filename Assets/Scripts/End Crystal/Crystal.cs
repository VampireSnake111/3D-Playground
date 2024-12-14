using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndCrystal{
    public class Crystal : MonoBehaviour
    {
        void Update()
        {
            float moveY = Mathf.Sin(Time.time*3);
            transform.position += new Vector3(transform.position.x, moveY/3.5f, transform.position.z);
        }
    }
}
