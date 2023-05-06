using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUIManager : MonoBehaviour
{
    public GameObject shopUI;
    public ShopDialogueManager shopDialogueManager;
    void Start()
    {
        
    }

    void Update()
    {
        EnterUIPanel();
    }

    void EnterUIPanel()
    {
        if (shopDialogueManager.GetComponent<ShopDialogueManager>().inUIEvent)
        {
            shopUI.SetActive(true);
        }
    }
    public void ExitUIPanel()
    {
        shopUI.SetActive(false);
        shopDialogueManager.GetComponent<ShopDialogueManager>().exitDialogue.SetActive(true);
        shopDialogueManager.GetComponent<ShopDialogueManager>().inUIEvent = false;
    }
}
