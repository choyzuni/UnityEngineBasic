using System.Collections;
using UnityEngine;

public class Tile_GoldenDice : Tile
{
    public override void OnHere()
    {
        base.OnHere();
        IncreaseGoldenDice();
    }

    private void IncreaseGoldenDice()
    {
        Dice_Mgr.instance.goldenDice++;
    }
}