using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextChanger : MonoBehaviour
{
    public static TextChanger current;
    [SerializeField] private Text _textScore;
    [SerializeField] private Text _textEnemy;

    private float _score=0;
    private float _enemy=1;

    private void Awake()
    {
        current = this;
    }
    public bool NeedMoreEnemy => _enemy < 10;
    public void ChangeTextEnemy(float quantity)
    {
        _enemy += quantity;
        _textEnemy.text = $"Number of enemies {_enemy}/10";
    }
    public void ChangeTextScore(float quantity)
    {
        _score += quantity;
        _textScore.text = $"Score: {_score}";
    }
}
