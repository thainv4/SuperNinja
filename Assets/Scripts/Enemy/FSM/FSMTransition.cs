using System;
using UnityEngine;

[Serializable]
public class FSMTransition
{
    public FSMDecision Decision;
    public string TrueState;
    public string FalseState;
}
