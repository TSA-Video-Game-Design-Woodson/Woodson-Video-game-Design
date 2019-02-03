using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buy : MonoBehaviour
{
    public GameObject Player;
    public Button Buy1;
    public Button Buy2;
    public GameObject ErrorWindow;
    public Text MoneyAmount;
    int curMoney;
    public Button errorClose; 
    // Start is called before the first frame update
    void Start()
    {
        Buy1.onClick.AddListener(bought1);
        Buy2.onClick.AddListener(bought2);
        errorClose.onClick.AddListener(closeError);

    }

    void Awake()
    {
        ErrorWindow.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        curMoney =  Player.GetComponent<PlayerController>().money;
        MoneyAmount.text = "Money: " + curMoney;
    }
    void bought1()
    {
        int price = Buy1.GetComponent<Price>().price;  
        if(curMoney - price >= 0)
        {
            Player.GetComponent<PlayerController>().money -= price;
        }
        else
        {
            ErrorWindow.SetActive(true);
        }
    }


    void bought2()
    {
        int price = Buy2.GetComponent<Price>().price;
        if (curMoney - price >= 0)
        {
            Player.GetComponent<PlayerController>().money -= price;
        }
        else
        {
            ErrorWindow.SetActive(true);
        }
    }

    void closeError()
    {
        ErrorWindow.SetActive(false);
    }
}
