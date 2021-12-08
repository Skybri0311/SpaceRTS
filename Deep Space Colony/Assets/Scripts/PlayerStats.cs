using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    #region Unit Values
    public int pPop; //Pawn population
    public int pMax; //Pawn population max
    public int mpPop; //Military Pawn population
    public int mpMax; //Military Pawn population max
    public int hPop; //Healer Pawn population
    public int hMax; //Healer Pawn population max
    public int hvPop; //Harvest vehicle population
    public int hvMax; //Harvest vehicle population max
    public int tvrPop; //Transport resources vehicle population
    public int tvrMax; //Transport resources vehicle population max
    public int tvmPop; //Transport military pawn vehicle population max
    public int tvmMax; //Transport military pawn vehicle population max
    public int mvPop; //Military vehicle population
    public int mvMax; //Military vehicle population max
    #endregion

    #region Resource Values
    public int rFood; //Current food amount
    public int rFoodMax; //Max food amount
    public int rWood; //Current wood amount
    public int rWoodMax; //Max wood amount
    public int rStone; //Current stone amount
    public int rStoneMax; //Max stoneamount
    public int rMetal; //Current metal amount
    public int rMetalMax; //Max metal amount
    public int rFuel; //Current fuel amount
    public int rFuelMax; //Max fuel amount
    public int rSilicone; //Current silicone amount
    public int rSiliconeMax; //Max silicone amount
    public int rPower; //Current power amount
    public int rPowerMax; //Max power amount
    #endregion

    #region Building Values
    public int bHouse; //Current number of pawn houses
    public int bHouseMax; //Max number of pawn houses
    public int bBarracs; //Current number of barracs
    public int bStorage; //Current number of storage buildings
    public int bFactory; //Current number of factories
    public int bPowerStation; //Current number of power stations
    public int bBattery; //Current number of batteries
    public int bHospital; //Current number of hospitals
    public int bHospitalMax; //Max number of hospitals 
    #endregion

    #region Player Controls
    #endregion
}
