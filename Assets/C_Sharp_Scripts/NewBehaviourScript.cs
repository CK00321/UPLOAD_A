using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
        
        Debug.Log("Perpare_for_battle!");
      
        //  Variable_For_Conditions_Scripts  //
        /** 
         
        *Current_Health
        *Maximum_Health
        *Mana
        *Spell_Cost
        * 
        **/
   
        int Current_Health = 75;
        int Maximum_Health = 100;
 

        //  Percentage_Equation_To_Get_75%_0f_Maximum_Health  //
        int Formula = Current_Health * Maximum_Health / 100;

        //  Condition_For_Battle  // 
        if (Formula == 75)
        {
            //  Message_For_Battle  //
            Debug.Log("Ready_For_Battle");
        }
        else
        {
            //  Message_For_Not_Battle  //
            Debug.Log("Not_Ready_Battle");
        }

        int Mana = 20;
        int Spell_Cost = 40;
        
        //  Condition_To_Cast_Mana_Spell  //
        if (Mana <= Spell_Cost)
        {
            //  Message_For_Battle  //
            Debug.Log("Ready_For_Battle");
        }
        else
        {
            //  Message_For_Not_Battle  //
            Debug.Log("Not_Ready_Battle");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
