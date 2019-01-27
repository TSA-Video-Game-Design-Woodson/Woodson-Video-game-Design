using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menuObject;
    public GameObject buttonOpen;
    public GameObject buttonClose;
    public Button OpenButton;
    public Button CloseButton;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        OpenButton.onClick.AddListener(OpenMenu);
        CloseButton.onClick.AddListener(CloseMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseMenu()
    {
        player.SetActive(true);
        menuObject.SetActive(false);
        buttonOpen.SetActive(true);
    }
    public void OpenMenu()
    {
        player.SetActive(false);
        menuObject.SetActive(true);
        buttonOpen.SetActive(false);
    }
}
