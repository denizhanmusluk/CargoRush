using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TapticPlugin;
using Cinemachine;
public class BuyBuild : MonoBehaviour
{
    public CinemachineVirtualCamera buyCamera;
    public BuildingManager buildingManager;
    [SerializeField] bool buyActive = true;
    [SerializeField] GameObject buyArea;
    [SerializeField] int woodCountTotal, plasticCountTotal, ironCountTotal;
    [SerializeField] public int woodCountCurrent, plasticCountCurrent, ironCountCurrent;
    [SerializeField] TextMeshProUGUI woodCountText, plasticCountText, ironCountText;
    [SerializeField] GameObject woodCountTextArea, plasticCountTextArea, ironCountTextArea;
    [SerializeField] Transform buildPosTR;
    [SerializeField] int cost;
    //int currentAmount;
    //int currentAmountTotal;

    [SerializeField] public Image outline;
    //[SerializeField] public TextMeshProUGUI costText;
    bool pressed = false;
    public bool isWork = false;
    bool sellActive = true;
    [SerializeField] GameObject buildPrefab;
    [SerializeField] Vector3 buildPositionOffset;
    public bool isbuy = true;
    public bool dropActive = true;
    //float counterTime = 0;


    [SerializeField] string buyName;
    [SerializeField] string currentCostBuild;
    [SerializeField] string currentWood;
    [SerializeField] string currentPlastic;
    [SerializeField] string currentIron;

    

