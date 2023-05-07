using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform panel;
    public GameObject[] inventory;
    public GameObject ItemPrefab;
    public List<ItemAttributes> Items = new List<ItemAttributes>();
    public ItemAttributes defaultItem;
    public Sprite defaultItemSprite;
    void Start()
    {
        //LoadDefaultItems();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ItemBought()
    {
        
    }

    void LoadDefaultItems()
    {
        ItemAttributes tempItem = defaultItem;
        tempItem = Instantiate(defaultItem, panel);

        tempItem.sellCost = 2;
        tempItem.chosenSprite = defaultItemSprite;

        tempItem.SetAttributes();

        Items.Add(tempItem);


    }

    public void AddNewItem(int sellCost, Sprite chosenSprite, string itemTag, string itemType, string itemName)
    {
        ItemAttributes tempItem = defaultItem;
        tempItem = Instantiate(defaultItem, panel);
        tempItem.sellCost = sellCost;
        tempItem.chosenSprite = chosenSprite;
        tempItem.itemTag = itemTag;
        tempItem.itemType = itemType;
        tempItem.itemName = itemName;
        tempItem.SetAttributes();
        Items.Add(tempItem);

    }
}
