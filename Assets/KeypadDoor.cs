using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadDoor : MonoBehaviour
{
    public Animator animator;
    public void Open()
    {
        animator.SetTrigger("Open");
    }
}
