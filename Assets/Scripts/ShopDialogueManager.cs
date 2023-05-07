using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopDialogueManager : MonoBehaviour
{
    public bool onTriggerTile;

    public GameObject welcomeDialogue, exitDialogue;
    public bool inDialogueEvent;
    public bool inUIEvent;
    public int noOfWelcomeDialogue = 1;
    public int welcomeDialogueIndex = 0;
    void Start()
    {
        onTriggerTile = false;
        inDialogueEvent = false;
        inUIEvent = false;
    }

    void Update()
    {
        WelcomeDialogue();
        ThankYouDialogue();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onTriggerTile = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onTriggerTile = false;
            welcomeDialogueIndex = 0;
        }
    }


    void WelcomeDialogue()
    {
        if(Input.GetKeyDown(KeyCode.Space) && onTriggerTile )
        {
            if(welcomeDialogueIndex == 0)
            {
                welcomeDialogue.SetActive(true);
                inDialogueEvent = true;
            }
            else if(welcomeDialogueIndex == 1)
            {
                welcomeDialogue.SetActive(false);
                inUIEvent = true;
            }
            welcomeDialogueIndex++;
        }
        
    }

    void ThankYouDialogue()
    {
        if(exitDialogue.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.Space) && onTriggerTile)
            {
                exitDialogue.SetActive(false);
                inDialogueEvent = false;
                welcomeDialogueIndex = 0;
            }
        }
    }
}
