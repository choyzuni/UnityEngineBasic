using System.Collections;
using UnityEngine;

public class Tile_NormalDice : Tile
{
    public override void OnHere()
    {
        base.OnHere();
        IncreaseNormalDice();
    }

    private void IncreaseNormalDice()
    {
        Dice_Mgr.instance.normalDice++;
    }
}