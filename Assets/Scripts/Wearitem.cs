using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Wearitem : MonoBehaviour
{
    // toggles the equip and unequip clothes
    bool buttonFlipper;
    public ClothesManager clothesManager;
    void Start()
    {
        buttonFlipper = false;
        clothesManager = GameObject.FindWithTag("ClothesManager").GetComponent<ClothesManager>();
    }

    public void WearItem()
    {
        if(!buttonFlipper)
        {
;           clothesManager.AddClothes(gameObject.GetComponent<ItemAttributes>());
            gameObject.GetComponent<Image>().color = Color.gray;
            
        }
        if(buttonFlipper)
        {
            clothesManager.RemoveClothing(gameObject.GetComponent<ItemAttributes>());
            gameObject.GetComponent<Image>().color = Color.white;
            
        }
        buttonFlipper = !buttonFlipper;



    }
}
