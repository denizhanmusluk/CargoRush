using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CollectProgressManager : MonoBehaviour
{
    private static CollectProgressManager _instance = null;
    public static CollectProgressManager Instance => _instance;
    //[SerializeField] GameObject scoreCollectGO;
   [SerializeField] public GameObject levelProgressGO, raceProgressGO;
    [SerializeField] public GameObject carRatioPanel;
    // Start is called before the first frame update
    [SerializeField] GameObject playerCrown, aiCrown;
    public Slider playerProgressSlider;
    public Slider aiProgressSlider;





    public Slider collectProgressSlider;
    //[SerializeField] TextMeshProUGUI collectCountText;
    //[SerializeField] TextMeshProUGUI scoreCollectCountText;
    [SerializeField] TextMeshProUGUI tryingCountText;

    [SerializeField] TextMeshProUGUI carRatioText;

    //public int totalEnvValue;
    //[SerializeField] int currentEnvValue= 0;
    [SerializeField] int currentEnvCount= 0;


    public int totalEnvCount;
    [SerializeField] int currentCollectCount = 0;
    public bool raceActive = true;
    public Image carLogo;

    public GameObject shopProgresGO;
    public Image shopProgresFill;
    public Image shopProgresFillBG;
    public Image shopFirstIcon, shopTargetIcon;
    public GameObject questMarkImgGO;


    public Image errorFill;
    public GameObject dirtyProgressPanelGo;
    public GameObject dirtyProgressPanelBGGo;
    public GameObject dirtyActiveImgGO;
    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
   
        tryingCountText.text = "STAGE: " + (PlayerPrefs.GetInt("envlevel") + 1).ToString();
        collectProgressSlider.value = 0;
        //scoreCollectCountText.text = PlayerPrefs.GetInt("scorecollect").ToString();
    }

    public void CollectEnvCountSet()
    {
        currentCollectCount++;
        //collectCountText.text = currentCollectCount.ToString();

        if (PlayerPrefs.GetInt("scorecollect") < currentCollectCount)
        {
            //scoreCollectCountText.text = currentCollectCount.ToString();
            PlayerPrefs.SetInt("scorecollect", currentCollectCount);
        }
    }
    public void CollectEnvSliderSet(int currentEnvCount, int totalEnvCount)
    {
        collectProgressSlider.value = (float)currentEnvCount / (float)totalEnvCount;
        if(currentEnvCount >= totalEnvCount)
        {
            PlatformSwitchManager.Instance.clearPanel.SetActive(true);
            HoleManager.Instance._holeTimer.clearActive = true;

            HoleManager.Instance.confetti.Play();
            if ( HoleManager.Instance._holeTimer.counter > 2)
            {
                HoleManager.Instance._holeTimer.counter = 2;
            }

        }
    }
    public void HoleStart()
    {
        levelProgressGO.SetActive(true);
        collectProgressSlider.value = 0;
        tryingCountText.text = "STAGE: " + (PlayerPrefs.GetInt("envlevel") + 1).ToString();

    }
    public void HoleEnd()
    {
        levelProgressGO.SetActive(false);
    }
    //public void RaceActive()
    //{
    //    raceProgressGO.SetActive(true);
    //    carRatioPanel.SetActive(false);
        
    //}
    //public void Car_RatioClose()
    //{
    //    StartCoroutine(CarRatioClose());
    //}

    //IEnumerator CarRatioClose()
    //{

    //    carRatioPanel.GetComponent<Animator>().SetTrigger("close");
    //    yield return new WaitForSeconds(2f);
    //    carRatioPanel.SetActive(false);
    //}
    //public void PlayerProgressSet(float value, float maxValue)
    //{
    //    playerProgressSlider.value = value / maxValue;

    //    if (raceActive)
    //    {
    //        if (playerProgressSlider.value > aiProgressSlider.value)
    //        {
    //            playerCrown.SetActive(true);
    //            aiCrown.SetActive(false);
    //        }

    //        if (playerProgressSlider.value < aiProgressSlider.value)
    //        {
    //            playerCrown.SetActive(false);
    //            aiCrown.SetActive(true);
    //        }
    //    }
    //}
    //public void AIProgressSet(float value , float maxValue)
    //{
    //    aiProgressSlider.value = value / maxValue;
    //}
    //public void CarRatioTextInit(int partCount)
    //{
    //    float ratio = ((float)partCount / (float)totalEnvCount) * 100;
    //    float roundedFloat = Mathf.Round(ratio * 10f) / 10f;

    //    carRatioText.text = "%" + roundedFloat.ToString();
    //}
}
