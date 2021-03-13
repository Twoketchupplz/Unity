using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand : MonoBehaviour
{
    public GameObject CardPrefab;
    public int handLimit;
    private Transform _root;
    // Start is called before the first frame update
    void Start()
    {
        _root = transform.root;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Draw()
    {
        int handIndex = transform.childCount;
        print(handIndex);
        if (transform.childCount < handLimit)
        {
            GameObject childCard = Instantiate(CardPrefab);
            childCard.transform.SetParent(transform);
            childCard.transform.localScale = Vector3.one;
        }

    }
    
}