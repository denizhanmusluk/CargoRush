using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using TMPro;
using DG.Tweening;

public class HoleManager : MonoBehaviour
{
    private static HoleManager _instance = null;
    public static HoleManager Instance => _instance;
    [SerializeField] Transform holeParticle;
    [SerializeField] HoleController holeController;
    public HoleTimer _holeTimer;
    BoingScale boingScale;
    public Transform holeCylinder;
    public HoleUpgradeSettings _holeUpgradeSettings;
    public MeshFilter meshFilter;
    public MeshCollider meshCollider;
    private Mesh _mesh;

    private List<int> VerticesIndex = new List<int>();

    private readonly List<Vector3> offset = new List<Vector3>();

    public float standartDistance;
    public float holeSize = 1f;
   public Vector3 startPosition;
   Vector3 firstSize;
   Vector3 downSize;
    [SerializeField] Slider envCollectSlider;
    public int envCount = 0;

    //[SerializeField] ParticleSystem upgradeParticle;
    [SerializeField] GameObject speedUpParticle;
    [SerializeField] GameObject timeUpParticle;
    [SerializeField] GameObject upgradeParticle2;
    [SerializeField] GameObject sizeUpPrefab;
    public ParticleSystem confetti;

    TextMeshProUGUI counterText;
    [SerializeField] Color targetColor;
    Color firstColor;
    private void Awake()
    {
        _instance = this;
        firstSize = transform.localScale;
        downSize = new Vector3(firstSize.x, 0.1f, firstSize.z);
        //if (PlayerPrefs.GetInt("holeRadiusLevel") != 0)
        //{
        //    Globals.holeRadiusLevel = PlayerPrefs.GetInt("holeRadiusLevel");
        //}
    }

