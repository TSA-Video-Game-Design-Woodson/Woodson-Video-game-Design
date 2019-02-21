using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menuObject;
    public GameObject buttonOpen;
    public GameObject buttonClose;
    public GameObject dialogueButton;
    public GameObject dialogueBox;
    public Button OpenButton;
    public Button CloseButton;
    public Button ShopOpen;
    public GameObject ShopMenu;
    public Button ShopClose;
    public GameObject player;
    GameObject[] speakers;
    // Start is called before the first frame update
    void Start()
    {
        OpenButton.onClick.AddListener(OpenMenu);
        CloseButton.onClick.AddListener(CloseMenu);
        ShopOpen.onClick.AddListener(OpenShop);
        ShopClose.onClick.AddListener(CloseShop);
        speakers = GameObject.FindGameObjectsWithTag("Speaker");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(speakers.Length);
       // dialogueBox.SetActive(true);
       // dialogueButton.SetActive(true);
    }
    public void OpenShop()
    {
        ShopMenu.SetActive(true);
       //   dialogueBox.SetActive(false);
        dialogueButton.SetActive(false);
        // menuObject.SetActive(false);
        // buttonOpen.SetActive(false);
        closeAllDialogue();

    }
    public void CloseShop()
    {
        ShopMenu.SetActive(false);
        //dialogueBox.SetActive(true);
        // dialogueButton.SetActive(true);
        openAllDialogue();

    }
    public void CloseMenu()
    {
        player.SetActive(true);
        menuObject.SetActive(false);
        buttonOpen.SetActive(true);
      //  dialogueBox.SetActive(true);
        //dialogueButton.SetActive(true);
        openAllDialogue();
    }
    public void OpenMenu()
    {
        player.SetActive(false);
       // dialogueBox.SetActive(false);
        
        menuObject.SetActive(true);
        buttonOpen.SetActive(false);
        closeAllDialogue();
        dialogueButton.SetActive(false);
    }
    public void closeAllDialogue()
    {
        
        foreach (GameObject speaker in speakers)
        {
            speaker.GetComponent<DialogueProximity>().enabled = false;
            speaker.GetComponent<DialogueProximity>().active = false;
            speaker.SetActive(false);
        }
    }
    public void openAllDialogue()
    {
        
        foreach (GameObject speaker in speakers)
        {
            speaker.GetComponent<DialogueProximity>().enabled = true;
            speaker.SetActive(true);
        }
    }

}
