using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public List<ShopItem> ShopObjects;
    public Transform panel;
    public ShopItem item1, item2, item3;
    public ShopItem baseItem;
    public Sprite[] hats, shirts, pants;
    void Start()
    {
        InitializeShopItems();
    }


    public void InitializeShopItems()
    {
        item1 = Instantiate(item1, panel);
        item2 = Instantiate(item2, panel);
        item3 = Instantiate(item3, panel);

        item1.chosenSprite = hats[0];
        item2.chosenSprite = shirts[0];
        item3.chosenSprite = pants[0];

        item1.itemName = "Green Hat";
        item2.itemName = "Blue Shirt";
        item3.itemName = "Red Pants";

        item1.itemPrice = 2;
        item2.itemPrice = 4;
        item3.itemPrice = 4;

        item1.productTag = "_GreenHat";
        item2.productTag = "_BlueShirt";
        item3.productTag = "_RedPants";

        item1.productType = "hats";
        item2.productType = "shirts";
        item3.productType = "pants";

        item1.SetAttributes();
        item2.SetAttributes();
        item3.SetAttributes();

        ShopObjects.Add(item1);
        ShopObjects.Add(item2);
        ShopObjects.Add(item3);
    }

    public void AddItem(ItemAttributes item)
    {
        ShopItem tempItem = Instantiate(baseItem, panel);
        tempItem.chosenSprite = item.chosenSprite;
        tempItem.itemName = item.itemName;
        tempItem.itemPrice = item.sellCost * 2;
        tempItem.productTag = item.itemTag;
        tempItem.productType = item.itemType;
        tempItem.SetAttributes();
        ShopObjects.Add(tempItem);
    }
}
