using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlatform : MonoBehaviour
{
    public GameObject player;
    private float yPos;
    private Collider col;
    public bool canMove = true;
    public Rigidbody rb;
    public float moveSpeed = 1f;
    public bool canGoRight;
    public bool canGoLeft;
    private void Start()
    {
        yPos = transform.position.y + 0.2f;
        col = GetComponent<BoxCollider>();
        canGoRight = true;
    }
    private void Update()
    {
        StartCoroutine(ColliderCheck());
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



