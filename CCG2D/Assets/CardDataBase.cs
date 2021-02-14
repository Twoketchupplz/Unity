using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None"));
        cardList.Add(new Card(0, "Elf", 0, 0, "It's Elf"));
        cardList.Add(new Card(0, "Dwarf", 0, 0, "It's Dwarf"));
        cardList.Add(new Card(0, "Doggaebee", 0, 0, "It's Doggaebee"));
        cardList.Add(new Card(0, "Demon", 0, 0, "It's Demon"));
    }
}
