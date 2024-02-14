
using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;

[Serializable]
public class FSMState 
{
    public string ID;
    public FSMAction[] Actions;
    public FSMTransition[] Transitions;

    public void UpdateState(EnemyBrain enemyBrain)
    {
        ExecuteActions();
        ExecuteTransitions(enemyBrain);
    }

    private void ExecuteTransitions(EnemyBrain enemyBrain)
    {
        if (Transitions == null || Transitions.Length <= 0) return;
        foreach (var transition in Transitions)
        {
            bool value = transition.Decision.Decide();
            if (value)
            {
                enemyBrain.ChangeState(transition.TrueState);
            }
            else
            {
                enemyBrain.ChangeState(transition.FalseState);
            }
        }
    }

    private void ExecuteActions()
    {
        for(int i=0;i<Actions.Length; i++)
        {
            Actions[i].Act();
        }
    }
}
