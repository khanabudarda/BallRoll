using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameEndDo = false;
    
    public GameObject gmo;
    public GameObject playagain;
    
    public void CompleteLevel()
    {
        Debug.Log("Winner!!!");
        gmo.SetActive(true);
    }
    public void GameEnd(){
        if (gameEndDo == false){gameEndDo = true;
        Debug.Log("Game Over");
        Invoke("Again", 0.5f);}
    }
    public void Restart(){
        playagain.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Again(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 0;
        playagain.SetActive(true);
    }
}
