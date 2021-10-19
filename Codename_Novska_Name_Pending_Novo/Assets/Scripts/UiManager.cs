using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameManager gm;

    [Header("UI objects")]
    public Text scoreText;
    public Text timerText;

    [Header("Time data - do not change")]
    public int minutes;
    public int seconds;
    public float allTime;

    public void UpdateText(int kolkoImamo, int kolkoJeMax)
    {
        scoreText.text = kolkoImamo + "/" + kolkoJeMax;
    }

    private void Update()
    {
        allTime += Time.deltaTime;
        minutes = (int)(allTime / 60);
        seconds = (int)(allTime % 60);

        if (minutes < 10 && seconds < 10)
        {
            timerText.text = "0" + minutes + ":" + "0" + seconds;
        }

        else if (minutes < 10 && seconds >= 10)
        {
            timerText.text = "0" + minutes + ":" + seconds;
        }

        else if (minutes >= 10 && seconds < 10)
        {
            timerText.text = minutes + ":" + "0" + seconds;
        }

        else
        {
            timerText.text = minutes + ":" + seconds;
        }

    }
}
