﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scrollViewButtonTemplate : MonoBehaviour
{

    private string Name;
    public Text ButtonText;
    public scrollViewTemplate ScrollView;

    public void SetName(string name)
    {
        Name = name;
        ButtonText.text = name;
    }
}