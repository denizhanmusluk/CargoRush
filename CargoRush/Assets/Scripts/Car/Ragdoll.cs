using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    protected Animator[] animator;
    protected Rigidbody Rigidbody;
    protected CapsuleCollider capsuleCollider;
    protected Collider[] childrenCollider;
    protected Rigidbody[] childrenRigidbody;
    List<Vector3> firstPos = new List<Vector3>();
    List<Quaternion> firstRot = new List<Quaternion>();
    void Awake()
    {
        animator = GetComponentsInChildren<Animator>();
        Rigidbody = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>();
      
        childrenCollider = GetComponentsInChildren<Collider>();
        childrenRigidbody = GetComponentsInChildren<Rigidbody>();
    }

    private void Start()
    {
        RagdollActivate(false);
    }
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.R))
    //    {
    //        DraggingRagdollActivate(true);
    //    }
    //    if (Input.GetKeyDown(KeyCode.T))
    //    {
    //        DraggingRagdollActivate(false);
    //    }

    //}
    //public void DraggingRagdollActivate(bool active)
    //{
    //    childrenCollider = GetComponentsInChildren<Collider>();
    //    childrenRigidbody = GetComponentsInChildren<Rigidbody>();
    //    foreach (var collider in childrenCollider)
    //    {
    //        if (collider.GetComponent<Pelvis>() == null && collider.GetComponent<GunSystem>() == null)
    //        {
    //            collider.enabled = active;
               
    //        }
    //        if (collider.GetComponent<GunSystem>() != null)
    //        {
    //            collider.isTrigger = active;
    //        }
    //    }
    //    int i = 0;
    //    foreach (var rigidb in childrenRigidbody)
    //    {
    //        if (rigidb.GetComponent<Pelvis>() == null && rigidb.GetComponent<GunSystem>() == null)
    //        {
    //            rigidb.detectCollisions = active;
    //            rigidb.isKinematic = !active;
             
    //        }
    //        if (rigidb.transform.name != transform.name)
    //        {
    //            if (active)
    //            {
    //                firstPos.Add(rigidb.transform.localPosition);
    //                firstRot.Add(rigidb.transform.localRotation);
    //            }
    //            else
    //            {
    //                StartCoroutine(TransformSet(rigidb.transform, firstPos[i], firstRot[i]));
    //            }
    //            i++;
    //        }
    //    }

    //    //rest
    //    if (active)
    //    {
    //        foreach (var anims in animator)
    //        {
    //            anims.enabled = !active;
    //        }
    //    }
    //    else
    //    {
    //        StartCoroutine(SetAnimator());
    //    }
    
    //    if (GetComponent<Rigidbody>() != null)
    //    {
    //        Rigidbody.detectCollisions = true;
    //    }
    //    //Rigidbody.isKinematic = false;
    //    if (GetComponent<CapsuleCollider>() != null)
    //    {
    //        capsuleCollider.enabled = true;
    //        capsuleCollider.isTrigger = active;
    //    }
    //    if (GetComponent<SphereCollider>() != null)
    //    {
    //        GetComponent<SphereCollider>().enabled = !active;
    //    }
    //}
    IEnumerator TransformSet(Transform tr, Vector3 lastPos, Quaternion lastRot)
    {
        Vector3 stPos = tr.localPosition;
        Quaternion stRot = tr.localRotation;
        float counter = 0f;
        while(counter < 1f)
        {
            counter += 3 * Time.deltaTime;
            tr.localPosition = Vector3.Lerp(stPos, lastPos, counter);
            tr.localRotation = Quaternion.Lerp(stRot, lastRot, counter);
            yield return null;
        }
    }
    IEnumerator SetAnimator()
    {
        yield return new WaitForSeconds(0.33f);
        foreach (var anims in animator)
        {
            anims.enabled = true;
        }
    }
    public void RagdollActivate(bool active)
    {
        foreach (var collider in childrenCollider)
            collider.enabled = active;
        foreach (var rigidb in childrenRigidbody)
        {
            rigidb.detectCollisions = active;
            rigidb.isKinematic = !active;
            rigidb.drag = 2;
        }

        //rest
        foreach (var anims in animator)
        {
            anims.enabled = !active;
        }
        if (GetComponent<Rigidbody>() != null)
        {
            Rigidbody.detectCollisions = !active;
        }
        //Rigidbody.isKinematic = false;
        if (GetComponent<CapsuleCollider>() != null)
        {
            capsuleCollider.enabled = !active;
        }
        if (GetComponent<SphereCollider>() != null)
        {
            GetComponent<SphereCollider>().enabled = !active;
        }
    }
    //public void RagdollFallDownFlat(bool active)
    //{
    //    childrenCollider = GetComponentsInChildren<Collider>();
    //    childrenRigidbody = GetComponentsInChildren<Rigidbody>();
    //    firstPos.Clear();
    //    firstRot.Clear();
    //    int i = 0;
    //    foreach (var rigidb in childrenRigidbody)
    //    {
    //        if (rigidb.GetComponent<GunSystem>() == null && rigidb.transform.name != transform.name)
    //        {
    //            rigidb.detectCollisions = !active;
    //            rigidb.isKinematic = active;

    //            firstPos.Add(rigidb.transform.localPosition);
    //            firstRot.Add(rigidb.transform.localRotation);
    //            //StartCoroutine(TransformSet(rigidb.transform, firstPos[i], firstRot[i]));
    //            i++;
    //            rigidb.drag = 15;
    //            rigidb.angularDrag = 15;

    //            rigidb.detectCollisions = active;
    //            rigidb.isKinematic = !active;
    //            rigidb.GetComponent<Collider>().enabled = active;
    //            rigidb.AddForce(Vector3.up * 1500);
    //            if (rigidb.transform.tag == "Pelvis")
    //            {
    //                rigidb.constraints = RigidbodyConstraints.FreezePosition;
    //            }
    //        }
    //    }
    //    //foreach (var collider in childrenCollider)
    //    //    collider.enabled = active;
    //    //foreach (var rigidb in childrenRigidbody)
    //    //{
    //    //    rigidb.detectCollisions = active;
    //    //    rigidb.isKinematic = !active;
  
    //    //}

    //    foreach (var anims in animator)
    //    {
    //        anims.enabled = !active;
    //    }
    //    if (GetComponent<Rigidbody>() != null)
    //    {
    //        Rigidbody.detectCollisions = !active;
    //    }
    //    //Rigidbody.isKinematic = false;
    //    if (GetComponent<Collider>() != null)
    //    {
    //        capsuleCollider.enabled = !active;
    //    }
    //    Rigidbody.isKinematic = true;

    //}
    //public void RagdollToAnim()
    //{

    //    int i = 0;
    //    foreach (var rigidb in childrenRigidbody)
    //    {
    //        if ( rigidb.GetComponent<GunSystem>() == null && rigidb.transform.name != transform.name)
    //        {
    //            rigidb.detectCollisions = false;
    //            rigidb.isKinematic = true;
    //            rigidb.GetComponent<Collider>().enabled = false;
    //            rigidb.drag = 0;
    //            rigidb.angularDrag = 0.05f;
    //            if (rigidb.transform.tag == "Pelvis")
    //            {
    //                rigidb.constraints = RigidbodyConstraints.None;
    //            }
    //            firstPos.Add(rigidb.transform.localPosition);
    //            firstRot.Add(rigidb.transform.localRotation);
    //            StartCoroutine(TransformSet(rigidb.transform, firstPos[i], firstRot[i]));
    //            i++;
    //        }
    //    }

    //    if (GetComponent<Rigidbody>() != null)
    //    {
    //        Rigidbody.detectCollisions = true;
    //    }
    //    //Rigidbody.isKinematic = false;
    //    if (GetComponent<Collider>() != null)
    //    {
    //        capsuleCollider.enabled = true;
    //    }
    //    Rigidbody.isKinematic = false;
    //    StartCoroutine(SetAnimator());
    //}
    public void RagdollActivateWithForce(bool active,Vector3 forceDir, int impulseFactor)
    {
        childrenCollider = GetComponentsInChildren<Collider>();
        childrenRigidbody = GetComponentsInChildren<Rigidbody>();
        Vector3 forwardDirection = transform.right;
        foreach (var collider in childrenCollider)
        {
            collider.enabled = active;
            collider.isTrigger = active;
        }
        foreach (var rigidb in childrenRigidbody)
        {
    
            rigidb.detectCollisions = active;
            rigidb.isKinematic = !active;
            rigidb.AddForce(new Vector3(forceDir.x, forceDir.y, forceDir.z) * impulseFactor * 400 + forwardDirection * impulseFactor * 500);
            rigidb.drag = 2;
        }

        //rest
        foreach (var anims in animator)
        {
            anims.enabled = !active;
        }
        if (GetComponent<Rigidbody>() != null)
        {
            Rigidbody.detectCollisions = !active;
        }
        //Rigidbody.isKinematic = false;
        if (GetComponent<Collider>() != null)
        {
            capsuleCollider.enabled = !active;
        }
        //Rigidbody.detectCollisions = !active;
        //Rigidbody.isKinematic = true;
        //capsuleCollider.enabled = !active;
        //StartCoroutine(SlowlySinking());
        StartCoroutine(CollidersSetDelay());
    }
    IEnumerator CollidersSetDelay()
    {
        yield return new WaitForSeconds(0.05f);
        foreach (var collider in childrenCollider)
        {
            collider.isTrigger = false;
        }
    }
    IEnumerator SlowlySinking()
    {
        yield return new WaitForSeconds(0.8f);

        foreach (var collider in childrenCollider)
        {
            collider.isTrigger = true;
        }
        foreach (var rigidb in childrenRigidbody)
        {
            rigidb.drag = 10;
        }
    }
}
