using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject follow;

    void Update()
    {
        
        if (follow.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, follow.transform.position.y, transform.position.z);
        }
    }
}
