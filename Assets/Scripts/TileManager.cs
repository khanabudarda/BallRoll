using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Time;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TileManager : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject panel;
    
    private Transform player;
    private float spawnZ = 50.0f;
    private float tileLength = 50.0f;
    private int noofTiles = 5;
    private float safe = 100.0f;
    private int lastpreIn = 0;
    
    private List<GameObject> activeTiles = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < noofTiles; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z - safe > (spawnZ - noofTiles * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }
    void SpawnTile(int prefabIn = -1)
    {
        //Debug.Log("Spawnning Tile...");
        GameObject go;
        //Vector3 pos = 0.0f,0.0f,spawnZ;
        //go = Instantiate(prefabs[0]) as GameObject;
        //go.transform.SetParent(transform);
        //go.transform.position = Vector3.forward * spawnZ;
        go = Instantiate(prefabs[RandomPrefabIn()],new Vector3(0.0f, 0.0f, spawnZ),Quaternion.identity);
        //Debug.Log(new Vector3(0.0f, 0.0f, spawnZ));
        spawnZ += tileLength; 
        activeTiles.Add(go);
        Debug.Log(activeTiles.Count);
    }
    void DeleteTile()
    {
        Destroy (activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
    
    int RandomPrefabIn(){
        if (prefabs.Length <= 1)
        {
            return 0;
        }
        else {
            int randomIn = lastpreIn;
            while (randomIn == lastpreIn)
            {
                randomIn = Random.Range(0, prefabs.Length);
            }
            lastpreIn = randomIn;
            return randomIn;
        }
    }
    public void BackM(){
        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
    }
    public void Pause(){
        Time.timeScale = 0;
        panel.SetActive(true);
    }
    public void Resume(){
        panel.SetActive(false);
        //yield return new WaitForSeconds(2);
        Time.timeScale = 1;
    }
}
