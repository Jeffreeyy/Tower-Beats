﻿using System.Collections.Generic;
using UnityEngine;

public class TowerShopMenu : Menu {

    [SerializeField] private List<Tower> m_Towers = new List<Tower>();

    public void PurchaseTower(string towerType)
    {
        //If player has enough coins
        if(TowerConfig.s_Towers[towerType][0].BuyCost <= PlayerData.s_Instance.Coins && PlayerData.s_Instance.SelectedTile.CurrentState != TileState.OCCUPIED)
        {
            //Gets the buy cost from the towers data
            PlayerData.s_Instance.ChangeCoinAmount(-TowerConfig.s_Towers[towerType][0].BuyCost);

            //Spawns a tower of the type (parameter) passed
            switch (towerType)
            {
                case TowerTypeTags.BASS_TOWER:
                    SpawnTower(towerType, 0);
                    break;
                case TowerTypeTags.DRUM_TOWER:
                    SpawnTower(towerType, 1);
                    break;
                case TowerTypeTags.SYNTH_TOWER:
                    SpawnTower(towerType, 2);
                    break;
            }
            PlayerData.s_Instance.SelectedTile.CurrentState = TileState.OCCUPIED;
            //Hide();
        }
    }

    void SpawnTower(string towerType,int indexInList)
    {
        Tower newTower;
        newTower = Instantiate(m_Towers[indexInList]);
        newTower.TowerData = TowerConfig.s_Towers[towerType][0];
        newTower.transform.position = PlayerData.s_Instance.SelectedTile.transform.position;
        PlayerData.s_Instance.SelectedTile.Tower = newTower;
    }
}