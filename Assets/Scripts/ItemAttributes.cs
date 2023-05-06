using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAttributes : MonoBehaviour
{
    public GameObject thisItem;
    public GameObject coinsManager;
    public GameObject inventoryManager;
    public int sellCost;
    void Start()
    {
        sellCost = 3;
        coinsManager = GameObject.FindWithTag("CoinManager");
        inventoryManager = GameObject.FindWithTag("InventoryManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SellItem()
    {
        coinsManager.GetComponent<CoinsManager>().coinCount += sellCost;
       
        inventoryManager.GetComponent<InventoryManager>().RefreshItems();
        inventoryManager.GetComponent<InventoryManager>().RemoveItem(thisItem);
    }
}
