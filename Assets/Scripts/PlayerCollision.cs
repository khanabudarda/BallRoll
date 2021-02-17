using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMov mov;
    void OnCollisionEnter(Collision info){
        if(info.collider.tag == "Obst")
        {
            mov.enabled = false;
            FindObjectOfType<GameManager>().GameEnd();
        }
    }
}
