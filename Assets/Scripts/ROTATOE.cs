using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATOE : MonoBehaviour
{
    public GameObject ThingToRotate;
    [Header(" negative is clockwise positive is counter clockwise")]
    public float RotationSpeed;
    [Header("0 = x, 1 = y, 2= z for rotation")]
    public float RotationAxis;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RotationAxis == 0)
        {
            ThingToRotate.transform.Rotate(RotationSpeed, 0, 0);
        }
        if (RotationAxis == 1)
        {
            ThingToRotate.transform.Rotate(0, RotationSpeed, 0);
        }
        if (RotationAxis == 2)
        {
            ThingToRotate.transform.Rotate(0, 0, RotationSpeed);
        }
    }
}
