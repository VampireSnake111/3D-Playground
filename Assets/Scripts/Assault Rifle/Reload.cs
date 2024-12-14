using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace AssaultRifle{
    public class Reload : MonoBehaviour
    {
        Vector3 start = new Vector3(16.17f, 15.01f, 15.32f);
        Vector3 end = new Vector3(16.17f, 12.51f, 15.32f);
        int direction = 0;
        void Update()
        {
            if(Input.GetKey(KeyCode.R)){

                switch(direction){
                    case 0:
                        if(transform.position != end){
                            transform.position -= new Vector3(0, 0.05f, 0);
                        }
                        else{
                            direction = 1;
                        }
                        break;
                    case 1:
                        if(transform.position != start){
                            transform.position += new Vector3(0, 0.05f, 0);
                        }
                        else{
                            direction = 0;
                        }
                        break;
                }
            }
        }
    }
}