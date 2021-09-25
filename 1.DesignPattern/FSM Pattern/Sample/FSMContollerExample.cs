﻿using System.Collections;
using System.Collections.Generic;
using MyLibrary.DesignPattern.Sample;
using UnityEngine;

[System.Serializable]
public enum StateType
{
    Idle,
    Run,
    Walk,
    Jump
}

public class FSMContollerExample : MonoBehaviour
{
    [SerializeField] private StateType MotionType;
    [SerializeField] private FSMExampleCharacter characterScript;
    
    private void Update()
    {
        switch (MotionType)
        {
            case StateType.Idle:
                characterScript.ChangeFSM = new FSMExampleCharacter.IdleState();
                break;
            
            case StateType.Run:
                characterScript.ChangeFSM = new FSMExampleCharacter.RunState();
                break;
            
            case StateType.Jump:
                characterScript.ChangeFSM = new FSMExampleCharacter.JumpState();
                break;
            
            case StateType.Walk:
                characterScript.ChangeFSM = new FSMExampleCharacter.WalkState();
                break;
        }
    }
}