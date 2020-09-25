using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpPower;
    public float moveSpeed;
    public float rbMoveSpeed;
    public float boostPower;
    public GameObject deathPanel;
    public GameObject startPanel;
    public Text scoreText;
    public Text panelScoreText;
    private int score;
    public Animator anim;

    void Start()
    {
        scoreText.text = score.ToString();
        panelScoreText.text = score.ToString();
    }



    private void FixedUpdate()
    {



        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    if (touch.phase == TouchPhase.Moved)
        //    {
        //        rb.position = new Vector3(rb.position.x + -touch.deltaPosition.x * moveSpeed, rb.position.y, rb.position.z);
        //    }
        //}

        float movementX = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(transform.position.x + movementX * (rbMoveSpeed * Time.deltaTime), transform.position.y, transform.position.z);
        rb.MovePosition(movement);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("MainPlatform"))
        {
            rb.velocity = Vector3.up * jumpPower;
            anim.SetBool("isBoosting", false);
        }
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            deathPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boost"))
        {
            rb.velocity = Vector3.up * boostPower;
            anim.SetBool("isBoosting", true);
        }
        if (other.CompareTag("AddScore"))
        {
            AddScore();
            Destroy(other.gameObject);
        }
        if (other.CompareTag("ParentPlatform"))
        {
            Destroy(other.gameObject);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        deathPanel.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        panelScoreText.text = score.ToString();
    }



}
