using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;

    [SerializeField] int currentBalance;
    [SerializeField] TextMeshProUGUI displayBalance;
    public GameObject GameOveer;
    public GameObject pusemanu;
    
    public int CurrentBalance { get { return currentBalance; } }

    void Start()
    {
        GameOveer.SetActive(false);
        pusemanu.SetActive(false);
        
    }
    void Awake()
    {
        currentBalance = startingBalance;
        UpdateDisplay();

    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();

    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateDisplay();
        if (currentBalance < 0)
        {
            //Lose the game;
            
            GameOver();
            
        }
    }
    void UpdateDisplay()
    {
        displayBalance.text = "Gold: " + currentBalance;
    }
    public void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);

    }
    public void MainScene()
    {
       
        SceneManager.LoadScene(0);
        resume();

    }

    public void GameOver()
    {
        GameOveer.SetActive(true);
        

    }
    public void puseGame()
    {
        pusemanu.SetActive(true);
        Time.timeScale = 0;
    }
    public void resume()
    {
        pusemanu.SetActive(false);
        Time.timeScale = 1;
    }
}