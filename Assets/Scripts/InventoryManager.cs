using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform panel;
    public GameObject ItemPrefab;
    public List<GameObject> Items = new List<GameObject>();
    void Start()
    {
        RefreshItems();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveItem(GameObject item)
    {
        Items.Remove(item);
    }

    public void RefreshItems()
    {
        foreach (Transform item in panel)
        {
            Destroy(item.gameObject);
        }

       foreach(var item in Items)
        {
            GameObject obj = Instantiate(ItemPrefab, panel);
        }
    }
}
