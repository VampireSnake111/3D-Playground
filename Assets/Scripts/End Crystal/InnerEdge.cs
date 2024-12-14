using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerEdge : MonoBehaviour
{
    private float degX = 0f;
    private float degY = 0f;
    private float angleInc = 0.4f;
    void Update()
    {
        degX += angleInc;
        degY += angleInc;
        transform.rotation = Quaternion.Euler(new Vector3(degX, degY, 0));
    }
}
