using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals 
{
    public static int currentLevel = 1;
    public static int currentLevelIndex = 0, LevelCount;
    public static int moneyAmount = 0;
    public static int gemAmount = 0;


    public static int holeRadiusLevel = 0;
    public static int holeSpeedLevel = 0;
    public static int holeTimeLevel = 0;


    public static int magnetRadiusLevel = 0;
    public static int characterSpeedLevel = 0;
    public static int stackCapacityLevel = 0;

    public static int workerMoveSpeedLevel = 0;
    public static int workerCapacityLevel = 0;
    public static int workerNoLevel = 0;

    public static int maxBuildLevel = 0;


    public static int holeLevel = 0;

    public static int collectCounter = 0;


    public static bool stackActive = false;
    public static bool playerStackActive = true;


    public static bool loadingPanelActive = true;

    //public static float levelFactor;

    public static float inLevelMoneyCount = 0;

    //public static float fishCountFactor = 1;
    public static bool showActive = false;
    public static bool bigFishAquariumActive = false;




    public static int envLevel = 0;
    public static bool envLevelUpActive = true;
    public static int extraCustomerCount_Electronics = 2;
    public static int extraCustomerCount_Sports = 2;
    public static int extraCustomerCount_Toys = 2;


    public static bool productType1 = false;
    public static bool productType2 = false;
    public static bool productType3 = false;
    public static bool productType4 = false;
    public static bool productType5 = false;


    public static float extraSpeed = 1f;
    public static int extraStack;

    public static float extraSpeedSkins = 1f;
    public static int extraStackSkin = 0;
    public static float extraMoneySkin = 0;
    public static float repairSpeedSkin = 1f;


    public static bool vipActive = false;



    public static bool doubleIncomeActive = false;
    public static bool holePlatformActive = false;


    public static bool popUpActive = false;


    public static int machineLevel = 0;


    public static int collectableLevel = 0;
    public static int carSlotCount = 0;
    public static int carCustomerCount = 1;

    public static bool vipCreateActive = false;

    public static bool isThereVip = false;
    public static bool buyActive = true;


    public static int myShareValue = 0;


    public static bool isSpeedRewardCreated = false;
    public static bool isCapacityRewardCreated = false;
    public static bool isDoubleIncomeRewardCreated = false;
    public static bool isMoneyRewardCreated = false;



    public static int speedPlayTime = 0;
    public static int capacityPlayTime = 0;
    public static int doubleIncomePlayTime = 0;
    public static int moneyPlayTime = 0;



    public static int speedCreatingCooldown = 0;
    public static int capacityCreatingCooldown = 0;
    public static int doubleCreatingCooldown = 0;
    public static int moneyCreatingCooldown = 0;


    public static int openedCarSlotCount = 0;

    public static bool machineErrorActive = false;
    public static bool machineErrorActivator = false;

    public static bool goToCeoActive = false;

}
