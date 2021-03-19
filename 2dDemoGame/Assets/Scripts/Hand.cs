using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject childCard;
    public GameObject prefabDummy;
    public int handLimit;
    private Transform _root;
    private GameObject _dummyCard;
    private bool _pntIn;
    private int _dummyIdx;
    // Start is called before the first frame update
    void Start()
    {
        _root = transform.root;
        _dummyCard = Instantiate(prefabDummy, _root, true);
        _dummyCard.transform.localScale = Vector3.one;
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
            GameObject childCard = Instantiate(this.childCard, transform, true);
            childCard.transform.localScale = Vector3.one;
        }
    }

    public void ParentDummyCard(int cardIndex)
    {
        _dummyIdx = cardIndex;
        _dummyCard.transform.SetParent(transform);
        // transform.setParent()와 transform.parent의 차이
        // https://answers.unity.com/questions/1153512/transformparent-vs-transformsetparent.html ,https://kukuta.tistory.com/177
        _dummyCard.transform.localScale = Vector3.one;
        _dummyCard.transform.SetSiblingIndex(_dummyIdx);
    }

    public void UnparentDummyCard()
    {
        _dummyCard.transform.SetParent(_root);
    }
    
    // call-back
    public void OnPointerEnter(PointerEventData eventData)
    {
        _pntIn = true;
        print(_pntIn);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _pntIn = false;
        print(_pntIn);
    }
}