    void Start()
    {
        //_holeUpgradeSettings = LevelManager.Instance._holeUpgradeSettings;

        envCollectSlider.value = 0;
        CameraFollower.Instance.targetFollow = transform;
           _mesh = meshFilter.mesh;
        for(int i = 0; i< _mesh.vertices.Length; i++)
        {
            var distance = Vector3.Distance(transform.position, _mesh.vertices[i]);

            if(distance <= standartDistance)
            {
                VerticesIndex.Add(i);
                offset.Add(_mesh.vertices[i] - transform.position);
            }
        }
        //startPosition = new Vector3(transform.position.x, transform.position.y, -5);

        HolePositionReset();
        Init();
    }
    public void HolePositionReset()
    {
        envCount = 0;
        envCollectSlider.value = 0;
        transform.position = startPosition;
        holeController.objPosition = transform.position;
    }
    private void Init()
    {
        boingScale = GetComponent<BoingScale>();
        HoleScaleSet(PlayerPrefs.GetInt("holeLevel" + Globals.currentLevelIndex.ToString()));
    }
    // Update is called once per frame
    Vector3[] vertices;
    void Update()
    {
        vertices = _mesh.vertices;

        for(int i = 0; i< VerticesIndex.Count; i++)
        {
            vertices[VerticesIndex[i]] = transform.position + offset[i] * holeSize;
        }

        _mesh.vertices = vertices;

        meshFilter.mesh = _mesh;
        meshCollider.sharedMesh = _mesh;



        if (Input.GetKeyDown(KeyCode.A))
        {
            HoleLevelUp();
        }
    }
    //void FixedUpdate()
    //{
    //    meshCollider.sharedMesh = _mesh;
    //}
    public void CollectEnv()
    {
        envCount++;
        StartCoroutine(SliderSmoothSet());
        //envCollectSlider.value = (float)envCount / (float)_holeUpgradeSettings._envCount[Globals.holeLevel];
        if (_holeUpgradeSettings._envCount[Globals.holeLevel] < envCount)
        {
            if (_holeUpgradeSettings._envCount.Length - 1 > Globals.holeLevel)
            {
                Globals.holeLevel++;
                HoleLevelUpCollectEnv();
                envCount = 0;
                SizeUpTextCreate();
                //StartCoroutine(SliderSetDown());
            }
            else
            {
                envCollectSlider.value = 1;
            }
        }
    }
    IEnumerator SliderSmoothSet()
    {
        float counter = 0f;
        while(counter < 1f)
        {
            counter += Time.deltaTime;

            envCollectSlider.value = Mathf.Lerp(envCollectSlider.value, (float)envCount / (float)_holeUpgradeSettings._envCount[Globals.holeLevel], Time.deltaTime * 5);
           yield return null;
        }
    }
    void SizeUpTextCreate()
    {
        //Vector3 randomVector = new Vector3(Random.Range(-4f, 4f), Random.Range(0f, 4f), Random.Range(0f, 4f));
        Instantiate(sizeUpPrefab, transform.position, Quaternion.identity,transform);
    }
    IEnumerator SliderSetDown()
    {
        float val = 1f;
        float counter = 0f;
        while(counter < 1f)
        {
            counter += Time.deltaTime;
            val = Mathf.Lerp(1f, 0f, counter);
            envCollectSlider.value = val;
         yield return null;
        }

    }
    public void HoleLevelUp()
    {
        Globals.holeRadiusLevel = _holeUpgradeSettings.holeCollectLevel[Globals.holeLevel];

        //upgradeParticle.Play();
        GameObject prtcl = Instantiate(upgradeParticle2, transform.position + new Vector3(0, 0.01f, 0), Quaternion.identity, transform);
        prtcl.transform.localScale = holeCylinder.transform.localScale * 3.5f;
        //Globals.holeRadiusLevel++;
        //PlayerPrefs.SetInt("holeRadiusLevel", Globals.holeRadiusLevel);
        HoleScaleSet(Globals.holeLevel);
        CameraManager.Instance.HoleCameraFovSet();

        //CameraFovSet();
    }
    public void HoleLevelUpCollectEnv()
    {

        //upgradeParticle.Play();
        GameObject prtcl = Instantiate(upgradeParticle2, transform.position + new Vector3(0, 0.01f, 0), Quaternion.identity, transform);
        prtcl.transform.localScale = holeCylinder.transform.localScale * 3.5f;
        //Globals.holeRadiusLevel++;
        //PlayerPrefs.SetInt("holeRadiusLevel", Globals.holeRadiusLevel);
        HoleScaleSetCollectEnv(holeSize);
        CameraManager.Instance.HoleCameraFovSet();

        //CameraFovSet();
    }
    public void HoleSpeedUp()
    {
        GameObject prtcl = Instantiate(speedUpParticle, transform.position + new Vector3(0, 0.2f, 0), Quaternion.identity, transform);
        prtcl.transform.localScale = holeCylinder.transform.localScale * 2f;
    }
    public void HoleTimeUp()
    {
        GameObject prtcl = Instantiate(timeUpParticle, transform.position + new Vector3(0, 0.2f, 0), Quaternion.identity, transform);
        prtcl.transform.localScale = holeCylinder.transform.localScale * 2f;
    }
    private void HoleScaleSet(int holeTargetLevel)
    {
        float oldSize;
        float targetSize;

        if(holeTargetLevel != 0)
        {
            oldSize = _holeUpgradeSettings.holeRadius[holeTargetLevel - 1];
        }
        else
        {
            oldSize = 0;
        }

        targetSize = _holeUpgradeSettings.holeRadius[holeTargetLevel];

        boingScale.ScaleEffectTR(holeCylinder, oldSize, targetSize, 1f, Ease.OutElastic);
        boingScale.ScaleEffectTR(holeParticle, oldSize, targetSize/2f, 1f, Ease.OutElastic);
        ScaleEffectValue(oldSize, targetSize, 1f, Ease.OutElastic);
    }
    private void HoleScaleSetCollectEnv(float holeCurrentSize)
    {
        float targetSize = holeCurrentSize + _holeUpgradeSettings._holeRadInc;

        boingScale.ScaleEffectTR(holeCylinder, holeCurrentSize, targetSize, 1f, Ease.OutElastic);
        boingScale.ScaleEffectTR(holeParticle, holeCurrentSize, targetSize / 2f, 1f, Ease.OutElastic);
        ScaleEffectValue(holeCurrentSize, targetSize, 1f, Ease.OutElastic);
    }
    public Tween ScaleEffectValue(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                holeSize = value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
    public Tween ScaleEffectWhirl(Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = new Vector3(1 * value, prt.localScale.y, 1 * value);
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
    public void HoleScaleDown()
    {
        StartCoroutine(_HoleScaleDown());
    }
    IEnumerator _HoleScaleDown()
    {
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            transform.localScale = Vector3.Lerp(firstSize, downSize, counter);
            yield return null;
        }
    }
    public void HoleScaleUp()
    {
        StartCoroutine(_HoleScaleUp());
    }
    IEnumerator _HoleScaleUp()
    {
        float counter = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            transform.localScale = Vector3.Lerp(downSize, firstSize, counter);

            yield return null;
        }
    }

