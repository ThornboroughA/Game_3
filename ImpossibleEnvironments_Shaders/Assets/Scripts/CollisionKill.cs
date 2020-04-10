using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script activates the DeathScript if an attached trigger collider is activated, e.g. by walking into a laser or fan

public class CollisionKill : MonoBehaviour
{
    private GameObject gameManager;

    private AudioSource audioSource;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController");

        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(audioSource.clip, 1f);

        gameManager.GetComponent<DeathScript>().PlayerDeath();
    }
}
