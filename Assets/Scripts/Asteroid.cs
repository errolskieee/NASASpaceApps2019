using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour
{
    void OnTriggerEnter(Collider hit){
        if (hit.CompareTag("Player")){
            SceneManager.LoadScene("LoseScreen");
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
