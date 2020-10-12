using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject Dood;

    private void Update()
    {
        if (Dood.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(0, Dood.transform.position.y, -10);
        }
    }
}

