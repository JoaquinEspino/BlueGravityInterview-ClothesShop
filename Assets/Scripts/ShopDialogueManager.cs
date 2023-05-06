using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopDialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool onTriggerTile;

    public GameObject welcomeDialogue;
    public bool inDialogueEvent;
    void Start()
    {
        onTriggerTile = false;
        inDialogueEvent = false;
    }

    // Update is called once per frame
    void Update()
    {
        WelcomeDialogue();
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
        }
    }


    void WelcomeDialogue()
    {
        if(Input.GetKeyDown(KeyCode.Space) && onTriggerTile)
        {
            welcomeDialogue.SetActive(true);
            inDialogueEvent = true;
        }

        //temporary for testing
        if(Input.GetKeyDown(KeyCode.Q) && onTriggerTile)
        {
            welcomeDialogue.SetActive(false);
            inDialogueEvent = false;
        }
    }
}
