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
    public Animator moneyBagAnimator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null && collectActive)
        {
            moneyBagAnimator.SetTrigger("open");
            cicrcle.SetActive(false);
            collectActive = false;
            particleGO.SetActive(true);
            particleGO.transform.parent = null;
       
            PlayerController.Instance.PlayerControlDeActive();
            PopUpManager.Instance.freeMoneyValue = moneyValue;
            PopUpManager.Instance.moneyText.text = "$" + CoefficientTransformation.Converter(moneyValue);
            StartCoroutine(OpenBag());

        }
    }
    IEnumerator OpenBag()
    {
        yield return new WaitForSeconds(2f);
        PopUpManager.Instance.BoostPopUpOpen(3);
        PopUpManager.Instance.BoosterInvoke();
        gameObject.SetActive(false);
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
        Globals.isMoneyRewardCreated = false;
        Destroy(gameObject);
    }
}
