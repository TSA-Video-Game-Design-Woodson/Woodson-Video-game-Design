using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using UnityEditor;

public class JSONParse : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerStats playerStats;

    public class PlayerStats
    {
        public Player myPlayer;
        public Plane myPlane;
        public PlayerStats(Player myPlayer, Plane myPlane)
        {
            this.myPlayer = myPlayer;
            this.myPlane = myPlane;
        }
       
        
        
    }
    public class Player
    {
        public string[] homework;
        public int Fatigue;
        public Player(string[] homework, int Fatigue)
        {
            this.homework = homework;
            this.Fatigue = Fatigue;
        }
    }
    public class Plane
    {
        public int Drag;
        public int AngularDrag;
        public Plane(int Drag, int AngularDrag)
        {
            this.Drag = Drag;
            this.AngularDrag = AngularDrag;
        }
    }
   
    string path;
    
    // StreamWriter writer;
    void Start()
    {
        path = "Assets/Miscellaneous/PlayerStats.json";


        playerStats = JsonConvert.DeserializeObject<PlayerStats>(readFromFile(path));

    }
    public string readFromFile(string path)
    {
        
        StreamReader reader = new StreamReader(path);
        string returnable = reader.ReadToEnd();
        reader.Close();
        return returnable;
    }
    public void writeToFile(string path, string enter) {

         

        File.WriteAllText(path, enter);
        AssetDatabase.ImportAsset(path);
    }
    // Update is called once per frame
   
    void Update()
    {
        
        
        string thing = JsonConvert.SerializeObject(playerStats);
        //writeToFile(path, thing); //persistent cause why not

    }
}
