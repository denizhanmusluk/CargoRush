using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using Global;

public class PopularPanelManager : MonoBehaviour
{
    public static PopularPanelManager Instance;
    [SerializeField] List<Button> popularButtons;
    [SerializeField] List<Image> fillImage;
    [SerializeField] GameObject fillImagePanel;
    [SerializeField] GameObject fillImagePoint;
    [SerializeField] TextMeshProUGUI ratioText;
    [SerializeField] int fillFactorImage;
    [SerializeField] GameObject claimButtonAdv;
    [SerializeField] GameObject loseButton;
    [SerializeField] GameObject fxParticle;
    [SerializeField] GameObject fxParticlePoint;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void Start()
    {
        fillImagePanel.SetActive(false);
        claimButtonAdv.SetActive(false);
        loseButton.SetActive(false);

        for (int i = 0; i < popularButtons.Count; i++)
        {
            if (popularButtons[i].interactable)
            {
                popularButtons[i].transform.parent.GetComponent<Image>().enabled = false;
            }
        }
        if (PlayerPrefs.GetInt("category") == 1)
        {
            popularButtons[PlayerPrefs.GetInt("popularmodel")].transform.parent.GetComponent<Image>().enabled = true;
        }
    }
    public void claimButtonAd()
    {
        //GameManager.Rewarded_Event += claimAdv;
        //GameManager.Instance.CliamButtonStartRewarded();
        claimAdv(); // temp
    }
    public void claimAdv()
    {
        fillImagePanel.SetActive(false);



        int index = 0;
        //index = Globals.currentLevelIndex / fillFactorImage;

        PlayerPrefs.SetInt("popularbutton" + index, 1);
        //GameManager.Instance.scorePanelActive(); ////////

        StoreManager.Instance.StoreButton();
        StoreManager.Instance.popularButton();
        buttonActivation(popularButtons[index], true);


        PlayerPrefs.SetInt("popularmodel", index);
        PlayerPrefs.SetInt("category", 1);

        //FindObjectOfType<playerCreator>().creatPlayer();

        selectCheckButton(popularButtons[index]);
    }
    public void loseitButton()
    {
        fillImagePanel.SetActive(false);
        //GameManager.Instance.scorePanelActive(); ////////
    }
    public void openModelImage()
    {

        //GameManager.Interstitial_Event += advFunction;
        //GameManager.Instance.LevelEndStartInterstitial();
        advFunction(); //temp

    }
    public void advFunction()
    {
        int levelIndex = 0;
        //levelIndex = Globals.currentLevelIndex;
        fillImagePanel.SetActive(true);
        int ind = 0;
        int ind2 = 0;
        if (levelIndex < 3)
        {
            ind = levelIndex / fillFactorImage;
            ind2 = levelIndex % fillFactorImage;
        }
        else
        {
            fillFactorImage = 5;
            ind = (levelIndex + 2) / fillFactorImage;
            ind2 = (levelIndex + 2) % fillFactorImage;
        }
        var modelPng = Instantiate(fillImage[ind], fillImagePoint.transform.position, Quaternion.identity, fillImagePoint.transform);
        //Globals.day = ind + 1;

        ImageFill(modelPng.transform.GetChild(0).GetComponent<Image>(), ind2);
    }
    public void ImageFill(Image img, int oldRatio)
    {
  
        int newRatio = oldRatio + 1;
        LeanTween.value(oldRatio, newRatio, 2f).setOnUpdate((float val) =>
        {
            img.fillAmount = ((float)val) / fillFactorImage;
            int ratio = (int)(((float)val) / fillFactorImage * 100);
            ratioText.text = ratio.ToString() + " %";
        });

       

        StartCoroutine(setImageFill(img));
    }
    IEnumerator setImageFill(Image img)
    {
        int levelIndex = 0;
        //levelIndex = Globals.currentLevelIndex;
        int factor = 0;
        if (levelIndex >= 3)
        {
            factor = 2;
        }
        yield return new WaitForSeconds(2f);
        if ((levelIndex + factor) % fillFactorImage != fillFactorImage - 1)
        {
            yield return new WaitForSeconds(1f);
            fillImagePanel.SetActive(false);
            //GameManager.Instance.scorePanelActive(); ////////

        }
        else
        {
            img.enabled = false;
            img.transform.parent.GetComponent<Image>().enabled = false;
            img.transform.GetChild(0).GetComponent<Image>().enabled = true;
            Instantiate(fxParticle, fxParticlePoint.transform.position, Quaternion.identity, fxParticlePoint.transform);

             yield return new WaitForSeconds(1f);
            claimButtonAdv.SetActive(true);

            yield return new WaitForSeconds(2f);
            loseButton.SetActive(true);
        }
    }


