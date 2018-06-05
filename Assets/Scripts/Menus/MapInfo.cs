﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapInfo : MonoBehaviour {

    public delegate void OnLevelChange(Level selectedLevel);
    public static OnLevelChange s_OnLevelChange;

    [SerializeField] private Text m_TurretPlacement;
    [SerializeField] private Text m_MapSize;
    [SerializeField] private Text m_MapDifficulty;
    [SerializeField] private Text[] m_Songs = new Text[3];

    private void OnEnable()
    {
        s_OnLevelChange += SetMapInfo;
    }

    private void SetMapInfo(Level selectedLevel)
    {
        if(selectedLevel != null)
        {
            m_TurretPlacement.text = "Turret Placements: " + selectedLevel.TurretPlacements.ToString();
            m_MapSize.text = "Map size: " + selectedLevel.MapSize.ToString();
            Debug.Log(m_MapSize.text);
            m_MapDifficulty.text = "Map difficulty: " + selectedLevel.MapDifficulty.ToString();
            Debug.Log(m_MapDifficulty.text);

            for (int i = 0; i < m_Songs.Length; i++)
            {
                m_Songs[i].text = selectedLevel.Songs[i];
            }
        }
    }

    private void OnDisable()
    {
        s_OnLevelChange -= SetMapInfo;
    }
}