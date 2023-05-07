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
    public string itemTag, itemType;

    public ClothesManager clothesManager;
    public ShopInventory shopInventory;
    public string itemName;
    void Start()
    {
        coinsManager = GameObject.FindWithTag("CoinManager");
        inventoryManager = GameObject.FindWithTag("InventoryManager");
        clothesManager = GameObject.FindWithTag("ClothesManager").GetComponent<ClothesManager>();
        shopInventory = GameObject.FindWithTag("ShopInventory").GetComponent<ShopInventory>();
    }


    public void SellItem()
    {
        coinsManager.GetComponent<CoinsManager>().coinCount += sellCost;
        clothesManager.RemoveClothing(gameObject.GetComponent<ItemAttributes>());
        shopInventory.AddItem(gameObject.GetComponent<ItemAttributes>());
        Destroy(gameObject);
    }
    public void SetAttributes()
    {
        image.sprite = chosenSprite;
    }
}
