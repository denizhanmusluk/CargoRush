using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneySkill : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI viewCounterText;
    [SerializeField] TextMeshProUGUI moneyValueText;
    public int moneyValue;
    [SerializeField] int viewTime;
    int viewTimeCounter = 0;
    bool collectActive = true;
    [SerializeField] GameObject cicrcle;
    [SerializeField] GameObject particleGO;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && collectActive)
        {
            cicrcle.SetActive(false);
            collectActive = false;
            particleGO.SetActive(true);
            particleGO.transform.parent = null;
            PopUpManager.Instance.BoostPopUpOpen(3);
            PopUpManager.Instance.BoosterInvoke();
            gameObject.SetActive(false);
            PlayerController.Instance.PlayerControlDeActive();
            PopUpManager.Instance.freeMoneyValue = moneyValue;
            PopUpManager.Instance.moneyText.text = "$" + CoefficientTransformation.Converter(moneyValue);

        }
    }

    private void Start()
    {

        StartCoroutine(ViewCounter());
    }
    public void ValueInit()
    {
        moneyValueText.text = "$" + CoefficientTransformation.Converter(moneyValue);
    }
    IEnumerator ViewCounter()
    {
        while (viewTimeCounter < viewTime)
        {
            viewTimeCounter++;
            viewCounterText.text = ConvertSecondToMinSec.Converter(viewTime - viewTimeCounter);
            yield return new WaitForSeconds(1f);
        }
        Globals.isCapacityRewardCreated = false;
        Destroy(gameObject);
    }
}
