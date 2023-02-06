using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Dice_Mgr : MonoBehaviour
{
    #region Singleton
    public static Dice_Mgr instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public const int DIRECTION_FORWARD = 1;
    public const int DIRECTION_BACKWARD = -1;
    public int direction = DIRECTION_FORWARD;

    public int normalDice
    {
        get
        {
            return _normalDice;
        }
        set
        {
            _normalDice = value;
            onNormalDiceChanged?.Invoke(value);
        }
    }

    public int goldenDice
    {
        get
        {
            return _goldenDice;
        }
        set
        {
            _goldenDice = value;
            onGoldenDiceChanged?.Invoke(value);
        }
    }

    private int _normalDice;
    private int _goldenDice;

    public event Action<int> onNormalDiceChanged;
    public event Action<int> onGoldenDiceChanged;
    public event Action<int> onRollADice;

    private int _currentTileIndex;

    [SerializeField] private TileMap _tileMap;
    private List<Tile_Star> _tileStars = new List<Tile_Star>();
    

    public void RollANormalDice()
    {
        if (_normalDice <= 0) // 남은 주사위 체크
        {
            return;
        }

        _normalDice--; // 기존 주사위 차감

        int diceValue = Random.Range(1, 7); // 1-6 난수 생성

        onRollADice?.Invoke(diceValue); // 주사위 값을 구독자들에게 알림 통지
    }

    public void RollAGoldenDice(int diceValue)
    {
        if (_goldenDice <= 0)
        {
            return;
        }

        _goldenDice--;

        onRollADice?.Invoke(diceValue);
    }

    private void Start()
    {
        foreach (Tile tile in _tileMap.tiles)
        {
            if (tile is Tile_Star) // A is B : A가 B로 캐스팅이 가능하냐? - 가능하면 true 반환
            {
                _tileStars.Add((Tile_Star)tile);
            }
        }
    }

    private void EarnStarValue(int prev, int diceValue)
    {
        int sum = 0;

        foreach (Tile_Star tileStar in _tileStars)
        {
            if (prev + diceValue > _tileMap.total)
            {
                if (tileStar.index <= prev)
                {
                    if (tileStar.index <= prev + diceValue - _tileMap.total)
                    {
                        sum += tileStar.starValue;
                    }
                }
                else
                {
                    sum += tileStar.starValue;
                }
            }
            else
            {
                // 이 샛별칸이 주사위를 굴린 범위 내에 있는지
                if (tileStar.index > prev && tileStar.index < prev + diceValue)
                {
                    sum += tileStar.starValue;
                }
            }
        }
    }
}
