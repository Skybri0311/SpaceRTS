using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnStats : MonoBehaviour
{
    public int health = 100;
    public int unitDamage = 10;
    public int buildingDamage = 5;
    public int buildingRepair = 10;
    public int harvestPerHit = 10;
    public int resourceCap = 50;
    public int resourceCurrent;
    public int movementSpeed = 2;
    private bool rWood = false;
    private bool rStone = false;
    private bool rMetal = false;
    private bool rFuel = false;
    public bool rSilicone = false;

    public ResourceStats resourceStats;

    private void Awake()
    {
        resourceStats = FindObjectOfType<ResourceStats>();
    }

    public void HarvestResource()
    {
        if (resourceStats.rWood == true)
            rWood = true;
        if (resourceStats.rStone == true)
            rStone = true;
        if (resourceStats.rMetal == true)
            rMetal = true;
        if (resourceStats.rFuel == true)
            rFuel = true;
        if (resourceStats.rSilicone == true)
            rSilicone = true;

        resourceCurrent += harvestPerHit;
    }

    public void EmptyResource()
    {
        resourceCurrent -= resourceCurrent;
    }

    public void PickUpResource()
    {
        if (resourceCurrent == resourceCap)
        {
            Debug.Log("Inventory Full");
        }
        else
        {
            resourceCurrent += harvestPerHit;
        }
    }

    public void DealDamage()
    {
        

    }

    public void Heal()
    {

    }

    public void Die()
    {

    }
}
