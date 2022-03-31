using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTypeProjectile : IBaseType
{

    public void UpdatePos(Transform transform, Vector3 target, float speedModifier)
    {
        Vector3 diff = (target - transform.position);
        Vector3 move = diff.normalized * Time.fixedDeltaTime * speedModifier;
        if(move.magnitude >= diff.magnitude)
        {
            move = diff;
            
        }
        transform.position += move;
    }
}
