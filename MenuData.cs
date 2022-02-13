using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MenuData {

    public int MaxCoinScore;
    public int MaxRubyScore;
    public int MaxBerryScore;

    public MenuData (Menu menu)
    {
        MaxCoinScore = Menu.coinMax;
        MaxBerryScore = Menu.berryMax;
        MaxRubyScore = Menu.rubyMax;
    }

}
