using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Global;

public class ModelSelector : MonoBehaviour
{
    public static ModelSelector Instance;
    [SerializeField] ModelScriptable playerModels;
    [SerializeField] Transform modelCreatePoint;


    public Transform createPointUI;
    public GameObject particlePrefab;
    public Transform particlePoint;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        //CreatePlayer();
    }

    // Update is called once per frame
    public void CreatePlayer()
    {
        if (modelCreatePoint.childCount > 0)
        {
            Destroy(modelCreatePoint.GetChild(0).gameObject);
        }

        //if (createPos2.childCount > 0)
        //{
        //    Destroy(createPos2.GetChild(0).gameObject);
        //}

        SelectPlayer();
    }
    public void CreatePlayerUI()
    {
        if (createPointUI.childCount > 0)
        {
            Destroy(createPointUI.GetChild(0).gameObject);
        }

        //if (createPos2.childCount > 0)
        //{
        //    Destroy(createPos2.GetChild(0).gameObject);
        //}

        SelectPlayerUI();
    }
    void SelectPlayer()
    {
        if(playerModels._newModels.Length > 0)
        {
            var model = Instantiate(playerModels._newModels[PlayerPrefs.GetInt("starmodel")], transform.position, Quaternion.identity);
            PlayerController.Instance.CharacterSelect(model);

            var UIParticle = Instantiate(particlePrefab, particlePoint.position + new Vector3(0, 1, 0), Quaternion.identity, particlePoint);
            Destroy(UIParticle, 2);
            foreach (var trnsfrm in UIParticle.GetComponentsInChildren<Transform>())
            {
                trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            }
        }
    }
    void SelectPlayerUI()
    {
        if (playerModels._newModels.Length > 0)
        {
            Vector3 UIPosOffset = new Vector3(-0f, 0f, 0f);
            var UImodel1 = Instantiate(playerModels._newModels[StarPanelManager.Instance.currentViewSkinID], createPointUI.position, createPointUI.rotation, createPointUI);
            Destroy(UImodel1.GetComponent<Player>());
            UImodel1.transform.localPosition = UIPosOffset;
            foreach (var trnsfrm in UImodel1.GetComponentsInChildren<Transform>())
            {
                trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            }
           
        }
    }
    public void FirstOpenPlayerUI()
    {
        if (playerModels._newModels.Length > 0)
        {
            Vector3 UIPosOffset = new Vector3(-0f, 0f, 0f);
            var UImodel1 = Instantiate(playerModels._newModels[PlayerPrefs.GetInt("starmodel")], createPointUI.position, createPointUI.rotation, createPointUI);
            Destroy(UImodel1.GetComponent<Player>());
            UImodel1.transform.localPosition = UIPosOffset;
            foreach (var trnsfrm in UImodel1.GetComponentsInChildren<Transform>())
            {
                trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            }
            var UIParticle = Instantiate(particlePrefab, particlePoint.position + new Vector3(0, 1, 0), Quaternion.identity, particlePoint);
            Destroy(UIParticle, 2);
            foreach (var trnsfrm in UIParticle.GetComponentsInChildren<Transform>())
            {
                trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            }
        }
    }
    void SelectCategory()
    {
        if (PlayerPrefs.GetInt("category") == 0 && playerModels._newModels.Length > 0)
        {
            Vector3 UIPosOffset = new Vector3(-0f, 0f, 0f);
            var model = Instantiate(playerModels._newModels[PlayerPrefs.GetInt("starmodel")], transform.position, Quaternion.identity);
            var UImodel1 = Instantiate(playerModels._newModels[PlayerPrefs.GetInt("starmodel")], createPointUI.position, createPointUI.rotation, createPointUI);
            Destroy(UImodel1.GetComponent<Player>());
            //var knifeModelR = Instantiate(playerModels._knifeModels[Globals.knifeLevel], UImodel1.GetComponent<HandModel>().knifePosR_TR.position, UImodel1.GetComponent<HandModel>().knifePosR_TR.rotation, UImodel1.GetComponent<HandModel>().knifePosR_TR);

            UImodel1.transform.localPosition = UIPosOffset;
            ////var UImodel2 = Instantiate(playerModels._newModels[PlayerPrefs.GetInt("newmodel")], createPos2.position, Quaternion.identity, createPos2);
            foreach (var trnsfrm in UImodel1.GetComponentsInChildren<Transform>())
            {
                trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            }
            //foreach (var trnsfrm in UImodel2.GetComponentsInChildren<Transform>())
            //{
            //    trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");

            //}
            var UIParticle = Instantiate(particlePrefab, particlePoint.position + new Vector3(0, 1, 0), Quaternion.identity, particlePoint);
            Destroy(UIParticle, 2);
            foreach (var trnsfrm in UIParticle.GetComponentsInChildren<Transform>())
            {
                trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            }

            PlayerController.Instance.CharacterSelect(model);

        }





        if (PlayerPrefs.GetInt("category") == 1 && playerModels._popularModels.Length > 0)
        {
            var model = Instantiate(playerModels._newModels[PlayerPrefs.GetInt("popularmodel")], transform.position, Quaternion.identity);
            var UImodel1 = Instantiate(playerModels._popularModels[PlayerPrefs.GetInt("popularmodel")], createPointUI.position, Quaternion.identity, createPointUI);
            Destroy(UImodel1.GetComponent<Player>());

            //var UImodel2 = Instantiate(playerModels._popularModels[PlayerPrefs.GetInt("popularmodel")], createPos2.position, Quaternion.identity, createPos2);
            foreach (var trnsfrm in UImodel1.GetComponentsInChildren<Transform>())
            {
                trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            }
            //foreach (var trnsfrm in UImodel2.GetComponentsInChildren<Transform>())
            //{
            //    trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");

            //}
            var UIParticle = Instantiate(particlePrefab, particlePoint.position + new Vector3(0, 1, 0), Quaternion.identity, particlePoint);
            Destroy(UIParticle, 2);
            foreach (var trnsfrm in UIParticle.GetComponentsInChildren<Transform>())
            {
                trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            }
            PlayerController.Instance.CharacterSelect(model);

        }


        if (PlayerPrefs.GetInt("category") == 2 && playerModels._starModels.Length > 0)
        {
            //var model = Instantiate(playerModels._starModels[PlayerPrefs.GetInt("starmodel")], modelCreatePoint.position, Quaternion.identity, modelCreatePoint);
            //var UImodel1 = Instantiate(playerModels._starModels[PlayerPrefs.GetInt("starmodel")], createPointUI.position, Quaternion.identity, createPointUI);
            //Destroy(UImodel1.GetComponent<Player>());

            //var UImodel2 = Instantiate(playerModels._starModels[PlayerPrefs.GetInt("starmodel")], createPos2.position, Quaternion.identity, createPos2);
            //foreach (var trnsfrm in UImodel1.GetComponentsInChildren<Transform>())
            //{
            //    trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            //}
            //foreach (var trnsfrm in UImodel2.GetComponentsInChildren<Transform>())
            //{
            //    trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");

            //}
            var UIParticle = Instantiate(particlePrefab, particlePoint.position + new Vector3(0, 1, 0), Quaternion.identity, particlePoint);
            Destroy(UIParticle, 2);
            foreach (var trnsfrm in UIParticle.GetComponentsInChildren<Transform>())
            {
                trnsfrm.gameObject.layer = LayerMask.NameToLayer("UICamera");
            }
        }
    }
}
