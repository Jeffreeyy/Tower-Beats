﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShop : MonoBehaviour {

    [SerializeField] private List<GameObject> m_Towers = new List<GameObject>();

    void BuyTower(int cost)
    {
        PlayerData.s_Instance.Coins -= cost;
    }
}