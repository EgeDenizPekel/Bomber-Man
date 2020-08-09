using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BombCollector : MonoBehaviour
{
    public Text ScoreText;
    private int _score = 0;

    private void IncreaseScore()
    {
        _score++;
        ScoreText.text = $"Score: {_score}";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bomb"))
        {
            IncreaseScore();
            other.gameObject.SetActive(false);
        }
    }
}
