using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 spd = new Vector3(0, 0, 0.05f);
    int moveTimeCount = 0;

    void Update()
    {
        gameObject.transform.position += spd;
        if (++moveTimeCount>=200)
        {
            moveTimeCount = 0;
            spd = -spd;
        }
    }
}
