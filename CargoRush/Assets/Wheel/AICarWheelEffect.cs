using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarWheelEffect : MonoBehaviour
{
    public GameObject SkidTrailPrefab;
    public ParticleSystem skidParticles;
    private void Start()
    {
        if (skidParticles != null)
        {
            skidParticles.Stop();
        }
    }
    public void EmitTyreSkid()
    {
        GameObject m_SkidTrail = Instantiate(SkidTrailPrefab, transform.position, Quaternion.identity);
        m_SkidTrail.transform.parent = transform;
    }
    public void EmitTyreSmoke()
    {
        skidParticles.Play();
    }
}
