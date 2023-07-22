using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPoint : MonoBehaviour
{
    [SerializeField] int Point;
    [SerializeField] Text Score;

    private void Start()
    {
        Score.text = Point.ToString();
    }

    public void AddToScore (int score)
    {
        Point += score;
        Score.text = Point.ToString();
    }
}