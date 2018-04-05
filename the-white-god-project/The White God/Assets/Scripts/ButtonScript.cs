using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

    private void Update()
    {
        
    }

    public void PoliceLetter()
    {
        TextControlScript.instance.ChangeText(1);
    }

    public void PoliceList()
    {
        TextControlScript.instance.ChangeText(2);
    }

    public void Neither()
    {
        ObjectColliderScript.instance.Unpause(1);
    }

    public void ChurchFlyer()
    {
        TextControlScript.instance.ChangeText(3);
    }

    public void MayoralRace()
    {
        TextControlScript.instance.ChangeText(4);
    }

    public void WantedPoster()
    {
        TextControlScript.instance.ChangeText(5);
    }

    public void Notice()
    {
        TextControlScript.instance.ChangeText(6);
    }

    public void None()
    {
        ObjectColliderScript.instance.Unpause(2);
    }

    public void DorisYes()
    {
        TextControlScript.instance.ChangeText(8);
    }

    public void DorisNo()
    {
        ObjectColliderScript.instance.Unpause(3);
    }

    public void Binder()
    {
        TextControlScript.instance.ChangeText(9);
    }

    public void Pages()
    {
        TextControlScript.instance.ChangeText(10);
    }

    public void OfficeYes()
    {
        TextControlScript.instance.ChangeText(11);
    }

    public void OfficeNo()
    {
        ObjectColliderScript.instance.Unpause(4);
    }

    public void OfficeNeither()
    {
        ObjectColliderScript.instance.Unpause(5);
    }
}
