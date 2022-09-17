using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = System.Object;

public class Manager : MonoBehaviour
{
   public Text ClicksTotalText;
   public float TotalClicks;
   public bool hasUpgrade1;
   public bool hasUpgrade2;
   public bool hasUpgrade3;
   public int autoClicksPerSecondUpgrade1;
   public int autoClicksPerSecondUpgrade2;
   public int autoClicksPerSecondUpgrade3;
   public int minimumClicksToUnlockUpgrade1;
   public int minimumClicksToUnlockUpgrade2;
   public int minimumClicksToUnlockUpgrade3;
   

   public void AddClicks()
   {
      TotalClicks++;
      ClicksTotalText.text = TotalClicks.ToString("0");
   }

   public void AutoClickUpgrade()
   {
      if (!hasUpgrade1 && TotalClicks >= minimumClicksToUnlockUpgrade1)
      {
         TotalClicks -= minimumClicksToUnlockUpgrade1;
         hasUpgrade1 = true;
      }
      if (!hasUpgrade2 && TotalClicks >= minimumClicksToUnlockUpgrade2)
      {
         TotalClicks -= minimumClicksToUnlockUpgrade2;
         hasUpgrade2 = true;
      }
      if (!hasUpgrade3 && TotalClicks >= minimumClicksToUnlockUpgrade3)
      {
         TotalClicks -= minimumClicksToUnlockUpgrade3;
         hasUpgrade3 = true;
      }
   }

   private void Update()
   {
      if (hasUpgrade1)
      {
         TotalClicks += autoClicksPerSecondUpgrade1 * Time.deltaTime;
         ClicksTotalText.text = TotalClicks.ToString("0");
         Destroy(GameObject.Find("Upgrade1"));
      }
      if (hasUpgrade2)
      {
         TotalClicks += autoClicksPerSecondUpgrade2 * Time.deltaTime;
         ClicksTotalText.text = TotalClicks.ToString("0");
         Destroy(GameObject.Find("Upgrade2"));
      }
      if (hasUpgrade3)
      {
         TotalClicks += autoClicksPerSecondUpgrade3 * Time.deltaTime;
         ClicksTotalText.text = TotalClicks.ToString("0");
         Destroy(GameObject.Find("Upgrade3"));
      }
   }
}
