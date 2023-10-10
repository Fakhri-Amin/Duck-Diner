using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GamePlayingClockUI : MonoBehaviour
{
    [SerializeField] private Image timerImage;
    [SerializeField] private TMP_Text timerText;

    private void Update()
    {
        // timerImage.fillAmount = KitchenGameManager.Instance.GetGamePlayingTimerNormalized();
        if (KitchenGameManager.Instance.IsGameOver())
        {
            DisplayTime(0);
            return;
        }
        DisplayTime(KitchenGameManager.Instance.GetGamePlayingTimerNormalized());
    }

    private void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{00:00} : {01:00}", minutes, seconds);
    }
}
