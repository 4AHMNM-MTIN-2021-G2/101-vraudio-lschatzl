﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_AnimateDoor : MonoBehaviour
{

    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void StartDoorAnimationOpen()
    {
        myAnimator.SetBool("openDoor",true);
    }
}