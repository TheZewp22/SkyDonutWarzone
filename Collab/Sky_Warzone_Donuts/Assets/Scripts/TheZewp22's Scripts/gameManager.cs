using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class gameManager : MonoBehaviour
{
public TextMeshProUGUI scoreText;
public static int score;
public GameObject pauseMenu;
public GameObject gameOverMenu;
public TextMeshProUGUI gscoreText;

  

  void Update()
  {
  if (Input.GetKey("escape"))
  {
  pauseMenu.SetActive(true);
  Time.timeScale = 0f;
  }    

  }
  public void IncreaseScore()
  {
  score++;
  scoreText.text = score.ToString();
  }

  public void Quit()
  {
  Application.Quit();
  }
  public void Resume()
  {
  pauseMenu.SetActive(false);
  Time.timeScale = 1f;
  }

  public void GameOver()
  {
    gscoreText.text = score.ToString();
    gameOverMenu.SetActive(true);
    
  }
  public void Restart()
  {
    gameOverMenu.SetActive(false);
    Time.timeScale = 1f;
    SceneManager.LoadScene(1);
  }




}
