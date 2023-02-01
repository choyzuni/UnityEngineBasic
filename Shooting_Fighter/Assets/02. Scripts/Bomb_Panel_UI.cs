using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_Panel_UI : MonoBehaviour
{
    [SerializeField] private GameObject[] _bombImages;

    public void Refresh(int num)
    {
        for (int i = 0; i < _bombImages.Length; i++)
        {
            if (i < num)
            {
                _bombImages[i].SetActive(true);
            }
            else
            {
                _bombImages[i].SetActive(false);
            }
        }
    }

    private void Start()
    {
        Refresh(Fighter_Fire.instance.bombNum);
        Fighter_Fire.instance.OnBombNumChanged += Refresh;
    }
}
