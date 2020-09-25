using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject deathPanel;
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        deathPanel.SetActive(false);
    }
}
