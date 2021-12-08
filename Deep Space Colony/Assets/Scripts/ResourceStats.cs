using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceStats : MonoBehaviour
{
    public int resourceTotal = 100;
    public bool rFood = false;
    public bool rWood = false;
    public bool rStone = false;
    public bool rMetal = false;
    public bool rFuel = false;
    public bool rSilicone = false;

    public PawnStats playerStats;


    private void Awake()
    {
        playerStats = FindObjectOfType<PawnStats>();
    }


    public void HarvestHit()
    {
        resourceTotal -= playerStats.harvestPerHit;
    }

    public void ResourceEmpty()
    {
        if(resourceTotal == 0)
        {
            //instantiate distruction object

            Destroy(gameObject);
        }
    }

}
