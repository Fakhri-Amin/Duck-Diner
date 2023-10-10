using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text cointAmountText;

    // Start is called before the first frame update
    void Start()
    {
        DeliveryManager.Instance.OnRecipeSuccess += DeliveryManager_OnRecipeSuccess;
        UpdateUI();
    }

    private void DeliveryManager_OnRecipeSuccess(object sender, EventArgs e)
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        cointAmountText.text = DeliveryManager.Instance.GetSuccessfulCoinAmount().ToString();
    }
}
