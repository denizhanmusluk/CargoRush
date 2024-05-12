using System;
using UnityEngine;

public class DnzEvents : MonoBehaviour
{
    public static event Action GameStart, GameUpdate, GameFixedUpdate, GameTimeOut, GameSuccess, GameFail, EnemyStart, TyreSkid, TyreSmoke, EndTyreSkid, aiWorkerStart, aiWorkerStop, aiWorkerListReset;

    private void Awake() => ResetEvents();
    public void ResetEvents()
    {
        GameStart = null;
        GameUpdate = null;
        GameTimeOut = null;
        GameSuccess = null;
        GameFail = null;
        EnemyStart = null;
        TyreSkid = null;
        TyreSmoke = null;
        EndTyreSkid = null;
        aiWorkerStart = null;
        aiWorkerStop = null;
        aiWorkerListReset = null;
        Debug.Log("ResetEvent");
    }
    public static void AIworkerStop() => aiWorkerStop?.Invoke();
    public static void AIworkerStart() => aiWorkerStart?.Invoke();
    public static void AiWorkerResetList() => aiWorkerListReset?.Invoke();
    public static void GameStartEvent() => GameStart?.Invoke();
    private void Update() => GameUpdate?.Invoke();
    private void FixedUpdate() => GameFixedUpdate?.Invoke();
    public static void GameSuccessEvent() => GameSuccess?.Invoke();
    public static void GameTimeOutEvent() => GameTimeOut?.Invoke();
    public static void GameFailEvent() => GameFail?.Invoke();
    public static void StartEnemyEvent() => EnemyStart?.Invoke();

    //public static void TyreSkidEvent() => TyreSkid?.Invoke();
    //public static void EndTyreSkidEvent() => EndTyreSkid?.Invoke();
    //public static void TyreSmokeEvent() => TyreSmoke?.Invoke();

}
