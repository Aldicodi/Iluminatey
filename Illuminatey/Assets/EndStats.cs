using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndStats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int moneySpent = 0;
        int moneyMade = 0;
        int tasksDone = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bool nighttime = true;
        bool taskComplete = false;
        bool lightOn = false;
        int bank = 0;

        while (nighttime)
        {
           if (taskComplete)
            {
                bank += 1;
            }
           if (lightOn)
            {
                bank -= 1;
            }
        }
        
    }
}
