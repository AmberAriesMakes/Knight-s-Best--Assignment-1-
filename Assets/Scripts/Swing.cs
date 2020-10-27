using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject EnemyPrefab;
    public GameObject Spawn;
    public Transform player;
    public Vector3 swinglocal;
    private GameObject newSwing;
    private GameObject newSpawn;
    public GameObject EnemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        swinglocal = new Vector3(0, 2, 0);
    }

    
   public void SwingWep()
    {
       newSwing= Instantiate(Prefab, Spawn.transform.position, Spawn.transform.rotation);
       Invoke("UnswingWep", 0.5f);
        Debug.Log("Bye");

    }
    public void UnswingWep()
    {
        Destroy(newSwing);
        newSpawn = Instantiate(EnemyPrefab, EnemySpawn.transform.position, EnemySpawn.transform.rotation);
        Instantiate(newSpawn);
    }
}
