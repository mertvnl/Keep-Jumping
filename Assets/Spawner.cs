using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float newYposition;
    int newXposition;
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;
    public GameObject platform5;
    private Vector3 newPos1;
    private Vector3 newPos2;
    private Vector3 newPos3;
    private Vector3 newPos4;
    private Vector3 newPos5;
    void Start()
    {
        newPos1 = new Vector3(Random.Range(-3f, 3), transform.position.y + 3, transform.position.z);
        newPos2 = new Vector3(Random.Range(-3f, 3), transform.position.y + 6, transform.position.z);
        newPos3 = new Vector3(Random.Range(-3f, 3), transform.position.y + 9, transform.position.z);
        newPos4 = new Vector3(Random.Range(-3f, 3), transform.position.y + 12, transform.position.z);
        newPos5 = new Vector3(Random.Range(-3f, 3), transform.position.y + 15, transform.position.z);
    }


    private void SetPositions()
    {
        newPos1 = new Vector3(Random.Range(-3f, 3), transform.position.y + 3, transform.position.z);
        newPos2 = new Vector3(Random.Range(-3f, 3), transform.position.y + 6, transform.position.z);
        newPos3 = new Vector3(Random.Range(-3f, 3), transform.position.y + 9, transform.position.z);
        newPos4 = new Vector3(Random.Range(-3f, 3), transform.position.y + 12, transform.position.z);
        newPos5 = new Vector3(Random.Range(-3f, 3), transform.position.y + 15, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Destroy(Instantiate(platform1, newPos1, platform1.transform.rotation), 10);
            //Destroy(Instantiate(platform2, newPos2, platform2.transform.rotation), 10);
            //Destroy(Instantiate(platform3, newPos3, platform3.transform.rotation), 10);
            //Destroy(Instantiate(platform4, newPos4, platform4.transform.rotation), 10);
            //Destroy(Instantiate(platform5, newPos5, platform5.transform.rotation), 10);
            Instantiate(platform1, newPos1, platform1.transform.rotation);
            Instantiate(platform1, newPos1, platform1.transform.rotation);
            Instantiate(platform1, newPos1, platform1.transform.rotation);
            Instantiate(platform1, newPos1, platform1.transform.rotation);
            Instantiate(platform1, newPos1, platform1.transform.rotation);
            SetPositions();
        }
    }
}
