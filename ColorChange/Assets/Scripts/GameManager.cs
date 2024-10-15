using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public InputManager inputManager { get; private set; }
    public PlayerBehavior playerBehavior;
    public ColorManager colorManager;

    [SerializeField] private int playerPoints;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        inputManager = new InputManager();
    }

    public void AddPlayerPoints(int pointToAdd)
    {
        playerPoints += pointToAdd;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
