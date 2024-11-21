using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using HomaGames.HomaBelly;

public enum IndType
{
    ind1,
    ind2
}
public class IndicatorManager : MonoBehaviour
{
    public static Action<Transform> OnUpdate, OnUpdate2;

    private static IndicatorManager _instance = null;
    public static IndicatorManager Instance => _instance;
    [SerializeField] Transform indicator;
    public MeshRenderer indicatorMesh;
    [SerializeField] Transform indicator2;
    Transform targetPos;
    Transform targetPosTrnUp;
    public List<WorkArea> _FishDropAreaList = new List<WorkArea>();
    public TransUpPlatform _TransUpPlatform;

    public List<IndTargeter> targeterList;
    public List<IndTargeter> targeterActiveList;
    public List<Stand> machines = new List<Stand>();
    public IndType _indType;
 
    private void Awake()
    {
        _instance = this;
    }
    public bool CheckMachines()
    {
        bool rawActive = false;
        foreach (var mch in machines)
        {
            if (mch.machineActive)
            {
                rawActive = true;
            }
        }
        return rawActive;
    }
    private void Start()
    {
        foreach (var x in targeterList)
        {
            targeterActiveList.Add(x);

            //if (PlayerPrefs.GetInt(x.targeterName) == 0)
            //{
            //    targeterActiveList.Add(x);
            //}
        }
        OnUpdate = null;
        OnUpdate2 = null;
        StartCoroutine(CollectableCountCheck());
        IndResetList();
    }
    void IndResetList()
    {
        for(int i = 0; i < PlayerPrefs.GetInt("IndicatorTargeterActive"); i++)
        {
            if (targeterActiveList.Count > 0)
            {
                targeterActiveList.Remove(targeterActiveList[0]);
            }
        }
    }
    public void IndicaorActive(Transform _targetPos)
    {
        //transUpIndActive = false;
        targetPos = _targetPos;

        switch (_indType)
        {
            case IndType.ind1:
                {
                    OnUpdate = null;
                    OnUpdate += ShowIndicator;
                    indicator.gameObject.SetActive(true);
                }
                break;
            case IndType.ind2:
                {
                    OnUpdate2 = null;
                    OnUpdate2 += ShowIndicator2;
                    indicator2.gameObject.SetActive(true);
                }
                break;
        }
    
    }
    public void IndicaorDeActive()
    {
        switch (_indType)
        {
            case IndType.ind1:
                {
                    OnUpdate = null;
                    indicator.gameObject.SetActive(false);

                }
                break;
            case IndType.ind2:
                {
                    OnUpdate2 = null;
                    indicator2.gameObject.SetActive(false);
                }
                break;
        }
    }

    private void Update()
    {
        OnUpdate?.Invoke(targetPos);
        OnUpdate2?.Invoke(targetPos);
    }
    private void ShowIndicator(Transform targetPos)
    {
        if(targetPos == null)
        {
            IndicaorDeActive();
            return;
        }
        Vector3 direction = targetPos.position - indicator.transform.position;
        float distance = Vector3.Distance(targetPos.position, indicator.transform.position);

        transform.rotation = Quaternion.LookRotation(direction);
        if (distance > 1f)
        {
            IndicatorScaleSet(distance);
        }
        else
        {
            indicator.transform.localScale = new Vector3(indicator.transform.localScale.x, indicator.transform.localScale.y, 0);
        }
    }
    private void ShowIndicator2(Transform targetPos)
    {
        if (targetPos == null)
        {
            IndicaorDeActive();
            return;
        }
        Vector3 direction = targetPos.position - indicator2.transform.position;

        transform.rotation = Quaternion.LookRotation(direction);
     
    }
    float offset = 0f;
    void IndicatorScaleSet(float distance)
    {
        indicator.transform.localScale = new Vector3(indicator.transform.localScale.x, indicator.transform.localScale.y, distance);
        indicatorMesh.material.mainTextureScale = new Vector2(1, distance);
        offset -= Time.deltaTime * 2;
        if(offset < -250)
        {
            offset = 0;
        }
        indicatorMesh.material.mainTextureOffset = new Vector2(1, offset);
    }


    //public void CheckFishCount()
    //{
    //    int fishCollectCount = 0;

    //    foreach(var fishDrop in _FishDropAreaList)
    //    {
    //        fishCollectCount += fishDrop.fishCollectable.Count;
    //    }
    //    if (fishCollectCount == 0)
    //    {
    //        IndicaorActive(_TransUpPlatform.transform);
    //    }
    //}

    public GameObject lastText;

