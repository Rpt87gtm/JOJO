using System.Collections;
using System.Collections.Generic;
using UnityEngine;




abstract public class Enemy : Entity
{
    public enum SeverityMob
    {
        Light,
        Heavy
    }

    public enum TypeMovement
    {
        Stand,
        Walking,
        Fly
    }

    public enum TypeAttack
    {
        Melee,
        Range
    }

    [SerializeField] public SeverityMob TypeOfSeverity;
    [SerializeField] public TypeAttack TypeOfAttack;
    [SerializeField] public TypeMovement TypeOfMove;


    abstract public void Move();
}
