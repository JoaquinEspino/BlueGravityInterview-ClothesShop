using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Wearitem : MonoBehaviour
{
    // Start is called before the first frame update
    bool buttonFlipper;
    public ClothesManager clothesManager;
    void Start()
    {
        buttonFlipper = false;
        clothesManager = GameObject.FindWithTag("ClothesManager").GetComponent<ClothesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
            
            gameObject.GetComponent<Image>().color = Color.white;
            
        }
        buttonFlipper = !buttonFlipper;



    }
}
