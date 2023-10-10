using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MoreMountains.Feedbacks;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private MMFeedbacks playFeedbacks;

    private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {
            // Loader.Load(Loader.Scene.GameScene);
            playFeedbacks.PlayFeedbacks();
        });

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });

        Time.timeScale = 1f;
    }
}