    public void button1()
    {
        PlayerPrefs.SetInt("popularmodel", 0);
        PlayerPrefs.SetInt("category", 1);

        createModel();

        selectCheckButton(popularButtons[0]);
    }
    public void button2()
    {
        PlayerPrefs.SetInt("popularmodel", 1);
        PlayerPrefs.SetInt("category", 1);

        createModel();

        selectCheckButton(popularButtons[1]);

    }
    public void button3()
    {
        PlayerPrefs.SetInt("popularmodel", 2);
        PlayerPrefs.SetInt("category", 1);

        createModel();

        selectCheckButton(popularButtons[2]);

    }
    public void button4()
    {
        PlayerPrefs.SetInt("popularmodel", 3);
        PlayerPrefs.SetInt("category", 1);

        createModel();
        selectCheckButton(popularButtons[3]);

    }
    public void button5()
    {
        PlayerPrefs.SetInt("popularmodel", 4);
        PlayerPrefs.SetInt("category", 1);

        createModel();

        selectCheckButton(popularButtons[4]);

    }
    public void button6()
    {
        PlayerPrefs.SetInt("popularmodel", 5);
        PlayerPrefs.SetInt("category", 1);

        createModel();
        selectCheckButton(popularButtons[5]);

    }
    void createModel()
    {
        ModelSelector.Instance.CreatePlayer();
        //PlayerBehaviour.Instance.playerController.CharacterUpgrade(Globals.knifeLevel);
    }
    public void buttonActivation(Button button, bool active)
    {
        button.interactable = active;
        button.transform.GetChild(0).gameObject.SetActive(!active);
        button.transform.GetChild(1).gameObject.SetActive(active);
    }

    void selectCheckButton(Button button)
    {
        for (int i = 0; i < popularButtons.Count; i++)
        {
            if (popularButtons[i].interactable)
            {
                popularButtons[i].transform.parent.GetComponent<Image>().enabled = false;
            }
        }
        if (PlayerPrefs.GetInt("category") == 1)
        {
            button.transform.parent.GetComponent<Image>().enabled = true;
        }



        NewPanelManager.Instance.Start();
        StarPanelManager.Instance.Start();
    }



    public void popularPAnelActive()
    {
        checkButtons();
    }
    void checkButtons()
    {
        int j = 0;
        for (int i = 0; i < popularButtons.Count; i++)
        {
            if (PlayerPrefs.GetInt("popularbutton" + i) == 1)
            {
                j++;
                buttonActivation(popularButtons[i], true);
            }
            else
            {
                buttonActivation(popularButtons[i], false);

            }
        }

        for (int i = 0; i < popularButtons.Count; i++)
        {
            if (popularButtons[i].interactable)
            {
                popularButtons[i].transform.parent.GetComponent<Image>().enabled = false;
            }
        }
        if (PlayerPrefs.GetInt("category") == 1)
        {

            popularButtons[PlayerPrefs.GetInt("popularmodel")].transform.parent.GetComponent<Image>().enabled = true;
        }
    }
}
