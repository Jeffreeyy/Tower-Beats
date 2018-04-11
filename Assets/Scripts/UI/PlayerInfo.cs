﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour {

    public delegate void InfoUpdate();
    public static InfoUpdate s_OnUpdateCoins;
    public static InfoUpdate s_OnUpdateLives;

    [SerializeField] private Text m_Coins;
    [SerializeField] private Text m_Lives;

    private void Awake()
    {
        s_OnUpdateCoins += UpdateCoins;
        s_OnUpdateLives += UpdateLives;
    }

    void UpdateCoins()
    {
        m_Coins.text = PlayerData.s_Instance.Coins.ToString();
    }

    void UpdateLives()
    {
        m_Lives.text = PlayerData.s_Instance.Lives.ToString();
    }

    private void OnDestroy()
    {
        s_OnUpdateCoins -= UpdateCoins;
        s_OnUpdateLives -= UpdateLives;
    }
}