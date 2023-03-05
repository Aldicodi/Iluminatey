using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextUpdater : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI CoinText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ValueText.text = "Coins: %.2f" + (EndStats.bank).ToString();
        CoinText.SetText("Coins: " + EndStats.bank.ToString("F2"));

    }
}
