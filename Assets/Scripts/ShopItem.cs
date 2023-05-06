using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    // Start is called before the first frame update
    public string itemName;
    public int itemPrice;
    public TextMeshProUGUI itemNameText, itemPriceText;
    public Sprite chosenSprite;
    public Image image;

    public GameObject coinsManager;

    public InventoryManager inventoryManager;
    void Start()
    {
        coinsManager = GameObject.FindWithTag("CoinManager");
        inventoryManager = GameObject.FindWithTag("InventoryManager").GetComponent<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void SetAttributes()
    {
        itemNameText.text = itemName;
        itemPriceText.text = itemPrice.ToString();
        image.sprite = chosenSprite;
    }

    public void BuyItem()
    {
        if (coinsManager.GetComponent<CoinsManager>().coinCount - itemPrice >= 0)
        {
            coinsManager.GetComponent<CoinsManager>().coinCount -= itemPrice;
            inventoryManager.AddNewItem(itemPrice / 2, chosenSprite);
            Destroy(gameObject);
        }
    }


}
