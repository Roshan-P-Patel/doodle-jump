using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenorator : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatforms = 4000;
    public float levelWidth = 3f;
    public float minY = 1f;
    public float maxY = 6f;

    public Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i< numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, +levelWidth);
            Instantiate(platformPrefab, spawnPosition, transform.rotation);
            
        }
    }

}
