using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    public float destroyZRangeUP = 30.0f;
    public float destroyZRangeDown = -20.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > destroyZRangeUP)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < destroyZRangeDown)
        {
            Destroy(gameObject);
        }
    }
}
