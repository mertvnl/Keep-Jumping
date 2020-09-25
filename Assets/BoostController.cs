using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostController : MonoBehaviour
{
    float newYposition;
    int newXposition;
    void Start()
    {
        FirstPosition();
        newXposition = Random.Range(-3, 3);
        newYposition = transform.position.y + 120;
    }

    private void FirstPosition()
    {
        transform.position = new Vector3(Random.Range(-3,3), 40, transform.position.z);
    }

    private void SetPositions()
    {
        newXposition = Random.Range(-3, 3);
        newYposition = transform.position.y + 120;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position = new Vector3(newXposition, newYposition, transform.position.z);
            SetPositions();
        }
    }
}
