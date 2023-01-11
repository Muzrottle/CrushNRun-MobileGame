using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float LoadDelay = 2f;
    public GameObject completeLevelUI;
    public GameObject failLevelUI;
    public float RestartDelay = 0.5f;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void FailLevel()
    {
        failLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", RestartDelay); //Delays restarting.
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
