using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int money = 1000;
    public GameObject shopTrigger;
    public GameObject openShop;
    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 shopPos = shopTrigger.transform.position;
        if (Vector3.Distance(shopPos, gameObject.transform.position) <= 1.0) //When the distance between the player and the thing that triggers the button is less than one make it active and make it show on the screen
        {
            openShop.SetActive(true);

        }
        else if (openShop.activeInHierarchy) 
        {
            openShop.SetActive(false);
        }
    }
}
