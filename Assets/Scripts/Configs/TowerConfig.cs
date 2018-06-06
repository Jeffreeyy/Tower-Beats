﻿using System.Collections.Generic;

public class TowerConfig
{
    public static Dictionary<string, List<TowerData>> s_Towers = new Dictionary<string, List<TowerData>>()
    {
        // TYPE, LEVEL, MAXLEVEL, UPGRADECOST, BUYCOST, VALUE (Sell), DAMAGE, RANGE, INTERVAL
        {TowerTypeTags.BASS_TOWER, new List<TowerData>() {
            new TowerData(TowerTypeTags.BASS_TOWER, 1, 3, 200, 150, 75, 2f, 3.1f, 1.5f),
            new TowerData(TowerTypeTags.BASS_TOWER, 2, 3, 200, 0, 225, 2.5f, 3.1f, 1.25f),
            new TowerData(TowerTypeTags.BASS_TOWER, 3, 3, 0, 0, 375, 3.5f, 3.1f, .75f)
        }},//1 DPS(AoE)
        {TowerTypeTags.DRUM_TOWER, new List<TowerData>()
        {
            new TowerData(TowerTypeTags.DRUM_TOWER, 1, 3, 200, 350, 225, 4f, 3f, 0.35f),
            new TowerData(TowerTypeTags.DRUM_TOWER, 2, 3, 300, 0, 375, 5f,3.25f,0.3f),
            new TowerData(TowerTypeTags.DRUM_TOWER, 3, 3, 0, 0 , 600, 7f, 3.5f, 0.25f)
        }},//4 DPS Single target
        {TowerTypeTags.LEAD_TOWER, new List<TowerData>()
        {  //10 DPS Single target
            new TowerData(TowerTypeTags.LEAD_TOWER, 1, 3, 200, 200, 150, 0.25f, 3.25f, 0.025f),
            new TowerData(TowerTypeTags.LEAD_TOWER, 2, 3, 300, 0, 300, 0.5f, 3.5f, 0.025f),
            new TowerData(TowerTypeTags.LEAD_TOWER, 3, 3, 0, 0, 525, 0.75f, 3.75f, 0.025f)
        }}
    };
}//