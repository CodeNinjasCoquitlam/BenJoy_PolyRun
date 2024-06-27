using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Make sure to make challenge objects an array - To myself
    public GameObject challengeObject;
    public float spawnDelayRandom1 = 1f;
    public float spawnDelayRandom2 = 5f;
    public float spawnTimeRandom1 = 2f;
    public float spawnTimeRandom2 = 6f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", Random.Range(spawnDelayRandom1, spawnDelayRandom2), Random.Range(spawnTimeRandom1, spawnDelayRandom2));

    }
    void InstantiateObjects()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, -2, 0);
    }
}
