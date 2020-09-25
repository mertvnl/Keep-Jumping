using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public GameObject platform;
    private Vector3 newPos;

    private void Start()
    {
        newPos = new Vector3(Random.Range(-3f, 3), transform.position.y + 14, transform.position.z);
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(platform, newPos, transform.rotation);
            Destroy(gameObject);
        }
    }
}
