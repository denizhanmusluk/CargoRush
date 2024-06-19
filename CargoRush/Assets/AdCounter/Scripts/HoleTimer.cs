using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ObserverSystem;
public class HoleTimer : Observer
{
    [SerializeField] HoleUpgradeSettings _holeUpgradeSettings;
    //[SerializeField] int time;
    //[SerializeField] Slider slider;
    public Image holeTimerBG_Image;
    public TextMeshProUGUI counterText;
   [SerializeField] Color targetColor;
    Color firstColor;
    //[SerializeField] Transform water;
    //[SerializeField] Transform waterSurface, waterDeep;

    //[SerializeField] Transform whirlpool;
    //[SerializeField] Transform whirlChild;
    //[SerializeField] Transform whirlpoolSurface, whirlpoolDeep;
    [SerializeField] GameObject holeGround;
    void Awake()
    {
       
    }
    private void Start()
    {
        //_holeUpgradeSettings = LevelManager.Instance._holeUpgradeSettings;
        counterText = GameManager.Instance.ui.holeTimer;
        holeTimerBG_Image = GameManager.Instance.ui.holeTimerBG_Image;
        //Initial();
        ObserverManager.Instance.RegisterObserver(this, SubjectType.GameState);//observer register
        firstColor = counterText.color;
    }

    public void Initial()
    {
        //water.position = new Vector3(water.position.x, waterSurface.position.y, water.position.z);
        //whirlpool.position = new Vector3(whirlpool.position.x, whirlpoolSurface.position.y, whirlpool.position.z);

        //whirlChild.localScale = whirlpoolSurface.localScale; 

        //foreach (Slider _slider in GetComponentsInChildren<Slider>())
        //{
        //    slider = _slider;
        //}
        //foreach (TextMeshProUGUI _text in GetComponentsInChildren<TextMeshProUGUI>())
        //{
        //    counterText = _text;
        //}
        int counter = _holeUpgradeSettings.holeTime[Globals.holeTimeLevel];

        //counterText.text = "00:" + ($"{counter}");
        //if (counter < 10)
        //{
        //    counterText.text = "00:0" + ($"{counter}");
        //}

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
            //if (counter <= 3)
            //{
            //    StartCoroutine(CounterTextColorSet());
            //    VibratoManager.Instance.LightVibration();
            //}
        }
    }
    public void CounterStart()
    {
       foreach(Fish fish in FishManager.Instance._fishList)
        {
            fish.currentBehaviour = Fish.States.searching;
            fish.FishMoveStart();
        }
        holeGround.SetActive(true);
        StartCoroutine(DigitalCounter());
        //StartCoroutine(FloatingCounter());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
    public int counter = 0;
    public bool clearActive = false;
    IEnumerator DigitalCounter()
    {
        clearActive = false;
        if (PlayerPrefs.GetInt("holetimefree") == 0)
        {
            PlayerPrefs.SetInt("holetimefree", 1);
            counter = 100;
            GameManager.Instance.ui.holeTimeGO.SetActive(false);
        }
        else
        {
            counter = _holeUpgradeSettings.holeTime[Globals.holeTimeLevel];
        }


        //while (counter > 0)
        //{
        //    counterText.text = "00:" + ($"{counter}");
        //    if(counter < 10)
        //    {
        //        counterText.text = "00:0" + ($"{counter}");
        //        if (counter <= 3)
        //        {
        //            StartCoroutine(CounterTextColorSet());
        //            VibratoManager.Instance.LightVibration();
        //        }
        //    }
        //    counter--;
        //    yield return new WaitForSeconds(1);
        //}


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

        FishManager.Instance.FishesStop();
        HoleController.Instance.HoleControlDeActive();
        if (!clearActive)
        {
            GameManager.Instance.ui.holeTimeGO.SetActive(true);
            PlatformSwitchManager.Instance.timeUpPanel.SetActive(true);
        }
        yield return new WaitForSeconds(1.5f);
        CameraManager.Instance.CameraFovUpView();
        yield return new WaitForSeconds(1f);
        Fade.Instance.Hide();
        yield return new WaitForSeconds(0.5f);
        PlatformSwitchManager.Instance.timeUpPanel.SetActive(false);
        PlatformSwitchManager.Instance.clearPanel.SetActive(false);
        CounterEnd();
        //SelfActive(false);
    }
    IEnumerator CounterTextColorSet()
    {
        float counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            value = (Mathf.Sin(Mathf.PI * counter));
            holeTimerBG_Image.color = Color.Lerp(firstColor, targetColor, value);
            //counterText.color = Color.Lerp(firstColor, targetColor, value);
            yield return null;
        } 
    }
    IEnumerator FloatingCounter()
    {
        float counter = 0;
        while (counter < _holeUpgradeSettings.holeTime[Globals.holeTimeLevel])
        {
            counter += Time.deltaTime;
            //water.position = Vector3.Lerp(new Vector3(water.position.x, waterSurface.position.y, water.position.z), new Vector3(water.position.x, waterDeep.position.y, water.position.z), (counter / (float)_holeUpgradeSettings.holeTime[Globals.holeTimeLevel]));
            //whirlpool.position = Vector3.Lerp(new Vector3(whirlpool.position.x, whirlpoolSurface.position.y, whirlpool.position.z), new Vector3(whirlpool.position.x, whirlpoolDeep.position.y, whirlpool.position.z), (counter / (float)_holeUpgradeSettings.holeTime[Globals.holeTimeLevel]));
            //whirlChild.localScale = Vector3.Lerp(whirlpoolSurface.localScale, whirlpoolDeep.localScale, (counter / (float)_holeUpgradeSettings.holeTime[Globals.holeTimeLevel])); // delik kuculme
            //slider.value = (1 - counter / (float)_holeUpgradeSettings.holeTime[Globals.holeTimeLevel]);
            yield return null;
        }
    }
    private void SelfActive(bool active)
    {
        this.gameObject.SetActive(active);
    }
    public void CounterEnd()
    {
        GameManager.Instance.ui.holeTimeGO.SetActive(false);
        holeGround.SetActive(false);
        PlatformSwitchManager.Instance.SwitchToBottom();
        DnzEvents.AIworkerStart();
        PlayerPrefs.SetInt("tryingcount", PlayerPrefs.GetInt("tryingcount") + 1);
    }




    public override void OnNotify(NotificationType notificationType) //observer notify
    {
        switch (notificationType)
        {
            case NotificationType.Start:
                {
                    //if (PlayerPrefs.GetInt("gameopened") == 0)
                    //{
                    //    CounterStart();
                    //}
                }
                break;
            case NotificationType.End:
                {

                }
                break;
            case NotificationType.Win:
                {

                }
                break;
            case NotificationType.Fail:
                {

                }
                break;

        }
    }
}
