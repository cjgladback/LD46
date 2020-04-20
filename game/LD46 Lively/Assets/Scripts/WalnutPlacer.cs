using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class WalnutPlacer : MonoBehaviour
{
    
    public float walnutFall;
    void Update()
    {

        
        //NavMeshAgent agent = GetComponent("NavMeshAgent") as NavMeshAgent;

        NavMeshHit closestHit;
        if (NavMesh.SamplePosition(transform.position, out closestHit, 100f, NavMesh.AllAreas))
        {
            Sequence seq = DOTween.Sequence();
            seq.Append(transform.DOMove(closestHit.position, walnutFall));
            
            //transform.position = closestHit.position;
            //agent.enabled = true;
        }
    }

}
