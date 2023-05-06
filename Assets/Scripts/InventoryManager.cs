using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] ItemList;
    public Transform panel;
    void Start()
    {
        foreach (GameObject obj in ItemList)
        {
            Instantiate(obj, panel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
