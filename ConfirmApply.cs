using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmApply : MonoBehaviour
{
    [SerializeField]
    GameObject confirmApplyMenu;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject backStatusMenuObj;
    [SerializeField]
    GameObject backConfirmationButton;
    StatusPoint statusPoint;
    StatusUI statusUi;
    BackStatusMenu backStatusMenuCs;
    private bool backStatusMenu = true;
    private void Start()
    {
        statusPoint = player.GetComponent<StatusPoint>();
        statusUi = player.GetComponent<StatusUI>();
        backStatusMenuCs = backStatusMenuObj.GetComponent<BackStatusMenu>();
    }
    public void OnClickConfirmApply()
    {
        if (backStatusMenu == false)
        {
            statusPoint.ReflectionStatus();
            confirmApplyMenu.SetActive(false);
            backConfirmationButton.SetActive(false);
            statusUi.EnableStatusUI();
            backStatusMenuCs.ConfirmApplySwitch();
            Debug.Log("Apply");
        }
        else
        {
            statusPoint.ReflectionStatus();
            confirmApplyMenu.SetActive(false);
            backConfirmationButton.SetActive(false);
            statusUi.DisableStatusUI();
            backStatusMenuCs.ConfirmApplySwitch();
            Debug.Log("back");
        }
    }
    public void BackStatusMenuSwitch()
    {
        backStatusMenu = !backStatusMenu;
        //Debug.Log(backStatusMenu);
    }
    public void BackStatusMenuFalse()
    {
        backStatusMenu = false;
    }
}
