using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void PlayAgain()
    {
        EndStats.bank = 150;
        SceneManager.LoadScene("House 4");
    }
    
    public void BackToMenu()
    {
        EndStats.bank = 150;
        SceneManager.LoadScene("MainMenu");
    }

}
