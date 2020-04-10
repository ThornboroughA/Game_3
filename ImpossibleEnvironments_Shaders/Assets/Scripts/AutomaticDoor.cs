using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDoor : MonoBehaviour
{
    public bool doorOpenable = true;
    public GameObject doorChild;
    private bool doorOpen;

    private bool openTrigger;
    private bool closeTrigger;

    private AudioSource[] audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponents<AudioSource>();
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (doorOpenable == true)
        {
            if (doorOpen == false && closeTrigger == false && other.transform.CompareTag("Player"))
            {
                StartCoroutine(DoorDown());
            }

        }
        else
        {
            audioSource[2].PlayOneShot(audioSource[2].clip, 1f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (doorOpen == true && openTrigger == false && other.transform.CompareTag("Player"))
        {
            StartCoroutine(DoorUp());
        }
    }


    private IEnumerator DoorDown()
    {

        closeTrigger = true;

        float counter = 0f;
        float duration = 2f;

        audioSource[0].PlayOneShot(audioSource[0].clip, 1f);

        while (counter < duration)
        {
            counter += Time.deltaTime;
            doorChild.transform.localPosition = Vector3.Lerp(new Vector3(0, 0, 0.015f), new Vector3(0, 0, -0.014f), counter / duration);

            yield return null;

        }

        doorOpen = true;

        yield return new WaitForSeconds(2f);

        if(openTrigger == false) {
            StartCoroutine(DoorUp());
        }

        closeTrigger = false;
    }
    private IEnumerator DoorUp()
    {
        openTrigger = true;

        float counter = 0f;
        float duration = 2f;

        audioSource[0].PlayOneShot(audioSource[0].clip, 1f);

        while (counter < duration)
        {
            counter += Time.deltaTime;
            doorChild.transform.localPosition = Vector3.Lerp(new Vector3(0, 0, -0.014f), new Vector3(0, 0, 0.015f), counter / duration);

            yield return null;
        }

        doorOpen = false;

        audioSource[1].PlayOneShot(audioSource[1].clip, 1f);

        openTrigger = false;
    }

    
   

}
