using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class AIMoving : MonoBehaviour
{
    public delegate void MyAction(Transform posTR);

    public event MyAction following;
    public event MyAction followingCasePos;
    public event MyAction workerFollowing;


    public event Action targetArrivedBehaviour;

    public NavMeshAgent navMeshAgent;
    public Animator animator;
    public float AImoveSpeed;

    private void Start()
    {
        navMeshAgent.speed = AImoveSpeed;
    }
    public void BehaviourInit(Action fnct)
    {
        targetArrivedBehaviour = null;
        targetArrivedBehaviour += fnct;
    }
    public void GoTargetStart(Transform targetPosTR)
    {
        following = null;
        following += (posTR) => GoToTarget(targetPosTR);
    }
    public void GoToTarget(Transform targetPosTR)
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(targetPosTR.position.x, targetPosTR.position.z)) > 0.35f)
        {
            Vector3 targetPos = new Vector3(targetPosTR.position.x, transform.position.y, targetPosTR.position.z);
            if (animator != null)
            {
                animator.SetBool("walk", true);
            }
            navMeshAgent.SetDestination(targetPos);
        }
        else
        {
            if (animator != null)
            {
                animator.SetBool("walk", false);
            }
            following = null;
            targetArrivedBehaviour?.Invoke();
            //targetArrivedBehaviour = null;

        }
    }
    public void DirektGoTarget(Transform targetPosTR)
    {
        followingCasePos = null;
        followingCasePos += (posTR) => DirektGoToTarget(targetPosTR);
    }
    public void DirektGoToTarget(Transform targetPosTR)
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(targetPosTR.position.x, targetPosTR.position.z)) > 0.35f)
        {
            Vector3 targetPos = new Vector3(targetPosTR.position.x, transform.position.y, targetPosTR.position.z);
            if (animator != null)
            {
                animator.SetBool("walk", true);
            }
            navMeshAgent.SetDestination(targetPos);
        }
        else
        {
            if (animator != null)
            {
                animator.SetBool("walk", false);
            }
            followingCasePos = null;
        }
    }

    public void GoFollowingStart(Transform targetPosTR)
    {
        if (animator != null)
        {
            animator.SetBool("walk", true);
        }
        workerFollowing = null;
        workerFollowing += (posTR) => GoToFollowing(targetPosTR);
    }
    public void GoToFollowing(Transform targetPosTR)
    {
        Vector3 targetPos = new Vector3(targetPosTR.position.x, transform.position.y, targetPosTR.position.z);
 
        navMeshAgent.SetDestination(targetPos);
    }

    //public void FollowPlayerStart(Transform targetPosTR)
    //{
    //    following = null;
    //    following += (posTR) => FollowToPlayer(targetPosTR);
    //}

    //public void FollowToPlayer(Transform targetPosTR)
    //{
    //    if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(targetPosTR.position.x, targetPosTR.position.z)) > 0.2f)
    //    {
    //        Vector3 targetPos = new Vector3(targetPosTR.position.x, transform.position.y, targetPosTR.position.z);
    //        animator.SetBool("walk", true);
    //        navMeshAgent.SetDestination(targetPos);
    //    }
    //    else
    //    {
    //        navMeshAgent.SetDestination(transform.position);

    //        animator.SetBool("walk", false);

    //    }
    //}
    private void Update()
    {
        following?.Invoke(transform);
        followingCasePos?.Invoke(transform);
        workerFollowing?.Invoke(transform);
    }

    public void WorkerFollowStop()
    {
        workerFollowing = null;
    }
}