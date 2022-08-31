using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestbuttonScprit : MonoBehaviour
{
    public Animator anim;
    public bool changeAnim;

    // Start is called before the first frame update
    void Start()
    {
        changeAnim = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeAnim()
    {
        anim.SetTrigger( changeAnim? "Run" : "Idle" );
        changeAnim = changeAnim? false:true;
    }
}
