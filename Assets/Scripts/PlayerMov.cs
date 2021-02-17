using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private CharacterController controller;
    public Rigidbody rb;
    public float speed = 1800;
    float diff;
    // Update is called once per frame
    void Start()
    {
        diff = PlayerPrefs.GetFloat("Difficulty", 28);
        //controller = GetComponent<CharacterController>();
        //rb.AddForce(0,0,900 * Time.deltaTime);
    }
    void FixedUpdate()
    {
        if(rb.velocity.z < diff){
        rb.AddForce(0,0,1600 * Time.deltaTime );}
        Debug.Log(rb.velocity.z);
        //rb.velocity =new  Vector3(0,0,900 * Time.deltaTime);
        //controller.Move ((Vector3.forward * speed )* Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(50*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-50*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().GameEnd();
        }
        
        if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                transform.position.x + touch.deltaPosition.x * 0.01f, transform.position.y, transform.position.z);
            }
        }
    }
}
