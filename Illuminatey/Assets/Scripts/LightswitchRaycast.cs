using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightswitchRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 50;
    private LightswitchController interactiveObj;

    [SerializeField] private Image crosshair;

    public LayerMask whatIsSwitch;

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Ray switchRay = new Ray(transform.position, fwd);

        if (Physics.Raycast(switchRay, out hit, rayLength) && Input.GetKeyDown(KeyCode.Mouse0) && hit.collider.tag == "Switch")
        {
            Debug.Log("found");
            CrosshairChange(true);
            interactiveObj.InteractSwitch();
        }
        else
        {
            ClearInteraction();
        }
        
        
    }

    private void ClearInteraction()
    {
        if(interactiveObj != null)
        {
            CrosshairChange(false);
            interactiveObj = null;
        }
    }

    void CrosshairChange(bool on)
    {
        if (on)
        {
            crosshair.color = Color.gray;
        }
        else
        {
            crosshair.color = Color.white;
        }
    }
}
