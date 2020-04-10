using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanScript : MonoBehaviour
{
    public float fanSpeed = 7f;

    void Update()
    {
        transform.Rotate(-fanSpeed, 0, 0);
    }
}
