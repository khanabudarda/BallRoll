using UnityEngine;

public class EndTrig : MonoBehaviour
{
    public GameManager gm;
    
    void OnTriggerEnter(Collider other){
        gm.CompleteLevel();
    }
}
