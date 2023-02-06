using System.Collections;
using UnityEngine;

public class Tile_Reverse : Tile
{
    public override void OnHere()
    {
        base.OnHere();
        ReverseDirection();
    }

    private void ReverseDirection()
    {
        Dice_Mgr.instance.direction = Dice_Mgr.DIRECTION_BACKWARD;
    }
}