using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand : MonoBehaviour
{
    public GameObject cardPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Draw(Transform card)
    {
        GameObject childCard = Instantiate(cardPrefab);
        childCard.transform.SetParent(transform);
        childCard.transform.localScale = Vector3.one;
    }
    
}