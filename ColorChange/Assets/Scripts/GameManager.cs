using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public InputManager inputManager { get; private set; }
    public PlayerBehavior playerBehavior;
    public ColorManager colorManager;
    public InfinitePhaseManager infinitePhaseManager;
    public UIManager uiManager;

    [SerializeField] private int playerPoints;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        inputManager = new InputManager();

        Time.timeScale = 1;
    }

    public void AddPlayerPoints(int pointToAdd)
    {
        playerPoints += pointToAdd;
    }

    public void PlayerLose()
    {
        uiManager.EnableScorePanel();
        Time.timeScale = 0;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public int GetPlayerScore()
    {
        return playerPoints;
    }
}
