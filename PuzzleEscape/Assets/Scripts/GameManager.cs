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

    [SerializeField]  int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        MusicManager.instance.ChangeToLevelAudio(level);
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
                if (secCount < 10)
                {
                    timer.text = minCount + ":" + "0" + Math.Round(secCount, 0).ToString();
                }
            }
            else
            {
                timer.text = "0:00";
                LoseGame();
            }

        }
    }

    public void LoseGame()
    {
        FindObjectOfType<LevelLoader>().LoseGame();
    }

    public void WinGame()
    {
        FindObjectOfType<LevelLoader>().NextScene();
    }
}
