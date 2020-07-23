using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateTrigger : MonoBehaviour
{
    public Animator charAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //running
        if(Input.GetKeyDown(KeyCode.Z))
        {
            charAnim.SetTrigger("Running");
        }
        //tpose
        if (Input.GetKeyDown(KeyCode.X))
        {
            charAnim.SetTrigger("idle");
        }
        //running jump
        if (Input.GetKeyDown(KeyCode.C))
        {
            charAnim.SetTrigger("RunningJump");
        }
        //walking
        if (Input.GetKeyDown(KeyCode.D))
        {
            charAnim.SetTrigger("Walk");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            charAnim.SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            charAnim.SetTrigger("LeftTurn");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            charAnim.SetTrigger("RightTurn");
        }
    }
}
