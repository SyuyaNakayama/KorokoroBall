using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToGoal : MonoBehaviour
{
    public GameObject goal;
    public GameManager manager;

    void Update()
    {
        if (manager.coinCount == 8)
        {
            goal.SetActive(true);
        }
    }
}
