using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public Transform player;
    public float speed = 10.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public int limitUp;
    public int limitDown;
    public int LimitLeft;
    public int LimitRight;

   

    public Transform circle;
    public Transform outerCircle;
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
             pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            //circle.transform.position = pointA * 1;
            //outerCircle.transform.position = pointA * 1;
            //circle.GetComponent<SpriteRenderer>().enabled = true;
           // outerCircle.GetComponent<SpriteRenderer>().enabled = true;

        }
            if (Input.GetMouseButton(0))
            {
                touchStart = true;
                pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            } else {
                touchStart = false;
            }
        //CheckBounds();
       
    }
    
    

        private void FixedUpdate()
        {
            if (touchStart)
            {
                Vector2 offset = pointB - pointA;
                Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
                moveCharacter(direction * 1);
            circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y);
        }
        else
        {
            
        }
        }
        void moveCharacter(Vector2 direction)
        {
            player.Translate(direction * speed * Time.deltaTime);
        }
  ////  private void CheckBounds()
  //  {


  //      if (player.transform.position.x <= LimitLeft)
  //      {
  //          player.transform.position = new Vector3(LimitLeft, transform.position.y, 0.0f);
  //      }

  //      // check left boundary
  //      if (player.transform.position.x >= LimitRight)
  //      {
  //          player.transform.position = new Vector3(LimitRight, transform.position.y, 0.0f);
  //      }
  //      if (player.transform.position.y >= limitUp)
  //      {
  //          player.transform.position = new Vector3(transform.position.x, limitUp , 0.0f);
  //      }
  //      if (player.transform.position.y <= limitDown)
  //      {
  //          player.transform.position = new Vector3(transform.position.x, limitDown, 0.0f);
  //      }

   // }

    void Swing()
    {
        Instantiate(Prefab, player.transform.position, player.transform.rotation);
    }


}
