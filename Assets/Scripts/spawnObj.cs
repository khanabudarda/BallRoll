using UnityEngine;

public class spawnObj : MonoBehaviour
{
    public GameObject[] objs;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, objs.Length);
        Instantiate(objs[rand], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
