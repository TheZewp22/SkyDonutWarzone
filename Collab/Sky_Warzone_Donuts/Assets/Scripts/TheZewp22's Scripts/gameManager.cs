﻿using System.Collections;
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


  void Start()
  {

  }

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







}
