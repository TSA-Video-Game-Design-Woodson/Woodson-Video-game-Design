using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fatigue : MonoBehaviour
{
    
    public GameObject fatigueBar;
    RectTransform fBar; //fBar is short for fatigueBar
    Image fBarColor;
    float top;
    GameObject reader;
    JSONParse myScript;
    float currentFatigue = 80;
    
    // Start is called before the first frame update
    void Start()
    {
        fBar = fatigueBar.GetComponent(typeof(RectTransform)) as RectTransform;
        fBarColor = fatigueBar.GetComponent<Image>();
       // Debug.Log(fBarColor.color.g);
        reader = GameObject.FindWithTag("Reader");
       // myScript = (JSONParse)reader.GetComponent(typeof(JSONParse));
        //JSONParse script = reader.GetComponents<JSONParse>;
        //currentFatigue = myScript.playerStats.myPlayer.Fatigue;
        

        fBar.anchoredPosition -= new Vector2(0, fBar.anchoredPosition.y + currentFatigue * 1.32f);
        

        
    }
    //-131 is below the screen
    //top is 66
    // Update is called once per frame
    void Update()
    {
      //  myScript.playerStats.myPlayer.Fatigue++;        
        currentFatigue = 80;
        
        Debug.Log(reader.activeInHierarchy);
        fBar.anchoredPosition -= new Vector2(0, fBar.anchoredPosition.y + currentFatigue * 1.32f);
        if(currentFatigue >= 0 && currentFatigue < 25)
        {
            fBarColor.color = new Color(0, 255, 0);
        }else if (currentFatigue >= 25 && currentFatigue < 50)
        {
            fBarColor.color = new Color(240,255, 0);
        }else if (currentFatigue>= 50 && currentFatigue < 75)
        {
            fBarColor.color = new Color(255, 150, 0);
        }
        else if(currentFatigue >= 75 && currentFatigue <= 100)
        {
            fBarColor.color = new Color(255, 0, 0 );
        }



        
        
        

    }
   
}
