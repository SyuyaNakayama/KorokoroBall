using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.RotateAround(new Vector3(0,0,0),new Vector3(0,1,0),0.2f);
    }
}
