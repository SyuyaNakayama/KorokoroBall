using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[ÉãÅIÅI");
        clearText.SetActive(true);
        nextButton.SetActive(true);
        audioSource.Play();
    }
}
