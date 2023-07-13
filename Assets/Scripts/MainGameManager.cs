using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainGameManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject MainHudPanel;
    [SerializeField] private Text distanceTravelled;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver() 
    {
        GameObject player = GameObject.FindWithTag("Player");
        distanceTravelled.text = "Distance Travelled: " +((int)player.GetComponent<PlayerController>().distanceTraveled).ToString();
        gameOverPanel.SetActive(true);
        MainHudPanel.SetActive(false);
        Time.timeScale = 0;
    }

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home() 
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
