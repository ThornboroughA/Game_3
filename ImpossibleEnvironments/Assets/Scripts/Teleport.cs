using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject w1;
    public GameObject w2;
    //private float playerXPos;
    //private float playerYPos;
    //private float playerZPos;
    private bool inRealWorld = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (inRealWorld == true)
            {
                player.transform.position += new Vector3(30, 0, 0);
                Debug.Log("turned from real world to parallel world");
                w2.SetActive(true);
                w1.SetActive(false);
            }
            else
            {
                player.transform.position += new Vector3(-30, 0, 0);
                Debug.Log("turned from parallel world to real world");
                w2.SetActive(false);
                w1.SetActive(true);
            }
            inRealWorld = !inRealWorld;
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(inRealWorld);
        }
    }
}
