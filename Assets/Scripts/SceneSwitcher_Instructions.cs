using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher_Instructions : MonoBehaviour
{
    // Start is called before the first frame update

    public void playGame()
    {
        SceneManager.LoadScene("Instructions");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
