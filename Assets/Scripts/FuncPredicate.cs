using System;
using Assets.Scripts.Framework.StateMachine;

internal class FuncPredicate : IPredicate
{
    private readonly Func<bool> m_Predicate;
    
    public FuncPredicate(Func<bool> func)
    {
        m_Predicate = func;
    }
    
    public bool Evaluate() => m_Predicate.Invoke();
}