using UnityEngine;
using UnityEngine.AI;

public class IdleState : BaseState
{
    private readonly NavMeshAgent m_Agent;
    
    public IdleState(NavMeshAgent agent)
    {
        m_Agent = agent;
    }

    public override void OnEnter()
    {
        if (m_Agent)
        {
            Debug.Log("OnEnter IdleState for: " + m_Agent.gameObject.name);
        }
    }
}