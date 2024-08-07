using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public CharacterUpgradeSettings _characterUpgradeSettings;
    public StackCollect stackCollect;
    public int basStackCount;
    [SerializeField] GameObject fullTextGO;
    public bool playerActive;
    private void Start()
    {
        _characterUpgradeSettings = LevelManager.Instance._currnetCharacterUpgradeSettings;
        MagnetLevelUp();
        fullTextGO = GameManager.Instance.ui.fullCapacityText;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (playerActive && Globals.playerStackActive && other.GetComponent<Collectable>() != null && other.GetComponent<Collectable>().collectActive)
        {
            if (other.GetComponent<Collectable>().isGem)
            {
                other.GetComponent<Collectable>().CollectGem();
                VibratoManager.Instance.MediumVibration();
            }
            else
            {
                if (stackCollect.collectionTrs.Count < Globals.stackFactor  * _characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel] + Globals.extraStackSkin + Globals.extraStack)
                {
                    if(other.GetComponent<Collector>() != null)
                    {
                        //Destroy(other.GetComponent<Collector>().shadowGO);
                        other.GetComponent<Collector>().collectorActive = false;
                        other.GetComponent<Collector>().pushActive = false;

                        int layer = LayerMask.NameToLayer("stackedproduct");
                        other.gameObject.layer = layer;
                        //Destroy(other.GetComponent<Collector>());
                        if (other.GetComponent<Collector>().shadowGO != null)
                        {
                            Destroy(other.GetComponent<Collector>().shadowGO);
                        }
                    }
                    if (other.GetComponent<Rigidbody>() != null)
                    {
                        Destroy(other.GetComponent<Rigidbody>());
                    }
                    stackCollect.Collecting(other.GetComponent<Collectable>());
                    other.GetComponent<Collectable>().collectableList.Remove(other.GetComponent<Collectable>());
                    FishDropArea.Instance.proType[other.GetComponent<Collector>().productId].productList.Remove(other.GetComponent<Collectable>());
                    if (other.GetComponent<Collectable>().collectableList.Count == 0)
                    {
                        IndicatorManager.Instance.transUpIndActive = true;
                    }
                }
                //else
                //{
                    PlayerController.Instance._stackCollect.StackFullCheck();
                    //StartCoroutine(FullCapacity());
                //}
            }
        }


        if (!playerActive && Globals.stackActive && other.GetComponent<Collectable>() != null && other.GetComponent<Collectable>().collectActive)
        {
            if (!other.GetComponent<Collectable>().isGem && stackCollect.collectionTrs.Count < stackCollect.GetComponent<StackCollectWorker>().baseStackCapacity + _characterUpgradeSettings.workerCapacity[Globals.workerCapacityLevel])
            {
                if (other.GetComponent<Collector>() != null)
                {
                    //Destroy(other.GetComponent<Collector>().shadowGO);
                    other.GetComponent<Collector>().collectorActive = false;
                    other.GetComponent<Collector>().pushActive = false;
                    //Destroy(other.GetComponent<Collector>());
                    if (other.GetComponent<Collector>().shadowGO != null)
                    {
                        Destroy(other.GetComponent<Collector>().shadowGO);
                    }
                }
                if (other.GetComponent<Rigidbody>() != null)
                {
                    Destroy(other.GetComponent<Rigidbody>());
                }
                stackCollect.Collecting(other.GetComponent<Collectable>());
                other.GetComponent<Collectable>().collectableList.Remove(other.GetComponent<Collectable>());
                FishDropArea.Instance.proType[other.GetComponent<Collector>().productId].productList.Remove(other.GetComponent<Collectable>());
                if (other.GetComponent<Collectable>().collectableList.Count == 0)
                {
                    IndicatorManager.Instance.transUpIndActive = true;
                }
            }
        }
    }
    public void MagnetLevelUp()
    {
        transform.localScale = Vector3.one * _characterUpgradeSettings.magnetRadius[Globals.magnetRadiusLevel];
    }
    bool fullTextActive = false;
    IEnumerator FullCapacity()
    {
        fullTextGO.SetActive(true);
        fullTextActive = false;
        yield return null;
        yield return null;
        fullTextActive = true;
        float counter = 0f;
        while(counter < 2f && fullTextActive)
        {
            counter += Time.deltaTime;
            yield return null;
        }
        if(counter>= 2f)
        {
            fullTextGO.SetActive(false);
        }
    }
}
