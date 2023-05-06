using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemAttributes : MonoBehaviour
{
    public GameObject thisItem;
    public GameObject coinsManager;
    public GameObject inventoryManager;
    public int sellCost;

    public Sprite chosenSprite;
    public Image image;
    public string itemTag;
    void Start()
    {
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
       
        Destroy(gameObject);
    }
    public void SetAttributes()
    {
        image.sprite = chosenSprite;
    }
}
