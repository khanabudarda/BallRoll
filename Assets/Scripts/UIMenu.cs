using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public GameObject panel;
    public Text highScr;
    
    public void Start()
    {
        highScr.text = PlayerPrefs.GetFloat("HighScore", 0 ).ToString("0");
    }
    
    public void setings(){
        panel.SetActive(true);
    }
    public void menuM(){
        panel.SetActive(false);
    }
    public void PlayBut(){
        SceneManager.LoadScene("main");
    }
    public void setLevl(int lel){
        PlayerPrefs.SetFloat("Difficulty",lel);
    }
}