    void Start()
    {
        if (PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 1)
        {
            buyArea.SetActive(false);
            //Instantiate(buildPrefab, buildPositionOffset, transform.rotation, transform.parent);
            StartCoroutine(buildScaling());
            GetComponent<Collider>().enabled = false;
        }


        //if (PlayerPrefs.GetInt(currentCostBuild) == 0)
        //{
        //    currentAmount = cost;
        //    costText.text = cost.ToString();
        //}
        //else
        //{
        //    currentAmount = PlayerPrefs.GetInt(currentCostBuild);
        //    costText.text = currentAmount.ToString();
        //}
        //outline.fillAmount = 1 - (float)currentAmount / (float)cost;
        // // // // // // // // // //

        if (PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 0)
        {
            TextInit();
            AvailableForPurchase.Instance._buyBuild.Add(this);
        }
    }
    void TextInit()
    {
        if (PlayerPrefs.GetInt(currentWood) == -1)
        {
            woodCountTotal = 0;
            woodCountCurrent = 0;
        }
        if (PlayerPrefs.GetInt(currentWood) == 0)
        {
            woodCountCurrent = woodCountTotal;
        }
        else
        {
            woodCountCurrent = PlayerPrefs.GetInt(currentWood);
        }

        if (PlayerPrefs.GetInt(currentPlastic) == -1)
        {
            plasticCountTotal = 0;
            plasticCountCurrent = 0;
        }
        if (PlayerPrefs.GetInt(currentPlastic) == 0)
        {
            plasticCountCurrent = plasticCountTotal;
        }
        else
        {
            plasticCountCurrent = PlayerPrefs.GetInt(currentPlastic);
        }


        if (PlayerPrefs.GetInt(currentIron) == -1)
        {
            ironCountTotal = 0;
            ironCountCurrent = 0;
        }
        if (PlayerPrefs.GetInt(currentIron) == 0)
        {
            ironCountCurrent = ironCountTotal;
        }
        else
        {
            ironCountCurrent = PlayerPrefs.GetInt(currentIron);
        }

        if (woodCountCurrent > 0)
        {
            woodCountText.text = (woodCountCurrent).ToString();
            //woodCountText.text = (woodCountTotal - woodCountCurrent).ToString() + "/" + woodCountTotal.ToString();
        }
        else
        {
            woodCountTextArea.SetActive(false);
        }

        if (plasticCountCurrent > 0)
        {
            plasticCountText.text = (plasticCountCurrent).ToString();
            //plasticCountText.text = (plasticCountTotal - plasticCountCurrent).ToString() + "/" + plasticCountTotal.ToString();
        }
        else
        {
            plasticCountTextArea.SetActive(false);
        }
        
        if (ironCountCurrent > 0)
        {
            ironCountText.text = (ironCountCurrent).ToString();
            //ironCountText.text = (ironCountTotal - ironCountCurrent).ToString() + "/" + ironCountTotal.ToString();
        }
        else
        {
            ironCountTextArea.SetActive(false);
        }
        outline.fillAmount = 1 - (float)(woodCountCurrent + plasticCountCurrent + ironCountCurrent) / (float)(woodCountTotal + plasticCountTotal + ironCountTotal);
        OutlineSet();
    }
    void OutlineSet()
    {
        //Debug.Log(transform.name + "build start");

        StartCoroutine(OpenBuyCheck());

        //outline.fillAmount = 1 - (float)(woodCountCurrent + plasticCountCurrent + ironCountCurrent) / (float)(woodCountTotal + plasticCountTotal + ironCountTotal);
        StartCoroutine(OutlineSmooth());
    }
    bool outlineSetActive;
    IEnumerator OutlineSmooth()
    {
        outlineSetActive = false;
        yield return null;
        yield return null;
        outlineSetActive = true;
        float val = outline.fillAmount;
        float counter = 0f;
        while(counter < 1f && outlineSetActive)
        {
            counter += Time.deltaTime;

            outline.fillAmount = Mathf.Lerp(val, (1 - (float)(woodCountCurrent + plasticCountCurrent + ironCountCurrent) / (float)(woodCountTotal + plasticCountTotal + ironCountTotal)), counter);
            yield return null;
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pressed = true;
        }  
        if (Input.GetMouseButtonUp(0))
        {
            pressed = false;
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    PlayerPrefs.SetInt(buyName, 0);
        //    PlayerPrefs.SetInt(currentCostBuild, 0);
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            if (dropActive && PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 0)
            {
                //CollectionChecking(other.GetComponent<PlayerController>()._stackCollect);
                dropActive = false;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && other.GetComponent<PlayerController>().pressJoystick == false)
        {
            if (!dropActive && PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 0)
            {
                CollectionChecking(other.GetComponent<PlayerController>()._stackCollect);
                dropActive = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            dropActive = true;
        }
    }
    void CollectionChecking(StackCollect _stackCollect)
    {
        List<Collectable> woodCollectList = new List<Collectable>();

        int woodNoCollected = 0;
        int plasticNoCollected = 0;
        int ironNoCollected = 0;
        foreach (var collects in _stackCollect.collectionTrs)
        {
            if (collects.collectID == 0)
            {
                woodNoCollected++;
            }

            if (collects.collectID == 1)
            {
                plasticNoCollected++;
            }

            if (collects.collectID == 2)
            {
                ironNoCollected++;
            }
        }
        
        _stackCollect.ReverseCollectedList();
        _stackCollect.CollectedListReset();

        if (woodNoCollected <= woodCountCurrent)
        {
            _stackCollect.DropCollection(woodCountTextArea.transform, 0, woodNoCollected);
            StartCoroutine(SetWoodAmount(-woodNoCollected));
        }
        else
        {
            _stackCollect.DropCollection(woodCountTextArea.transform, 0, woodCountCurrent);
            StartCoroutine(SetWoodAmount(-woodCountCurrent));
        }

        if (plasticNoCollected <= plasticCountCurrent)
        {
            _stackCollect.DropCollection(plasticCountTextArea.transform, 1, plasticNoCollected);
            StartCoroutine(SetPlasticAmount(-plasticNoCollected));
        }
        else
        {
            _stackCollect.DropCollection(plasticCountTextArea.transform, 1, plasticCountCurrent);
            StartCoroutine(SetPlasticAmount(-plasticCountCurrent));
        }

        if (ironNoCollected <= ironCountCurrent)
        {
            _stackCollect.DropCollection(ironCountTextArea.transform, 2, ironNoCollected);
            StartCoroutine(SetIronAmount(-ironNoCollected));
        }
        else
        {
            _stackCollect.DropCollection(ironCountTextArea.transform, 2, ironCountCurrent);
            StartCoroutine(SetIronAmount(-ironCountCurrent));
        }
        OutlineSet();
    }
    void TextSet()
    {

    }
    bool woodSetActive;
    bool plasticSetActive;
    bool ironSetActive;
    IEnumerator SetWoodAmount(int amount)
    {
        int Old = woodCountCurrent;
        woodCountCurrent += amount;
        PlayerPrefs.SetInt(currentWood, woodCountCurrent);
        if (woodCountCurrent == 0)
        {
            PlayerPrefs.SetInt(currentWood, -1);
        }

        woodSetActive = false;
        yield return null;
        yield return null;
        woodSetActive = true;
        float counter = 0f;
        while (counter < 1f && woodSetActive)
        {
            counter += 2 * Time.deltaTime / Mathf.PI;
            float value = Mathf.Lerp((float)Old, (float)woodCountCurrent, counter);
            woodCountText.text = ((int)value).ToString();
            //woodCountText.text = (woodCountTotal - (int)value).ToString() + "/" + woodCountTotal.ToString();

            yield return null;
        }
        woodCountText.text = (woodCountCurrent).ToString();
        if(woodCountCurrent == 0)
        {
            woodCountTextArea.SetActive(false);
        }
        //woodCountText.text = (woodCountTotal - woodCountCurrent).ToString() + "/" + woodCountTotal.ToString();
    }

    IEnumerator SetPlasticAmount(int amount)
    {
        int Old = plasticCountCurrent;
        plasticCountCurrent += amount;
        PlayerPrefs.SetInt(currentPlastic, plasticCountCurrent);
        if(plasticCountCurrent == 0)
        {
            PlayerPrefs.SetInt(currentPlastic, -1);
        }
        plasticSetActive = false;
        yield return null;
        yield return null;
        plasticSetActive = true;
        float counter = 0f;
        while (counter < 1f && plasticSetActive)
        {
            counter += 2 * Time.deltaTime / Mathf.PI;
            float value = Mathf.Lerp((float)Old, (float)plasticCountCurrent, counter);
            plasticCountText.text = ((int)value).ToString();
            //ironCountText.text = (plasticCountTotal - (int)value).ToString() + "/" + plasticCountTotal.ToString();


            yield return null;
        }
        plasticCountText.text = (plasticCountCurrent).ToString();
        if (plasticCountCurrent == 0)
        {
            plasticCountTextArea.SetActive(false);
        }
    }

    IEnumerator SetIronAmount(int amount)
    {
        int Old = ironCountCurrent;
        ironCountCurrent += amount;
        PlayerPrefs.SetInt(currentIron, ironCountCurrent);
        if (ironCountCurrent == 0)
        {
            PlayerPrefs.SetInt(currentIron, -1);
        }
        ironSetActive = false;
        yield return null;
        yield return null;
        ironSetActive = true;
        float counter = 0f;
        while (counter < 1f && ironSetActive)
        {
            counter += 2 * Time.deltaTime / Mathf.PI;
            float value = Mathf.Lerp((float)Old, (float)ironCountCurrent, counter);
            ironCountText.text = ((int)value).ToString();
            //ironCountText.text = (ironCountTotal - (int)value).ToString() + "/" + ironCountTotal.ToString();

            yield return null;
        }
        ironCountText.text = (ironCountCurrent).ToString();
        if (ironCountCurrent == 0)
        {
            ironCountTextArea.SetActive(false);
        }
        //ironCountText.text = ironCountCurrent.ToString() + "/" + ironCountTotal.ToString();

    }
    IEnumerator OpenBuyCheck()
    {
        yield return new WaitForSeconds(1f);
        if((woodCountCurrent + plasticCountCurrent + ironCountCurrent) ==0)
        {
            VibratoManager.Instance.HeavyVibration();

            outline.fillAmount = 0;
            sellActive = false;
            StartCoroutine(buildScaling());

            GetComponent<Collider>().enabled = false;
            if (buyActive)
            {
                buildingManager.BuildCompleteCheck();
            }
        }
    }


    IEnumerator buildScaling()
    {
        isbuy = false;
        if (buyActive)
        {
            buildingManager.BuildOpen();
            if (PlayerPrefs.GetInt(buyName + PlayerPrefs.GetInt("level")) == 0)
            {
                buildingManager.OpenNewBuild();
            }
        }
        int buildChildCount = transform.childCount;
        for (int i = 0; i < buildChildCount; i++)
        {
            StartCoroutine(throughlyScaling(transform.GetChild(i).transform));
            yield return new WaitForSeconds(0.05f);
        }
        instantiateBuild();
    }
    IEnumerator throughlyScaling(Transform bld)
    {
        float counter = 1f;
        float lastSize = 0f;
        float sizeDelta;

        while (counter < 1f)
        {
            counter -= 15 * Time.deltaTime;

            bld.localScale = new Vector3(counter, counter, counter);
            yield return null;
        }
        bld.localScale = new Vector3(lastSize, lastSize, lastSize);
    }
    void instantiateBuild()
    {
        AvailableForPurchase.Instance.ListSet();
        Build _build = Instantiate(buildPrefab, transform.position, transform.rotation, transform.parent).GetComponent<Build>();
        _build.buildPositionTR = buildPosTR;
        PlayerPrefs.SetInt(buyName + PlayerPrefs.GetInt("level"), 1);
    }
}
