using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand : MonoBehaviour
{
    public GameObject childCard;
    public GameObject dummyCard;
    public int handLimit;
    private Transform _root;
    private GameObject dummy;
    private int _dummyIdx;
    // Start is called before the first frame update
    void Start()
    {
        _root = transform.root;
        dummy = Instantiate(dummyCard, _root, true);
        Debug.Log("Hand root: ", _root);
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
            GameObject childCard = Instantiate(this.childCard);
            Debug.Log("Instantiate");
            childCard.transform.localScale = Vector3.one;
            childCard.transform.SetParent(transform);
        }
    }

    // public void ParentDummyCard(int cardIndex)
    // {
    //     _dummyIdx = cardIndex;
    //     // transform.setParent()와 transform.parent의 차이
    //     // https://answers.unity.com/questions/1153512/transformparent-vs-transformsetparent.html ,https://kukuta.tistory.com/177
    //     dummy.transform.localScale = Vector3.one;
    //     dummy.transform.SetSiblingIndex(_dummyIdx);
    // }

    // public void UnparentDummyCard(Transform card)
    // {
    //     dummyCard.transform.SetParent(_root);
    //     card.SetParent(transform);
    //     card.SetSiblingIndex(_dummyIdx);
    // }
    
}