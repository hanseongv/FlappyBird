using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager instace; //싱글턴패턴
    public GameObject gameOverUI;
    public Text scoreUI;
    private int score = 0;
    private bool isGameOver;

    private void Start()
    {
    }

    private void Awake()
    {
        instace = this;
        gameOverUI.SetActive(false);
    }

    internal void SetGameOver()
    {
        isGameOver = true;
        ShowGameOver(true);
    }

    internal void ShowGameOver(bool active)
    {
        gameOverUI.SetActive(active);
    }

    // Update is called once per frame //킼

    internal void AddScore()
    {
        score += 10000;
        scoreUI.text = "Score : " + score;
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//게임 재시작
            }
        }
    }
}