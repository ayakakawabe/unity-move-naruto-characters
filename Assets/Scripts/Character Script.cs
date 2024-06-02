using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("isJump");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("isRunForward", true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("isRunForward", false);
        }
        //AnimatorStateInfo animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        //if (animatorStateInfo.normalizedTime > 10)
        //{

        //    animator.enabled = false;
        //}
    }
}
