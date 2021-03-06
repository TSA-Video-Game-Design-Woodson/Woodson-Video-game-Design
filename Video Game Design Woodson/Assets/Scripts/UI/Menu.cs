﻿using System.Collections;
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
    // Start is called before the first frame update
    void Start()
    {
        OpenButton.onClick.AddListener(OpenMenu);
        CloseButton.onClick.AddListener(CloseMenu);
        ShopOpen.onClick.AddListener(OpenShop);
        ShopClose.onClick.AddListener(CloseShop);
    }

    // Update is called once per frame
    void Update()
    {
       // dialogueBox.SetActive(true);
       // dialogueButton.SetActive(true);
    }
    public void OpenShop()
    {
        ShopMenu.SetActive(true);
        dialogueBox.SetActive(false);
        dialogueButton.SetActive(false);
       // menuObject.SetActive(false);
       // buttonOpen.SetActive(false);


    }
    public void CloseShop()
    {
        ShopMenu.SetActive(false);
        dialogueBox.SetActive(true);
        dialogueButton.SetActive(true);
        
        
    }
    public void CloseMenu()
    {
        player.SetActive(true);
        menuObject.SetActive(false);
        buttonOpen.SetActive(true);
        dialogueBox.SetActive(true);
        dialogueButton.SetActive(true);
    }
    public void OpenMenu()
    {
        player.SetActive(false);
        dialogueBox.SetActive(false);
        dialogueButton.SetActive(false);
        menuObject.SetActive(true);
        buttonOpen.SetActive(false);
    }

}
