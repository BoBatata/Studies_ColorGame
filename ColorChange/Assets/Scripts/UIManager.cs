using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        scorePanel.SetActive(false);
    }

    private void Update()
    {
        scoreText.text = "Pontuação: " + GameManager.instance.GetPlayerScore().ToString();
    }

    public void EnableScorePanel()
    {
        scorePanel.SetActive(true);
    }
}
