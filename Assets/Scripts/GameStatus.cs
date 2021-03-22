using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    
    [Range(0f,10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int scorePerDamagedBlock = 5;
    [SerializeField] int currentScore;
    [SerializeField] TextMeshProUGUI textComponent;

    private void Start()
    {
        textComponent.text = currentScore.ToString();
    }

    public void AddScore()
    {
        currentScore += scorePerDamagedBlock;
        textComponent.text = currentScore.ToString();
    }

    void Update()
    {
        Time.timeScale = gameSpeed;
    }
}
