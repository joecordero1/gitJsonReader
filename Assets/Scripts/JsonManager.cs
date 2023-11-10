using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonManager : MonoBehaviour
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

    public PlayersList myPlayerList = new PlayersList();

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
