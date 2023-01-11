using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void NextLevel()
    {
        Debug.Log("BASTIM");
        FindObjectOfType<GameManager>().LoadNextLevel();
    }
}
