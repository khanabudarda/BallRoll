using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public Transform player;
    public Text text;
    public Text highScr;
    // Update is called once per frame
    void Start()
    {
        highScr.text = PlayerPrefs.GetFloat("HighScore", 0 ).ToString("0");
    }
    void Update()
    {
        float playerPos = player.position.z;
        text.text= playerPos.ToString("0");
        if (playerPos > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore",playerPos);
            highScr.text = playerPos.ToString("0");
        }
    }
}
