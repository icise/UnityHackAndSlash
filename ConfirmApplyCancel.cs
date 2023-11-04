using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmApplyCancel : MonoBehaviour
{
    [SerializeField]
    GameObject confirmApplyMenu;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject backConfirmationButton;
    [SerializeField]
    GameObject confirmApplyObj;
    StatusUI statusUi;
    ConfirmApply confirmApplyCs;
    private void Start()
    {
        statusUi = player.GetComponent<StatusUI>();
        confirmApplyCs = confirmApplyObj.GetComponent<ConfirmApply>();
    }
    public void OnClickConfirmCancel()
    {
        confirmApplyMenu.SetActive(false);
        backConfirmationButton.SetActive(false);
        statusUi.EnableStatusUI();
        confirmApplyCs.BackStatusMenuFalse();
    }
}
