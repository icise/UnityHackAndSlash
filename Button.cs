using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField]
    private string _type;
    [SerializeField]
    GameObject backStatusMenuObj;
    BackStatusMenu backStatusMenuCs;
    public string type
    {
        get { return _type; }
    }
    private StatusPoint statusPoint;
    // Start is called before the first frame update
    void Start()
    {
        statusPoint = GameObject.Find("Player").GetComponent<StatusPoint>();
        backStatusMenuCs = backStatusMenuObj.GetComponent<BackStatusMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        backStatusMenuCs.ConfirmApplyFalse();
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                statusPoint.StatusSelect(type, 5);
            }
            else
            {
                statusPoint.StatusSelect(type, 1);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                statusPoint.StatusSelect(type, -5);
            }
            else
            {
                statusPoint.StatusSelect(type, -1);
            }
        }
    }
}
