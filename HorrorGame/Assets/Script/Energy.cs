using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    Player ThePlayer;
    bool HasEnergyKick = false;
    bool IsResistingDMG = false;
    float CurrentTime;
    float CurrentTime2;
    float OriginalPlayerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        ThePlayer = gameObject.GetComponent<Player>();
        OriginalPlayerSpeed = ThePlayer.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (HasEnergyKick)
        {
            CurrentTime-= Time.deltaTime;
            if(CurrentTime <= 0)
            {
                CurrentTime = 0;
                HasEnergyKick = false;
                ThePlayer.speed = OriginalPlayerSpeed;
            }


        }

        if (IsResistingDMG)
        {
            CurrentTime2 -= Time.deltaTime;
            if(CurrentTime2 <= 0)
            {
                CurrentTime2 = 0;
                IsResistingDMG = false;
                ThePlayer.SetIsResistingDMG(false, 0);
            }
        }


    }

    public void StartEnergyKick(float aTimeToReach, float aSpeedIncrease)
    {
        if(CurrentTime < 0)
        {
            CurrentTime = 0;
        }
        CurrentTime += aTimeToReach;
        HasEnergyKick = true;
        ThePlayer.speed += aSpeedIncrease;
    }
    public void DamageResTimerStart(float duration, float DMGRes)
    {
        if(CurrentTime2 < 0)
        {
            CurrentTime2 = 0;
        }
        CurrentTime2 += duration;
        IsResistingDMG = true;
        ThePlayer.SetIsResistingDMG(true, DMGRes);
    }
}
