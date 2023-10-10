using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using MoreMountains.Feedbacks;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private TMP_Text earnedMoneyText;
    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button mainMenuButton;
    [SerializeField] private MMFeedbacks playAgainFeedbacks;
    [SerializeField] private MMFeedbacks mainMenuFeedbacks;

    private void Awake()
    {
        playAgainButton.onClick.AddListener(() =>
        {
            playAgainFeedbacks.PlayFeedbacks();
        });

        mainMenuButton.onClick.AddListener(() =>
        {
            // Loader.Load(Loader.Scene.MainMenuScene);
            mainMenuFeedbacks.PlayFeedbacks();
        });
    }

    private void Start()
    {
        KitchenGameManager.Instance.OnStateChanged += KitchenGameManager_OnStateChanged;
        Hide();
    }

    private void KitchenGameManager_OnStateChanged(object sender, EventArgs e)
    {
        if (KitchenGameManager.Instance.IsGameOver())
        {
            Show();
            earnedMoneyText.text = DeliveryManager.Instance.GetSuccessfulCoinAmount().ToString();
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
