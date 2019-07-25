using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Timer
    [SerializeField] TextMeshProUGUI timer = null;
    float minCount = 5, 
          secCount = 0;

    // Start is called before the first frame update
    void Start()
    {

        //if (FindObjectsOfType<GameManager>().Length > 1)
        //{
        //    Destroy(gameObject);
        //}
        //else
        //{
        //    DontDestroyOnLoad(gameObject);
        //}
    }

    private void Update()
    {
        if (timer)
        {
            secCount -= Time.deltaTime;
            if (secCount < 0)
            {
                minCount--;
                secCount = 59;
            }

            if (minCount >= 0)
            {
                timer.text = minCount + ":" + Math.Round(secCount, 0).ToString();
            }
            else
            {
                timer.text = "0:00";
                FindObjectOfType<LevelLoader>().LoseGame();
            }

        }
    }
}
