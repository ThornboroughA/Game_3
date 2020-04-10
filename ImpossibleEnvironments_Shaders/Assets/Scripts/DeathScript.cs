using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script "kills" the player by teleporting them back to the start location

public class DeathScript : MonoBehaviour
{
    private GameObject player;
    public GameObject spawnLocation;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void PlayerDeath()
    {
        Debug.Log("You have died");

        StartCoroutine(PlayerSpawn());
    }

    private IEnumerator PlayerSpawn()
    {
        player.GetComponent<CharacterController>().enabled = false;

        //the pause between the death being activated and the teleportation back to start.
        yield return new WaitForSeconds(1f);

        player.transform.position = spawnLocation.transform.position;
        player.GetComponent<CharacterController>().enabled = true;
        
    }
}
