using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pickups : MonoBehaviour
{

    PlayerFlightControl player;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerFlightControl>();    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            player.points += points;
            Destroy(gameObject);
        }
        if (other.CompareTag("Player") && player.points == 500){
            SceneManager.LoadScene("WinScreen");
        }
    }
}
