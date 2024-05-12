using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] Animator animator;
    Rigidbody rigidbody;
    [Range(0, 50)] [SerializeField] public float followSpeed, walkSpeed, rotSpeed;
    [HideInInspector] public AudioSource audioSource;
    bool humanRunActive;
    bool firstHitActive = true;
    int[] rotSerchDirect;
    int rotIndex;
    int rotateDirect = 0;

    public float humanRotation;
    float moveSpeed;

    public enum States { searching, following, stopping }
    public States currentBehaviour;

    public bool jumpActive = true;
    [SerializeField] GameObject waterParticleGO;
    public void FishMoveStart()
    {
        StartCoroutine(JumpSelect());
    }
    IEnumerator JumpSelect()
    {
        float timeSelect = Random.Range(1f, 10f);
        yield return new WaitForSeconds(timeSelect);
        if (jumpActive)
        {
            walkSpeed *= 4f;
            animator.SetTrigger("jump");
            yield return new WaitForSeconds(0.75f);
            waterParticleGO.SetActive(true);
            yield return new WaitForSeconds(0.25f);
            walkSpeed /= 4f;
        }
    }
    public Transform targetCharacter;
    void Start()
    {
        humanRotation = Random.Range(-70, 70f);
        moveSpeed = walkSpeed;
        currentBehaviour = States.stopping;

        //draw();

        rotSerchDirect = new int[2];
        rotSerchDirect[0] = -1;
        rotSerchDirect[1] = 1;

        humanRunActive = true;

        //animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody>();
    }

    public void EmptyBottom()
    {
        currentBehaviour = States.stopping;

        StartCoroutine(Death());
    }
    IEnumerator Death()
    {
        float waitTime = Random.Range(0f, 1f);
        yield return new WaitForSeconds(waitTime);
        animator.SetTrigger("flutter");

        yield return new WaitForSeconds(5f);
        FishManager.Instance._fishList.Remove(this);

        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

        switch (currentBehaviour)
        {
            case States.searching:
                {
                    searchHuman();
                    Move();

                    //humanVision();
                }
                break;
            case States.following:
                {
                    targetMove();
                }
                break;

            case States.stopping:
                break;
        }


        //lineRenderer.startWidth = 0.1f;
        //lineRenderer.endWidth = 3f;


        //lineRenderer.SetPosition(0, vision.transform.position + new Vector3(0, 0, 0));
        //lineRenderer.SetPosition(1, vision.transform.position + transform.forward * 1.5f);
        //FindVisibleTargets();

    }
    private void targetMove()
    {
        animator.speed = 20;
        transform.LookAt(targetCharacter);
        float speed = 10f;
        if(Vector3.Distance(transform.position , targetCharacter.position) < 2f)
        {
            //currentBehaviour = States.searching;
            targetCharacter.GetComponent<Rigidbody>().AddForce((transform.position - targetCharacter.position).normalized * 2000);
            targetCharacter.GetComponent<Rigidbody>().AddForce(-Vector3.up * 1000);
            animator.speed = 10;
            speed = 3f;
        }
        transform.position = Vector3.MoveTowards(transform.position, targetCharacter.position, speed * Time.deltaTime);

    }
    bool turnActive = true;
    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.transform.tag == "wall" || collision.transform.tag == "shark")
    //    {
    //        if (turnActive)
    //        {
    //            turnActive = false;
    //            humanRotation += 180;
    //            StartCoroutine(TurnerActivator());
    //        }
    //    }
    //}
    IEnumerator TurnerActivator()
    {
        yield return new WaitForSeconds(2f);
        turnActive = true;
    }
    //private void mouseEscaping()
    //{
    //    animator.SetBool("follow", true);
    //    moveSpeed = followSpeed;

    //    if (Vector3.Distance(hamster.transform.position, transform.position) < 1f)
    //    {
    //        //currentBehaviour = States.caught;
    //        //moveSpeed = 0;
    //    }
    //    Vector3 relativeVector = transform.InverseTransformPoint(hamster.position);
    //    relativeVector /= relativeVector.magnitude;
    //    float newSteer = (-relativeVector.x / relativeVector.magnitude) * 20;
    //    transform.Rotate(0, newSteer * Time.deltaTime * 50, 0);
    //}
    float rotDir = 0;
    public void searchHuman()
    {
        //animator.SetBool("follow", false);
        moveSpeed = walkSpeed;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(4, 0, 2), out hit, 2f) || Physics.Raycast(transform.position, transform.TransformDirection(4, 0, 0), out hit, 2f))    //right
        {
            if (hit.transform.tag == "wall")
            {
                humanRotation += -Time.deltaTime * 66 * rotSpeed;
                rotDir = Random.Range(-1f, 1f);
            }

        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(-4, 0, 2), out hit, 2f) || Physics.Raycast(transform.position, transform.TransformDirection(-4, 0, 0), out hit, 2f))     //left
        {
            if (hit.transform.tag == "wall")
            {
                humanRotation += Time.deltaTime * 66 * rotSpeed;
                rotDir = Random.Range(-1f, 1f);
            }

        }
        else if (Physics.Raycast(transform.position + new Vector3(0, 0f, 0), transform.TransformDirection(Vector3.forward), out hit, 2f)) //front
        {
            if (hit.transform.tag == "wall")
            {
                if (firstHitActive)
                {
                    firstHitActive = false;
                    rotIndex = Random.Range(0, 2);
                    rotateDirect = rotSerchDirect[rotIndex];
                }
                humanRotation += rotateDirect * Time.deltaTime * 66 * rotSpeed;
                rotDir = Random.Range(-1f, 1f);

            }
        }
        else
        {
            firstHitActive = true;
            humanRunActive = true;
            humanRotation += rotDir * Time.deltaTime * 20 * rotSpeed;

        }
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + humanRotation, transform.rotation.z);
    }
    void Move()
    {
        if (humanRunActive)
        {
            //transform.Translate(( transform.forward) * moveSpeed * 10 * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.forward, moveSpeed * 10 * Time.deltaTime);
            //rigidbody.velocity = transform.forward * moveSpeed;
        }
        else
        {
            //rigidbody.velocity = Vector3.zero;
        }
    }
}
