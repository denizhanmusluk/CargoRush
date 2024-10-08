using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class MapManager : MonoBehaviour
{
    private static MapManager _instance = null;
    public static MapManager Instance => _instance;
    public GameObject panelGO;
    public List<Image> imageList = new List<Image>();
    public List<GameObject> mapList = new List<GameObject>();
    public List<Transform> needlePosListTR = new List<Transform>();

    [SerializeField] Slider loadBar;
    [SerializeField] float loadTime = 5f;
    [SerializeField] string[] textList;
    [SerializeField] TextMeshProUGUI loadingText;
    [SerializeField] Transform needleTR;
    [SerializeField] Color oldColor, newColor;

    public GameObject mapButton;

    [SerializeField] Image needleImage;
    public List<Sprite> levelIconList = new List<Sprite>();

    public GameObject nextButton;

    public GameObject mapTapTut_GO;
    public GameObject textTutorial_GO;
    private void Awake()
    {
        _instance = this;

        if (PlayerPrefs.GetInt("level") > PlayerPrefs.GetInt("mapindex"))
        {
            PlayerPrefs.SetInt("mapindex", PlayerPrefs.GetInt("level"));
            Globals.moneyAmount = 0;

            PlayerPrefs.SetInt("money", 0);
        }
        if(PlayerPrefs.GetInt("firstmoneyinit") == 0)
        {
            PlayerPrefs.SetInt("firstmoneyinit", 1);
            Globals.moneyAmount = 20;
            PlayerPrefs.SetInt("money", Globals.moneyAmount);

        }
        Globals.moneyAmount = PlayerPrefs.GetInt("money");
        MapButtonActive();

        if (PlayerPrefs.GetInt("mapbuttonopen") == 1)
        {
            MapButtonOpen();
        }
    }
    public void MapButtonOpen()
    {
        PlayerPrefs.SetInt("mapbuttonopen", 1);
        mapButton.SetActive(true);
    }
    public void MapButtonActive()
    {
        if(PlayerPrefs.GetInt("newworldactivation") > 0)
        {
            mapButton.SetActive(true);
            textTutorial_GO.SetActive(true);

        }
    }
    public void MapButtonClick()
    {
        OpenMap();
        AudioManager.Instance.ButtonSound();
        if (PlayerPrefs.GetInt("mapbuttonfirstclck") == 0)
        {
            PlayerPrefs.SetInt("mapbuttonfirstclck", 1);
        }

    }
    public void OpenMap()
    {
        StartCoroutine(OpenDelay());
        panelGO.SetActive(true);
        PlayerController.Instance.PlayerControlDeActive();
        //if (PlayerPrefs.GetInt("level") >= PlayerPrefs.GetInt("mapindex"))
        //{
        //    PlayerPrefs.SetInt("mapindex", PlayerPrefs.GetInt("level"));
        //    Globals.moneyAmount = 0;

        //    PlayerPrefs.SetInt("money", 0);
        //}
        for (int i = 0; i < PlayerPrefs.GetInt("mapindexmax"); i++)
        {
            mapList[i].SetActive(true);
            mapList[i].GetComponent<Image>().color = oldColor;
            imageList.Add(mapList[i].GetComponent<Image>());
        }
        mapList[PlayerPrefs.GetInt("level")].GetComponent<Button>().interactable = false;
    }
    IEnumerator OpenDelay()
    {
        //StartCoroutine(NeedleAnimation());

        yield return new WaitForSeconds(0.25f);

        needleTR.gameObject.SetActive(true);
        needleImage.sprite = levelIconList[PlayerPrefs.GetInt("prelevel")];
        Vector3 firstPos = needlePosListTR[PlayerPrefs.GetInt("prelevel")].position;
        Vector3 targetPos = needlePosListTR[PlayerPrefs.GetInt("level")].position;
        needleTR.position = firstPos;
        OpenScale(needleTR, 0.5f, 1f, 1f, Ease.OutElastic);

        yield return new WaitForSeconds(0.5f);

        mapList[PlayerPrefs.GetInt("mapindexmax")].SetActive(true);
        mapList[PlayerPrefs.GetInt("mapindexmax")].GetComponent<Image>().color = newColor;
        imageList.Add(mapList[PlayerPrefs.GetInt("mapindexmax")].GetComponent<Image>());
        OpenScale(mapList[PlayerPrefs.GetInt("mapindexmax")].transform, 0.5f, 1f, 1f, Ease.OutElastic);
        loadingText.text = textList[PlayerPrefs.GetInt("level")];
        //StartCoroutine(LoadingBar());
    }
    int _levelIndex = 0;
    public void NewLevelSelect(int levelIndex)
    {
        _levelIndex = levelIndex;
        nextButton.SetActive(true);
        StartCoroutine(NeedleAnimation(levelIndex));
        textTutorial_GO.SetActive(false);

        //StartCoroutine(New_Level_Select(levelIndex));
    }
    public void NextButtonClick()
    {
        nextButton.GetComponent<Button>().interactable = false;
        StartCoroutine(New_Level_Select());
        if (PlayerPrefs.GetInt("mapbuttonfirstclck") == 2)
        {
            PlayerPrefs.SetInt("mapbuttonfirstclck", 3);
            IndicatorManager.Instance.TutorialStepCompleted();
        }
    }
    IEnumerator New_Level_Select()
    {
  

    PlayerController.Instance.PlayerControlDeActive();
        yield return new WaitForSeconds(0.5f);
        Fade.Instance.Hide();
        yield return new WaitForSeconds(0.5f);

        //yield return new WaitForSeconds(0.5f);
        PlayerPrefs.SetInt("prelevel", _levelIndex);

        PlayerPrefs.SetInt("level", _levelIndex);
        Globals.currentLevelIndex = PlayerPrefs.GetInt("level");

        //PlayerPrefs.DeleteAll();

        Globals.collectableLevel = 0;
        Globals.isSpeedRewardCreated = false;
        Globals.isCapacityRewardCreated = false;
        Globals.isDoubleIncomeRewardCreated = false;
        Globals.isMoneyRewardCreated = false;

        Globals.machineErrorActive = false;
        Globals.machineErrorActivator = false;

        Globals.productType1 = false;
        Globals.productType2 = false;
        Globals.productType3 = false;
        Globals.productType4 = false;

        Globals.carSlotCount = 0;


        Globals.openedCarSlotCount = 0;
        ADVManager.Instance.HideBanner();
        GameManager.Instance.OnLevelRestart();
    }
    IEnumerator NeedleAnimation(int levelIndex)
    {

        //needleTR.gameObject.SetActive(true);
        Vector3 firstPos = needlePosListTR[PlayerPrefs.GetInt("prelevel")].position;
        Vector3 targetPos = needlePosListTR[levelIndex].position;
        needleTR.position = firstPos;
        OpenScale(needleTR, 0.5f, 1f, 0.5f, Ease.OutElastic);

        //yield return new WaitForSeconds(2f);
        needleTR.GetComponent<Animator>().SetTrigger("pin");
        float counter = 0f;

        while (counter < 1f)
        {
            counter += Time.deltaTime;
            needleTR.position = Vector3.Lerp(firstPos, targetPos, counter);
            yield return null;
        }
        needleImage.sprite = levelIconList[levelIndex];

    }

    IEnumerator LoadingBar()
    {
        float counter = 0f;
        while (counter < loadTime)
        {
            counter += Time.deltaTime;
            loadBar.value = counter / loadTime;
            yield return null;
        }
        loadingText.enabled = false;
        GameStart();
        StartCoroutine(PanelClose());
    }

    IEnumerator PanelClose()
    {
        float counter = 0;
        float SimulationSpeed = 1f;
        while (counter < 1f)
        {
            counter += SimulationSpeed * Time.deltaTime;

            foreach (var img in imageList)
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.Abs(1 - counter));
            }
            yield return null;
        }
        panelGO.SetActive(false);
    }

    void GameStart()
    {
        PlatformSwitchManager.Instance.SwitchToBottom();
    }


    public Tween OpenScale(Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Vector3 firstScale = prt.localScale;
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = firstScale * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }

    public void ClickCancel()
    {
        PlayerController.Instance.PlayerControl_ReActive();
    }
}
