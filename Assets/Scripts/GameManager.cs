using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public float score;
    public Text textScore, endScore;
    public Player player;
    public GameObject pauseMenu, resetMenu,topPlatform,downPlatform,spwanPlatform;
    public bool pause;

    [SerializeField]
    private int test;

    private void Start()
    {
        pauseMenu.SetActive(false);
        resetMenu.SetActive(false);
        spwanPlatform.SetActive(false);
        topPlatform.SetActive(true);
        downPlatform.SetActive(true);
        player = player.GetComponent<Player>();
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        ScoreAndDeficalty();
        Deafet();
    }
    void ScoreAndDeficalty()
    {
        if (!pause)
        {
            score += 5 * Time.deltaTime;
            
        }
        if (score >= 50)
        {
            //spawn Platform
            spwanPlatform.SetActive(true);

        }
        if (score >= 100)
        {
            Debug.Log("I achive 1500");
            //despawn the platfrom on the sides
            topPlatform.SetActive(false);
            downPlatform.SetActive(false);
        }
        textScore.text = "Score: " + (int)Mathf.Round(score);
        ;
    }
    void Deafet()
    {
        if (player.dead)
        {
            Time.timeScale = 0f;
            resetMenu.SetActive(true);
            endScore.text = "Score: " + (int)Mathf.Round(score);
            ;
            pause = true;
        }
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(1);
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
