using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (AudioSource))]
    public class WheelEffects : MonoBehaviour
    {
        public Transform SkidTrailFull;

        public Transform SkidTrailPrefab;
        public static Transform skidTrailsDetachedParent;
        public ParticleSystem skidParticles;
        public ParticleSystem tyreParticles;
        public bool skidding { get; private set; }
        public bool PlayingAudio { get; private set; }


        //private AudioSource m_AudioSource;
        private Transform m_SkidTrail;
        private Transform m_SkidTrail_Full;
        public bool skiddingFull = true;
        //private WheelCollider m_WheelCollider;

        [SerializeField] float tyreParticleHeight;

        private void Start()
        {
            DnzEvents.TyreSkid += EmitTyreSkid;
            DnzEvents.TyreSmoke += EmitTyreSmoke;
            DnzEvents.EndTyreSkid += EndSkidTrail;
            //skidParticles = transform.root.GetComponentInChildren<ParticleSystem>();

            if (skidParticles == null)
            {
                Debug.LogWarning(" no particle system found on car to generate smoke particles", gameObject);
            }
            else
            {
                skidParticles.Stop();
                tyreParticles.Stop();
            }

            //m_WheelCollider = GetComponent<WheelCollider>();
            //m_AudioSource = GetComponent<AudioSource>();
            PlayingAudio = false;

            if (skidTrailsDetachedParent == null)
            {
                skidTrailsDetachedParent = new GameObject("Skid Trails - Detached").transform;
            }
        }

        public void EmitTyreSmoke()
        {
            //skidParticles.transform.position = transform.position + Vector3.up * tyreParticleHeight;
            //skidParticles.Emit(20);
            skidParticles.Play();
        }
        public void EmitTyreSkidFull()
        {
            m_SkidTrail_Full = Instantiate(SkidTrailFull);

        }

        public void EmitTyreSkid()
        {
            if (!skidding)
            {
                StartCoroutine(StartSkidTrail());
            }
        }

        public void EmitTyreSpark()
        {
            tyreParticles.transform.position = transform.position + Vector3.up * tyreParticleHeight;
            tyreParticles.Emit(1);
        }


        //public void PlayAudio()
        //{
        //    m_AudioSource.Play();
        //    PlayingAudio = true;
        //}


        //public void StopAudio()
        //{
        //    m_AudioSource.Stop();
        //    PlayingAudio = false;
        //}
        private void Update()
        {
            if (m_SkidTrail != null && skidding)
            {
                m_SkidTrail.position = transform.position + Vector3.up * tyreParticleHeight;
            }
            if (m_SkidTrail_Full != null && skiddingFull)
            {
                m_SkidTrail_Full.position = transform.position + Vector3.up * (tyreParticleHeight - 0.01f);
            }
            
        }

        public IEnumerator StartSkidTrail()
        {
            skidding = true;
            m_SkidTrail = Instantiate(SkidTrailPrefab);
            while (m_SkidTrail == null)
            {
                yield return null;
            }
            //m_SkidTrail.parent = transform;
        }


        public void EndSkidTrail()
        {
            if (!skidding)
            {
                return;
            }
            skidding = false;
            m_SkidTrail.parent = skidTrailsDetachedParent;
            Destroy(m_SkidTrail.gameObject, 10);
        }
    }
}
