using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public int coinCount;
    public TextMeshProUGUI tmpShop, tmpUI;
    // Start is called before the first frame update
    void Start()
    {
        coinCount = 10;
    }

    // Update is called once per frame
    void Update()
    {
        tmpUI.text = coinCount.ToString();
        tmpShop.text = coinCount.ToString();
    }
}
