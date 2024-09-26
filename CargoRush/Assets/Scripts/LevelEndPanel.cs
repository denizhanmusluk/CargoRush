using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class LevelEndPanel : MonoBehaviour
{
    private static LevelEndPanel _instance = null;
    public static LevelEndPanel Instance => _instance;

    [SerializeField] GameObject panelGO;
    [SerializeField] GameObject imageWon,imageLost;
    [SerializeField] TextMeshProUGUI earningMoneyText;
    [SerializeField] TextMeshProUGUI arrangementText;
    [SerializeField] GameObject moneyIconPrefab;
    [SerializeField] Transform moneyIconFirstPos, moneyIconLastPos;
    [SerializeField] GameObject tryAgainButton, nextLevelButton;

    int _arrangement;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        Globals.inLevelMoneyCount = 0;
        tryAgainButton.SetActive(false);
        nextLevelButton.SetActive(false);
    }
    public void LevelEndPanelOpen(int arrangement, float carRatio)
    {
        _arrangement = arrangement;
        Globals.inLevelMoneyCount = (int)((float)Globals.inLevelMoneyCount * (1f + carRatio));
        panelGO.SetActive(true);
        GameManager.Instance.ui.ingameCanvas.SetActive(true);
        earningMoneyText.text = ((int)Globals.inLevelMoneyCount).ToString();
        //arrangementText.text = "You " + arrangement.ToString() + "th";
        if(arrangement == 1)
        {
            imageWon.SetActive(true);
            imageLost.SetActive(false);
        }
        if (arrangement == 2)
        {
            imageWon.SetActive(false);
            imageLost.SetActive(true);
        }
        StartCoroutine(LevelEndPanelOpenDelay());

    }
    IEnumerator LevelEndPanelOpenDelay()
    {
        yield return new WaitForSeconds(2f);
        //GameManager.Instance.MoneyUpdate((int)Globals.inLevelMoneyCount);
        StartCoroutine(SetMoneyValue((int)Globals.inLevelMoneyCount));
        StartCoroutine(SetMoneyUI());
    }
    IEnumerator SetMoneyValue(int amount)
    {
        float counter = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            float money = Mathf.Lerp(amount, 0, counter);
            //earningMoneyText.text = ((int)money).ToString();


            yield return null;
        }
        //earningMoneyText.text = (0).ToString();

        if (_arrangement == 1)
        {
            nextLevelButton.SetActive(true);
        }
        if (_arrangement == 2)
        {
            tryAgainButton.SetActive(true);
        }

    }
    IEnumerator SetMoneyUI()
    {
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 0.1f;
            StartCoroutine(UIMoneyIconSpawnAndGo());
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator UIMoneyIconSpawnAndGo()
    {
        GameObject mny = Instantiate(moneyIconPrefab, moneyIconFirstPos.position, Quaternion.identity,transform);

        float counter = 0f;
        while(counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            mny.transform.position = Vector3.Lerp(moneyIconFirstPos.position, moneyIconLastPos.position, counter);
            yield return null;
        }
        Destroy(mny);
        MoneyScale(1f * Vector3.one, moneyIconLastPos, 0.7f, 1f, 0.25f, Ease.OutElastic);

    }
    public Tween MoneyScale(Vector3 _firstScale, Transform prt, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                prt.localScale = _firstScale * value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
}
