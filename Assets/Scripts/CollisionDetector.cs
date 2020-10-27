using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "swing1")
        {
            Destroy(gameObject);
            Debug.Log("ouch");
        }
    }
}
