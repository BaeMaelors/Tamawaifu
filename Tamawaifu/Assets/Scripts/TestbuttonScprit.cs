using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestbuttonScprit : MonoBehaviour
{
    public Animator anim;
    public bool changeAnim;
    public float hold;
    public bool holdCheck;
    // Start is called before the first frame update
    void Start()
    {
        changeAnim = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (holdCheck)
        {
            hold += Time.deltaTime;
        }
    }

    public void ChangeAnim()
    {
        anim.SetTrigger( changeAnim? "Run" : "Idle" );
        changeAnim = changeAnim? false:true;
    }

    public void ButtonHold()
    {
        holdCheck = true;
        hold = 0;
    }

    public void ButtonRelease()
    {
        holdCheck = !holdCheck;

        Debug.Log("Hold time: " + hold);
    }

    private IEnumerator HoldCount()
    {
        while (holdCheck)
        {
            hold += Time.deltaTime;
        }
        yield return new WaitForEndOfFrame();
    }
}
