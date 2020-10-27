using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public float upBoundary;
    public GameObject Prefab;
    public GameObject BuffPrefab;
    float Azz;
    
    public float downBoundary;
    public float direction;
    public AudioSource damage;
    
    // Start is called before the first frame update
    void Start()
    {
        damage = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
        Death();
    }

    public void Move()
    {
        transform.position += new Vector3(0.0f, speed *direction *Time.deltaTime, 0.0f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("noticed");
        if (collision.gameObject.tag == "Sword")
        {
            
            Destroy(gameObject);
            Debug.Log("ouch");

           Azz = Random.Range(0, 100);
            if (Azz <= 25)
            {
               
                Instantiate(BuffPrefab, Prefab.transform.position, Prefab.transform.rotation);
            }
            
            damage.Play();

        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            HealthScore.healthval -= 1;
        }
    }
    private void CheckBounds()
    {

       
        if (this.transform.position.y >= upBoundary)
        {
            Debug.Log("swap down");
            direction = -1.0f;
        }

        // check left boundary
        if (this.transform.position.y <= downBoundary)
        {
            Debug.Log("swap up");
            direction = 1.0f;
        }
        
    }

    private void Death()
    {
        if (HealthScore.healthval == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void OnDestroy()
    {
        ScoreScript.scoreval += 10;
       
    }


}
