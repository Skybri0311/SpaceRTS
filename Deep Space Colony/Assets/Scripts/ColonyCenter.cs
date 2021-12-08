using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonyCenter : MonoBehaviour
{
    public int health;
    public int spawnQue;
    public int spawnQueMax;
    public int queCooldown;
    public bool isColonyCenter;

    public GameObject pawn;
    public GameObject spawnFlag;

    public PawnStats pawnStats;

    private void Awake()
    {
        pawnStats = FindObjectOfType<PawnStats>();
    }


    public void SpawnPawn()
    {
        spawnQue++; //create spawning cue
        //Wait for cooldown to spawn pawn
        Instantiate(pawn, transform.position, Quaternion.identity);//Instantiate pawn game object after a cooldown period
    }

    public void DecreaseQue()
    {
        if (spawnQue == 0) //If the que is empty, return
            return;
        spawnQue--; //Decrease the spawn que by 1
    }

    public void ClearQue()
    {
        spawnQue = 0; //clear spawn cue
    }

    public void Repair()
    {
        if (health == 100) //if building health is full, deactivate repair

            return;
        
        if (health < 100 && health > 0)
            health =+ pawnStats.buildingRepair;//add health to the building
    }

    public void TakeDamage()
    {
        health = -pawnStats.buildingDamage;//remove health from the building
        if (health == 0)
        {
            Destroy(gameObject);//if health is 0, destroy the gameobject and instantiate distruction object
           
        }
        //delete the distruction object after a period of time
    }


}
