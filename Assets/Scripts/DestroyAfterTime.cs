using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{

    public GameObject ThingtoDestroy;
    public float timeToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestoryObject", timeToDestroy);
    }

    void DestoryObject()
    {
        Destroy(ThingtoDestroy);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

