using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFail : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartLevel()
    {
        Debug.Log("BASTIM");
        FindObjectOfType<GameManager>().EndGame();
    }
}
