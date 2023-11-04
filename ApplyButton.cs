using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyButton : MonoBehaviour
{
    [SerializeField]
    GameObject confirmApplyMenuObj;
    [SerializeField]
    GameObject statusUiObj;
    StatusPoint statusPoint;
    public void OnClickApply()
    {
        confirmApplyMenuObj.SetActive(true);
        statusUiObj.SetActive(false);
    }
}