    int currentRadiusLevel = 0;
    int currentSpeedLevel = 0;
    public void FasterRewardLevelUp(int rewardTime, int extraLevel)
    {
        int reward_Time = rewardTime;
        if (rewardTime > _holeTimer.counter)
        {
            reward_Time = _holeTimer.counter;
        }
        RewardPanel.Instance.fasterPanelGO.SetActive(true);
        counterText = RewardPanel.Instance.fasterCounterText;

        firstColor = counterText.color;
        currentSpeedLevel = Globals.holeSpeedLevel;
        Globals.holeSpeedLevel += extraLevel;
        if (Globals.holeSpeedLevel > _holeUpgradeSettings.holeSpeed.Length - 1)
        {
            Globals.holeSpeedLevel = _holeUpgradeSettings.holeSpeed.Length - 1;
        }


        HoleSpeedUp();
        StartCoroutine(Speed_Reset(reward_Time));

    }
    IEnumerator Speed_Reset(int rewardTime)
    {
        int counter = rewardTime;

        while (counter > 0)
        {
            int minute = Mathf.FloorToInt(counter / 60);
            int second = Mathf.FloorToInt(counter % 60);

            counterText.text = minute.ToString() + ":" + ($"{second}");
            if (minute < 10)
            {
                counterText.text = "0" + minute.ToString() + ":" + ($"{second}");

            }
            if (second < 10)
            {
                counterText.text = minute.ToString() + ":0" + ($"{second}");
                if (minute < 10)
                {
                    counterText.text = "0" + minute.ToString() + ":0" + ($"{second}");

                }
                if (counter <= 3)
                {
                    StartCoroutine(CounterTextColorSet());
                    VibratoManager.Instance.LightVibration();
                }
            }
            counter--;
            yield return new WaitForSeconds(1);
        }
        counterText.text = "00:00";
        SpeedReset();

    }
    void SpeedReset()
    {
        RewardPanel.Instance.fasterPanelGO.SetActive(false);
        Globals.holeSpeedLevel = currentSpeedLevel;
    }
    public void BiggerRewardLevelUp(int rewardTime, int extraLevel)
    {
        int reward_Time = rewardTime;
        if (rewardTime > _holeTimer.counter)
        {
            reward_Time = _holeTimer.counter;
        }
        RewardPanel.Instance.biggerPanelGO.SetActive(true);
        counterText = RewardPanel.Instance.biggerCounterText;
        firstColor = counterText.color;

        currentRadiusLevel = Globals.holeLevel;
        Globals.holeLevel += extraLevel;
        if (Globals.holeLevel > _holeUpgradeSettings.holeRadius.Length - 1)
        {
            Globals.holeLevel = _holeUpgradeSettings.holeRadius.Length - 1;
        }

        HoleLevelUp();
        SizeUpTextCreate();
        StartCoroutine(Bigger_Reset(reward_Time));
    }

    IEnumerator Bigger_Reset(int rewardTime)
    {
        int counter = rewardTime;
        while (counter > 0)
        {
            int minute = Mathf.FloorToInt(counter / 60);
            int second = Mathf.FloorToInt(counter % 60);

            counterText.text = minute.ToString() + ":" + ($"{second}");
            if (minute < 10)
            {
                counterText.text = "0" + minute.ToString() + ":" + ($"{second}");

            }
            if (second < 10)
            {
                counterText.text = minute.ToString() + ":0" + ($"{second}");
                if (minute < 10)
                {
                    counterText.text = "0" + minute.ToString() + ":0" + ($"{second}");

                }
                if (counter <= 3)
                {
                    StartCoroutine(CounterTextColorSet());
                    VibratoManager.Instance.LightVibration();
                }
            }
            counter--;
            yield return new WaitForSeconds(1);
        }



        counterText.text = "00:00";
        BiggerReset();

    }
    void BiggerReset()
    {
        RewardPanel.Instance.biggerPanelGO.SetActive(false);
        Globals.holeLevel = currentRadiusLevel;
        HoleLevelUp();
    }


    IEnumerator CounterTextColorSet()
    {
        float counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            value = (Mathf.Sin(Mathf.PI * counter));
            //holeTimerBG_Image.color = Color.Lerp(firstColor, targetColor, value);
            counterText.color = Color.Lerp(firstColor, targetColor, value);
            yield return null;
        }
    }


}
