using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingController : MonoBehaviour
{
    [SerializeField]Animator chracterAnimator;
    public void DoIdle()
    {
        chracterAnimator.SetBool("isStarted",true);
    }
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            SwingFront();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            SwingBack();
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            DoIdle();
        }
    }
    public void SwingFront()
    {
        chracterAnimator.SetBool("swingFront",true);
    }
    public void SwingBack()
    {
        chracterAnimator.SetBool("swingFront",false);
    }
}
