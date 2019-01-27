using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fatigue : MonoBehaviour
{
    public GameObject player;
    public GameObject fatigueBar;
    RectTransform fBar; //fBar is short for fatigueBar
    Image fBarColor;
    float top;
    // Start is called before the first frame update
    void Start()
    {
        fBar = fatigueBar.GetComponent(typeof(RectTransform)) as RectTransform;
        fBarColor = fatigueBar.GetComponent<Image>();
        Debug.Log(fBarColor.color.g);   
        //fBar.Translate(new Vector3(fBar.position.x, 0, fBar.position.z));
        
        
    }
    //-131 is below the screen
    //top is 66
    // Update is called once per frame
    void Update()
    {
        //btw color is using between 0-1 not between 0-255
        //Debug.Log(fBarColor.color.r);
        fBar.Translate(Vector3.left *5f* Time.deltaTime); //go down progressively
        
        
        Vector3 health = fBar.anchoredPosition;
        Debug.Log(health.y % 1.32);
        if (fBarColor.color.r <= 0.98) {
            if (health.y % 1.32 <= 0 && health.y % 1.32 >= -0.1)
            {
                fBarColor.color = new Color(fBarColor.color.r + 0.02f, fBarColor.color.g, fBarColor.color.b, fBarColor.color.a);
            }
        }
        else if(fBarColor.color.g != 0)
        {
            if (health.y % 1.32 <= 0 && health.y % 1.32 >= -0.1)
            {
                fBarColor.color = new Color(fBarColor.color.r, fBarColor.color.g-0.01f, fBarColor.color.b, fBarColor.color.a);
            }
        }
        
        
        

    }
}
