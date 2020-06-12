using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
//  The Current Level The Player is In
public static int currentLevel;


  void Start()
  {

  }

  void Update()
  {
    currentLevel = SceneManager.GetActiveScene().buildIndex;
  }










}
