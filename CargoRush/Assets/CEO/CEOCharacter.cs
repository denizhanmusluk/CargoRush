using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CEOCharacter : MonoBehaviour
{
    public event Action following;

    public StandCEO standCeo;
    public float AImoveSpeed;
    public NavMeshAgent navMeshAgent;
    public Animator animator;

    public bool characterStayActive = false;
    public bool isStayHoldActive = false;
    public bool followActive = false;
    public BuyArea targetBuyArea;
    public Transform playerFollowPosTR;

    public GameObject followMePopUp;
    public List<GameObject> popOpForShop = new List<GameObject>();
    public Transform canvasProductTR;

    private void Update()
    {
        following?.Invoke();
        canvasProductTR.rotation = Quaternion.Euler(canvasProductTR.eulerAngles.x, 42.038f, canvasProductTR.eulerAngles.z);

    }

    public void GoToPlayer()
    {
        isStayHoldActive = false;
        followActive = true;
        following = null;
        following += GoToPlayerNear;
    }


    void GoToPlayerNear()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(PlayerController.Instance.ceoPos.position.x , PlayerController.Instance.ceoPos.position.z)) > 0.25f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(PlayerController.Instance.ceoPos.position.x, transform.position.y, PlayerController.Instance.ceoPos.position.z);
            animator.SetBool("walk", true);

       
            navMeshAgent.SetDestination(targetPos);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;

                animator.SetBool("walk", false);
                following = null;
                navMeshAgent.SetDestination(transform.position);
                navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
                ArrivedPlayerNear();
            }
        }
    }
    public  void ArrivedPlayerNear()
    {
        IndicatorManager.Instance.IndicaorDeActive();
        IndicatorManager.Instance.IndicaorActive(targetBuyArea.ceoTargetPosTR);
        IndicatorManager.Instance.indicatorMesh.material.color = Color.yellow;
        followMePopUp.SetActive(true);
        PlayerController.Instance.PlayerRotReset();
        PlayerController.Instance.PlayerControlDeActive();
        GameManager.Instance.ui.acceptButtonGO.SetActive(true);
    }
    public void GoToBuy_Area()
    {
        StartCoroutine(GoToBuyArea());
    }
    IEnumerator GoToBuyArea()
    {

        yield return new WaitForSeconds(0.5f);


        targetBuyArea.gameObject.SetActive(true);
        targetBuyArea.OpenButDeactive();
        followMePopUp.gameObject.SetActive(false);
        PlayerController.Instance.FollowCeo();
        isStayHoldActive = false;
        following = null;
        following += GoToCeoStand;
    }


    void GoToCeoStand()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(targetBuyArea.ceoTargetPosTR.position.x, targetBuyArea.ceoTargetPosTR.position.z)) > 0.25f)
        {
            characterStayActive = false;

            //animator.SetBool("Walk", true);
            Vector3 targetPos = new Vector3(targetBuyArea.ceoTargetPosTR.position.x, transform.position.y, targetBuyArea.ceoTargetPosTR.position.z);
            animator.SetBool("walk", true);

            //transform.position = Vector3.MoveTowards(transform.position, targetPlayer.position, Time.deltaTime * moveSpeed);

            navMeshAgent.SetDestination(targetPos);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
                //StartCoroutine(RotateTarget());
            }
            //animator.SetBool("Walk", false);
            if (!isStayHoldActive)
            {
                followActive = false;
                isStayHoldActive = true;

                animator.SetBool("walk", false);
                following = null;
                navMeshAgent.SetDestination(transform.position);
                navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;

                IndicatorManager.Instance.indicatorMesh.material.color = Color.white;
                IndicatorManager.Instance.IndicaorDeActive();

            }
        }
    }
    public void CeoRotReset()
    {
        StartCoroutine(SetRot());
    }
    IEnumerator SetRot()
    {
        Vector3 firstPos = transform.position;
        Vector3 targetPos = targetBuyArea.ceoTargetPosTR.position;
        Quaternion firstRot = transform.rotation;
        Quaternion targetRot = Quaternion.Euler(0, transform.eulerAngles.y + 180, 0);
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            transform.position = Vector3.Lerp(firstPos, targetPos, counter);
            yield return null;
        }
        popOpForShop[PlayerPrefs.GetInt("ceolevel") - 1].SetActive(true);
        GameManager.Instance.ui.yesButtonGO.SetActive(true);
    }
    public void Go_Exit()
    {
        StartCoroutine(GoExit());
    }
    IEnumerator GoExit()
    {
        yield return new WaitForSeconds(1f);
        //popOpForShop[PlayerPrefs.GetInt("ceolevel") - 1].SetActive(false);
        foreach( var popups in popOpForShop)
        {
            popups.SetActive(false);
        }
        isStayHoldActive = false;
        following = null;
        following += GoToExit;
    }

    public void GoToExit()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(ElectronicsCaseManager.Instance.exit.position.x, ElectronicsCaseManager.Instance.exit.position.z)) > 0.25f)
        {
            characterStayActive = false;

            //animator.SetBool("Walk", true);
            Vector3 targetPos = new Vector3(ElectronicsCaseManager.Instance.exit.position.x, transform.position.y, ElectronicsCaseManager.Instance.exit.position.z);
            animator.SetBool("walk", true);

            //transform.position = Vector3.MoveTowards(transform.position, targetPlayer.position, Time.deltaTime * moveSpeed);

            navMeshAgent.SetDestination(targetPos);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
                //StartCoroutine(RotateTarget());
            }
            //animator.SetBool("Walk", false);
            if (!isStayHoldActive)
            {
                followActive = false;
                isStayHoldActive = true;

                animator.SetBool("walk", false);
                following = null;
                navMeshAgent.SetDestination(transform.position);
                navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
                gameObject.SetActive(false);
            }
        }
    }
}
