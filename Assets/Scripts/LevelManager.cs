using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    PlayerFlightControl player;
    public Text countText;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerFlightControl>();  
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = ("Earned: $ " + player.points);
    }
}