    public void IndicatorTargeterActive()
    {
        PlayerPrefs.SetInt("IndicatorTargeterActive", PlayerPrefs.GetInt("IndicatorTargeterActive") + 1);
        if (targeterActiveList.Count > 0)
        {
            if (lastText != null)
            {
                lastText.SetActive(false);
            }

            targeterActiveList[0].gameObject.SetActive(true);
            lastText = targeterActiveList[0].gameObject;
            IndicaorActive(targeterActiveList[0].transform);
            targeterActiveList.Remove(targeterActiveList[0]);
        }
    }
    public bool transUpIndActive = false;
    IEnumerator CollectableCountCheck()
    {
        while (true)
        {
            if (transUpIndActive && PlayerPrefs.GetInt("tutorialsection1") == 2)
            {
                if (_TransUpPlatform._FishDropArea.collectableList.Count == 0 && !CheckMachines())
                {
                    yield return new WaitForSeconds(20f);
                    if (_TransUpPlatform._FishDropArea.collectableList.Count == 0 && !CheckMachines())
                    {
                        transUpIndActive = false;
                        IndicaorActive(_TransUpPlatform.transform);
                    }
                }
            }
            yield return new WaitForSeconds(1f);
        }
    }


    public TextMeshProUGUI gemCounter;
    public TextMeshProUGUI gemCounter2;
    public TextMeshProUGUI boxPackCounter;
    public int productCountForTutorial = 3;
    public int boxCountForTutorial = 3;
    public int boxpackCountForTutorial = 3;

    public void GemCounter(int gemCount)
    {
        gemCounter.text = gemCount.ToString() + "/" + productCountForTutorial.ToString();
    }
    public void GemCounter2(int gemCount)
    {
        gemCounter2.text = gemCount.ToString() + "/" + boxCountForTutorial.ToString();
    }
    public void BoxCounter(int gemCount)
    {
        boxPackCounter.text = gemCount.ToString() + "/" + boxpackCountForTutorial.ToString();
    }

    public void KeepCollectTutorial()
    {
        if (PlayerPrefs.GetInt("tutorialseq1") == 0)
        {
            PlayerPrefs.SetInt("tutorialseq1", 1);
            //ShopManager.Instance.buyOthersGO.SetActive(true);
            if (PlayerPrefs.GetInt("againcollect") == 0)
            {
                //PlayerPrefs.SetInt("tutorialcompleted", 1);
                //TutorialManager.Instance.TutorialCompletedCheck();

                PlayerPrefs.SetInt("againcollect", 1);
                Transform indTr = targeterActiveList[0].transform;
                float distance;
                Collectable currentCollectable;
                if (FishDropArea.Instance.collectableList.Count != 0)
                {
                    Transform crusherTR = FishDropArea.Instance.mineCrusher.transform;
                    currentCollectable = FishDropArea.Instance.collectableList[0];
                    distance = Vector3.Distance(currentCollectable.transform.position, crusherTR.position);
                    for (int i = 0; i < FishDropArea.Instance.collectableList.Count; i++)
                    {
                        if (Vector3.Distance(FishDropArea.Instance.collectableList[i].transform.position, crusherTR.position) < distance)
                        {
                            currentCollectable = FishDropArea.Instance.collectableList[i];
                            distance = Vector3.Distance(currentCollectable.transform.position, crusherTR.position);
                        }
                    }
                    indTr.position = new Vector3(currentCollectable.transform.position.x, indTr.position.y, currentCollectable.transform.position.z);
                    IndicatorTargeterActive();
                }

            }
        }
    }

    public void TutorialStepStart(int tutorialStepIndex)
    {    
        Analytics.TutorialStepStarted(tutorialStepIndex);
        Debug.Log("Tutorial Step: " + tutorialStepIndex);  
        
        if(tutorialStepIndex == 17)
            PlayerPrefs.SetInt("firstTime",1);
        if(tutorialStepIndex > 17) return;
        PlayerController.Instance.TrainActive();
    
    }
    public void TutorialStepCompleted()
    {
        Analytics.TutorialStepCompleted(); 
        Debug.Log("Tutorial Completed");
        PlayerController.Instance.CloseTrain();
        if (PlayerPrefs.HasKey("firstTime"))
        {
            StartCoroutine(WaitForWagonRewardedAd());
        }
    }

    private IEnumerator WaitForWagonRewardedAd()
    {
        yield return new WaitForSeconds(.15f);
        PurchaseManager.Instance.wagonDriveTimeTxt.text =
            ConvertSecondToMinSec.Converter(MRCUpgradeManager.Instance._characterUpgradeSettings.trainUsageTime[Globals.trainUsageTimeLevel]) + " Min";
        PurchaseManager.Instance.wagonWithAd_GO.SetActive(true);
    }
}
