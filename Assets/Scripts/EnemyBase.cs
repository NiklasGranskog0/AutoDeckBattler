using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyBase : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator animator;
    
    private StateMachine m_StateMachine;
    private IdleState m_IdleState;
    public bool IsIdle { get; set; }

    private void Awake()
    {
        m_StateMachine = new StateMachine();
        m_IdleState = new IdleState(agent);
        
        m_StateMachine.AddAnyTransition(m_IdleState, new FuncPredicate(CheckIsIdle));
        
        m_StateMachine.SetState(m_IdleState);
    }

    private void Update()
    {
        m_StateMachine.Update();
    }

    private bool CheckIsIdle() => IsIdle;
}