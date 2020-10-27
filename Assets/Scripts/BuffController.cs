using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffController : MonoBehaviour
{
    public AudioSource buff;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    buff = GetComponent<AudioSource>();
        }


    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Pickup");
        if (collision.gameObject.tag == "Player")
        {
            buff.Play();
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        ScoreScript.scoreval += 50;
    }
}
