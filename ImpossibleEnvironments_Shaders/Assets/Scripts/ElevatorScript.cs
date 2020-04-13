using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    private bool isActive;

    /// <summary>
    /// I was trying to parent the player to the elevator so they wouldn't stutter when going up it, but it looks harder than I thought. give it a go if you have the time!
    /// </summary>
    //private GameObject player;


    void Start()
    {
       // player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       // player.transform.parent = transform;

        if (isActive == false)
        {
            StartCoroutine(ElevatorUp());
        }

       
    }
    private void OnTriggerExit(Collider other)
    {
       // player.transform.parent = null;
    }

    private IEnumerator ElevatorUp()
    {
        isActive = true;
        

        float counter = 0f;
        float duration = 15f;

        yield return new WaitForSeconds(1f);

        while (counter < duration)
        {
            counter += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(new Vector3(-1.557f, -2.753f, -33.758f), new Vector3(-1.557f, 16.048f, -33.758f), counter / duration);

            yield return null;

        }

    }

}
