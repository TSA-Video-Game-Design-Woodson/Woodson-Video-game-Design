using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class MinigameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject Obj1;
    public GameObject Obj2;
    public GameObject Obj3;
    public GameObject Obj4;
    public int fatigue; //fatigue will be between 1 and 100 with 1 being the highest
    // Start is called before the first frame update
    public int TPS = 1;
    public float prev = 0;
    void Start()
    {
        Obj1.SetActive(false);
        Obj2.SetActive(false);
        Obj3.SetActive(false);
        Obj4.SetActive(false);
        //TPS = 0.5f + 0.005f * fatigue;
        //StartCoroutine(LoadYourAsyncScene());

    }

    // Update is called once per frame
    void Update()
    {

        if (fatigue < 20)
        {
            TPS = 1;
        }
        else if (fatigue >= 20 && fatigue < 40)
        {
            TPS = 2;
        }
        else if (fatigue >= 40 && fatigue < 60)
        {
            TPS = 3;
        }
        else if (fatigue >= 60 && fatigue < 80)
        {
            TPS = 4;
        }
        else if (fatigue >= 80)
        {
            TPS = 5;
        }
        
        bool okay = false;
        //Debug.Log(TPS);
        float time = Time.time;
        int trueTime = (int)time;
        if (trueTime == prev + TPS)
        {
            prev+=TPS;
            okay = true;
        }
        //TPS can range from 1-5;
        


        
        if (okay) 
        {
            double choice = Random.value * 4;
            //Debug.Log(choice);
            if (choice < 1)
            {
                GameObject newObj1 = GameObject.Instantiate(Obj1);
                newObj1.SetActive(true);
                newObj1.transform.Translate(-Vector3.up * 2f * Time.deltaTime);
                //send Obj1
                // Debug.Log(newObj1.transform.position.y);
            }
            else if (choice >= 1 && choice < 2)
            {
                //send Obj2
            }
            else if (choice >= 2 && choice < 3)
            {
                //send Obj3
            }
            else if (choice >= 3)
            {
                //send Obj4
            }

        }
        okay = false;

    }

}
