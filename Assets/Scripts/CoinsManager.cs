using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public int coinCount;
    public TextMeshProUGUI tmpShop, tmpUI;
    void Start()
    {
        coinCount = 10;
    }

    void Update()
    {
        tmpUI.text = coinCount.ToString();
        tmpShop.text = coinCount.ToString();
    }
}
