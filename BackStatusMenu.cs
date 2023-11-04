using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackStatusMenu : MonoBehaviour
{
    [SerializeField]
    GameObject confirmApplyMenu;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject confirmApplyButton;
    [SerializeField]
    GameObject backConfirmationButton;
    StatusUI statusUi;
    ConfirmApply confirmApplyCs;
    private bool confirmApply = false;
    void Start()
    {
        statusUi = player.GetComponent<StatusUI>();
        confirmApplyCs = confirmApplyButton.GetComponent<ConfirmApply>();
    }
    public void OnClickStatusUiBack()
    {
        if(confirmApply == false)
        {
            confirmApplyMenu.SetActive(true);
            statusUi.DisableStatusUI();
            confirmApplyCs.BackStatusMenuSwitch();
            backConfirmationButton.SetActive(true);
        }
        else
        {
            confirmApplyMenu.SetActive(false);
            backConfirmationButton.SetActive(false);
            statusUi.DisableStatusUI();
        }
    }
    public void ConfirmApplySwitch()
    {
        confirmApply = !confirmApply;
    }
    public void ConfirmApplyFalse()
    {
        confirmApply = false;
    }
    private void Update()
    {
        Debug.Log(confirmApply);
    }
}
