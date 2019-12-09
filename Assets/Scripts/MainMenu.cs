using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start(){
        //Cursor.visible = true;
        Screen.lockCursor = false;
    }

    public void Play() {
        SceneManager.LoadScene("Game");
    }

    public void Mission(){
        SceneManager.LoadScene("MissionScreen");
    }

    public void Menu() {
        SceneManager.LoadScene("Interface");
    }

    public void Quit() {
        Application.Quit();
    }
}
