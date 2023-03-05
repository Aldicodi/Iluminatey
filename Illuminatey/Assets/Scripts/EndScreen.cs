using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("House 4");
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
