using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public InputManager inputManager { get; private set; }
    public PlayerBehavior playerBehavior;
    public ColorManager colorManager;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        inputManager = new InputManager();
    }


}
