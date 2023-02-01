using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;

    public int score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            _scoreText.text = value.ToString();
        }
    }

    private int _score;
    [SerializeField] private TMP_Text _scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
