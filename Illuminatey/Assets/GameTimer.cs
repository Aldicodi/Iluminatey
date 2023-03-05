using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClock : MonoBehaviour
{

    public static float gameTime = 60;
    public float electricityCost = 1;
    private float timer = gameTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > 0)
        {
            timer -= Time.deltaTime;
            EndStats.bank -= Time.deltaTime * electricityCost * EndStats.lightsOn;
            EndStats.moneySpent += Time.deltaTime * electricityCost * EndStats.lightsOn;

        } 
        else
        {
            ResetTimer();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("EndMenu");
        }

        if (EndStats.bank <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("EndMenu");
        }
    }

    public void ResetTimer()
    {
        timer = gameTime;
    }
}
