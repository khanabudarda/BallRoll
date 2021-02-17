using UnityEngine;

public class DragFingerMove : MonoBehaviour
{
    Touch touch;
    float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                transform.position.x + touch.deltaPosition.x * moveSpeed, transform.position.y, transform.position.z);
            }
        }
    }
}
