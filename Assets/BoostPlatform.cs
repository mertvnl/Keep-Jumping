using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPlatform : MonoBehaviour
{
    public GameObject player;
    private float yPos;
    private Collider col;
    public bool canMove = true;
    public Rigidbody rb;
    private Vector3 newPos;
    public float moveSpeed = 1f;
    public bool canGoRight;
    public bool canGoLeft;
    private void Start()
    {
        SetVariables();
    }
    private void Update()
    {
        StartCoroutine(ColliderCheck());
        if (canMove)
        {
            Move();
        }
    }

    private void SetVariables()
    {
        player = GameObject.Find("Player");
        yPos = transform.position.y + 0.2f;
        col = GetComponent<BoxCollider>();
        canGoRight = true;
        SetMove(Random.Range(0, 2));
        moveSpeed = Random.Range(1f, 10f);
        newPos = new Vector3(Random.Range(-3f, 3), transform.position.y, transform.position.z);
        transform.position = newPos;
    }

    private void SetMove(int value)
    {
        if (value == 1)
        {
            canMove = true;
        }
        else if (value == 0)
        {
            canMove = false;
        }
    }

    private void Move()
    {
        if (transform.position.x > 3f)
        {
            canGoLeft = true;
            canGoRight = false;
        }
        else if (transform.position.x < -3f)
        {
            canGoRight = true;
            canGoLeft = false;
        }
        if (canGoRight)
        {
            GoRight();
        }
        if (canGoLeft)
        {
            GoLeft();
        }
    }
    private void GoLeft()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
    }

    private void GoRight()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
    }

    IEnumerator ColliderCheck()
    {
        if (yPos > player.transform.position.y)
        {
            col.enabled = false;
        }
        if (yPos < player.transform.position.y)
        {
            yield return new WaitForSeconds(0.1f);
            col.enabled = true;
        }
    }

}



