using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Wearitem : MonoBehaviour
{
    public SpriteRenderer hats, shirts, pants, scarfs;
    // Start is called before the first frame update
    public List<SpriteRenderer> clothesHolder;
    bool buttonFlipper;
    void Start()
    {
        hats = GameObject.FindWithTag("Hats").GetComponent<SpriteRenderer>();
        shirts = GameObject.FindWithTag("Shirts").GetComponent<SpriteRenderer>();
        pants = GameObject.FindWithTag("Pants").GetComponent<SpriteRenderer>();
        scarfs = GameObject.FindWithTag("Scarfs").GetComponent<SpriteRenderer>();
        buttonFlipper = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WearItem()
    {
        if(!buttonFlipper)
        {
            if (gameObject.GetComponent<ItemAttributes>().itemTag == "hats")
            {
                clothesHolder.Add(hats);
            }
            else if (gameObject.GetComponent<ItemAttributes>().itemTag == "shirts")
            {
                clothesHolder.Add(shirts);
            }
            else if (gameObject.GetComponent<ItemAttributes>().itemTag == "pants")
            {
                clothesHolder.Add(pants);
            }
            else if (gameObject.GetComponent<ItemAttributes>().itemTag == "scarfs")
            {
                clothesHolder.Add(scarfs);
            }

            clothesHolder[0].sprite = gameObject.GetComponent<ItemAttributes>().chosenSprite;
            gameObject.GetComponent<Image>().color = Color.gray;
            
        }
        if(buttonFlipper)
        {
            clothesHolder[0].sprite = null;

            gameObject.GetComponent<Image>().color = Color.white;
            
        }
        buttonFlipper = !buttonFlipper;



    }
}
