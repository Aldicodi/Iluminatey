using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndScreenTextUpdater : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI EndText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EndText.SetText("Coins Spent: " + EndStats.moneySpent.ToString("F2") + "\n\nCoins Left: " + EndStats.bank.ToString("F2") + "\n\nTasks Completed: (Coming Soon)");
        
    }
}
