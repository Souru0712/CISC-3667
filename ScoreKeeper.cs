using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    [SerializeField] int score = 0;
    const int DEFAULT_POINTS = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoints()
    {
        AddPoints(DEFAULT_POINTS);
    }

    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("score: " + score);
    }
    public void ReducePoint()
    {
        ReducePoint(DEFAULT_POINTS);
    }
    public void ReducePoint(int points)
    {
        score -= points;
        Debug.Log("score: " + score);
    }
}
