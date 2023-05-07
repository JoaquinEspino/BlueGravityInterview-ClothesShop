using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesManager : MonoBehaviour
{
    // Start is called before the first frame update
    public ItemAttributes clothesWorn;
    public List<ItemAttributes> sortedClothesWorn;
    public Animator animator;
    public string animatorPath;
    void Start()
    {
        sortedClothesWorn.Add(clothesWorn);
        sortedClothesWorn.Add(clothesWorn);
        sortedClothesWorn.Add(clothesWorn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddClothes(ItemAttributes item)
    {
        animatorPath = "Player";
        if(item.itemType == "hats")
        {
            sortedClothesWorn[0] = item;
        }
        else if (item.itemType == "pants")
        {
            sortedClothesWorn[1] = item;
        }
        else if (item.itemType == "shirts")
        {
            sortedClothesWorn[2] = item;
        }

        animatorPath = "Animators/Player" + sortedClothesWorn[0].itemTag + sortedClothesWorn[1].itemTag + sortedClothesWorn[2].itemTag;
        Debug.Log(animatorPath);
        animator.runtimeAnimatorController = Resources.Load(animatorPath) as RuntimeAnimatorController;
    }

    void RefreshClothes()
    {
        foreach (ItemAttributes item in sortedClothesWorn)
        {
            animatorPath = "Animators/Player" + sortedClothesWorn[0].itemTag + sortedClothesWorn[1].itemTag + sortedClothesWorn[2].itemTag;
            Debug.Log(animatorPath);
            animator.runtimeAnimatorController = Resources.Load(animatorPath) as RuntimeAnimatorController;
        }
    }

    public void RemoveClothing(ItemAttributes removedItem)
    {
        for(int i = 0; i < 3; i++)
        {
            if (sortedClothesWorn[i].itemTag == removedItem.itemTag)
            {
                sortedClothesWorn[i] = clothesWorn;
            }
        }

        RefreshClothes();
    }


}
