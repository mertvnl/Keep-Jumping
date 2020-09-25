using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissBoost : MonoBehaviour
{
    public GameObject boost;
    float newYposition;
    int newXposition;
    void Start()
    {
        newXposition = Random.Range(-3, 3);
        newYposition = boost.transform.position.y + 40;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SetPos();
            boost.transform.position = new Vector3(newXposition, newYposition, boost.transform.position.z);
            
        }
    }

    private void SetPos()
    {
        newXposition = Random.Range(-3, 3);
        newYposition = boost.transform.position.y + 40;
    }
}
