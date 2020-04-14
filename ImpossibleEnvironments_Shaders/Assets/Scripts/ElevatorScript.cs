using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    private bool isActive;

    /// <summary>
    /// I was trying to parent the player to the elevator so they wouldn't stutter when going up it, but it looks harder than I thought. give it a go if you have the time!
    /// </summary>
    private GameObject player;

    public GameObject collisionPlane;
    public Animator anim;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

        anim = GetComponent<Animator>();

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        player.transform.parent = collisionPlane.transform;

        StartCoroutine(ElevatorUp());

    }
    private void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }

    private IEnumerator ElevatorUp()
    {

        //anim.ElevatorUpActive = true;

        anim.SetBool("ElevatorUpActive", true);

        yield return new WaitForSeconds(3f);
    }
}