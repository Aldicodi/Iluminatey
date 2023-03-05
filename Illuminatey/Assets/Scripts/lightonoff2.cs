using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightonoff2 : MonoBehaviour
{

    public GameObject txtToDisplay;             //display the UI text

    private bool PlayerInZone;                  //check if the player is in trigger
    private bool on = true;

    public GameObject lightorobj1;
    public GameObject lightorobj2;

    private void Start()
    {

        PlayerInZone = false;                   //player not in zone       
        txtToDisplay.SetActive(false);
    }

    private void Update()
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.E))           //if in zone and press E key
        {
            lightorobj1.SetActive(!lightorobj1.activeSelf);
            lightorobj2.SetActive(!lightorobj2.activeSelf);

            if (on)
            {
                on = false;
                EndStats.lightsOn -= 2;
            }
            else
            {
                on = true;
                EndStats.lightsOn += 2;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
    }


    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }
}