using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class controller : MonoBehaviour
{   
    [SerializeField] private float timerMin = 0.5f;
    [SerializeField] private float timerMax = 2f;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float spawnHeight = 5f;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private string scorePrefix = "Score: ";

    private float timer;
    private float currentTime;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(timerMin, timerMax);
        currentTime = 0f;
        scoreText.text = scorePrefix + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timer)
        {
            Instantiate(coinPrefab, new Vector3(8f, spawnHeight, 0f), Quaternion.identity);
            currentTime = 0f;
            timer = Random.Range(timerMin, timerMax);
        }

    }
    public void IncreaseScore()
    {   
        Debug.Log("Score Increased");
        score ++;
        scoreText.text = scorePrefix + score.ToString();
    }
}
