using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Subscribe
{
    public static List<Observer> sub = new List<Observer>();

    public static void NotifySub(string msg){
        foreach (Observer s in sub){
            s.Notify(msg);
        }
    }

    public static void Subscribers(Observer obs){
        sub.Add(obs);
    }
}
