using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// 주사위 개수가 바뀔 때 주사위 개수 UI 갱신
/// </summary>
public class DicePanelUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _normalDice;
    [SerializeField] private TMP_Text _goldenDice;

    private void Start()
    {
        Dice_Mgr diceMgr = Dice_Mgr.instance;

        diceMgr.onNormalDiceChanged += (dice) => _normalDice.text = dice.ToString();
        diceMgr.onGoldenDiceChanged += (dice) => _goldenDice.text = dice.ToString();

        _normalDice.text = diceMgr.normalDice.ToString();
        _goldenDice.text = diceMgr.goldenDice.ToString();
    }

}
