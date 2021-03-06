using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        GameObject managerObject = GameObject.Find("GameManager");
        gameManager = managerObject.GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.AddCoinCount();
        if (other.gameObject.tag == "Player") { Destroy(gameObject); }
    }
}
