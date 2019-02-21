using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueProximity : MonoBehaviour
{
    public GameObject Player;
    public GameObject DialogueText;
    public string name;
    public string[] dialogue;
    public bool active = false;
    private bool anyoneActive = false;
    private GameObject[] speakers;
    
    // Start is called before the first frame update
    void Start()
    {
        //DialogueText.SetActive(false);   
        speakers = GameObject.FindGameObjectsWithTag("Speaker");
    }

    // Update is called once per frame
    void Update()
    {
        int totalActive = 0;
        int totalWorking = 0;
        foreach (GameObject speaker in speakers)
        {
            if (speaker.GetComponent<DialogueProximity>().active)
            {
                anyoneActive = true;
                totalActive++;
            }
            if (speaker.activeInHierarchy)
            {
                totalWorking++;
            }
        }
        if (totalActive == 0)
        {
            anyoneActive = false;

        }
        totalActive = 0;
        Debug.Log(totalWorking);
        if (totalWorking == 0)
        {
            active = false;
        }  
     else if (Vector3.Distance(Player.transform.position, gameObject.transform.position) <= 1.0)
        {
            DialogueText.SetActive(true);
            //DialogueText.GetComponent<PlayerController>().money
            DialogueText.GetComponent<DialogueTrigger>().dialogue.name = name;
            DialogueText.GetComponent<DialogueTrigger>().dialogue.sentences = dialogue;
            active = true;
        }
        else //out of range
        {
            active = false;
            if (!anyoneActive)
            {
                DialogueText.SetActive(false);
            }
            else
            {
                DialogueText.SetActive(true);
            }
            
        }
        totalWorking = 0;
    }
}
