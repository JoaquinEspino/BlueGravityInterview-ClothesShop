using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public List<ShopItem> ShopObjects;
    public Transform panel;
    public ShopItem item1, item2, item3, item4;
    public Sprite[] hats, shirts, pants, scarfs;
    void Start()
    {
        InitializeShopItems();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitializeShopItems()
    {
        item1 = Instantiate(item1, panel);
        item2 = Instantiate(item2, panel);
        item3 = Instantiate(item3, panel);
        item4 = Instantiate(item4, panel);

        item1.chosenSprite = hats[0];
        item2.chosenSprite = shirts[0];
        item3.chosenSprite = pants[0];
        item4.chosenSprite = scarfs[0];

        item1.itemName = "Green Hat";
        item2.itemName = "Blue Shirt";
        item3.itemName = "Red Pants";
        item4.itemName = "Pink Scarf";

        item1.itemPrice = 2;
        item2.itemPrice = 4;
        item3.itemPrice = 4;
        item4.itemPrice = 2;

        item1.SetAttributes();
        item2.SetAttributes();
        item3.SetAttributes();
        item4.SetAttributes();

        ShopObjects.Add(item1);
        ShopObjects.Add(item2);
        ShopObjects.Add(item3);
        ShopObjects.Add(item4);
    }
}
