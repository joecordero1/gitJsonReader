using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonWritter : MonoBehaviour
{
    public TextAsset TextJson;
    [System.Serializable]
    public class Player
    {
        public string name;
        public string health;
    }

    [System.Serializable]
    public class PlayersList
    {
        public Player[] players;
    }

    public Player myPlayer = new Player();

    public PlayersList myPlayerList = new PlayersList();

    public void writeJson(){
        string strOut = JsonUtility.ToJson(myPlayerList);
    }

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (TextJson != null)
        {
            myPlayerList = JsonUtility.FromJson<PlayersList>(TextJson.text);
        }
        
    }
}
