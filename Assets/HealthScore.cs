using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScore : MonoBehaviour
{
    public static int healthval = 3;
    Text LIVES;
    // Start is called before the first frame update
    void Start()
    {
        LIVES = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        LIVES.text = "Lives:" + healthval;

        if (healthval <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
