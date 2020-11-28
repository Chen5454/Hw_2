using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


class Client:MonoBehaviour
{
     void Start()
    {
        Robot enemy = new Robot();
        enemy.Id = 1;

        Debug.Log("Enemy ID: " + enemy.Id.ToString());

        Enemy clonedEnemy = enemy.Clone() as Enemy;

        Debug.Log("Enemy Copy ID: " + clonedEnemy.Id.ToString());
    }
}
 


    class Robot : Enemy
    {
        public override Enemy Clone()
         {
             Debug.Log("Cloning enemy....");
             return this.MemberwiseClone() as Enemy;

         }

    }

    public abstract class Enemy
    {
        public abstract Enemy Clone();
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }




