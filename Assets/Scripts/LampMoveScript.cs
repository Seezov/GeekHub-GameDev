using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LampMoveScript : MonoBehaviour
{
	public Transform Lamp;
    public bool ScaryScene = true;

    public void domove(bool ScaryScene)
    {
        if (ScaryScene)
        {
            Lamp.DOMove(new Vector3(0f, 0f, 1f) /*(0, 0.5f, 1f)*/, 1).SetRelative().SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear);
        }
        else
            Lamp.DOMove(new Vector3(0f, 0f, 0f) /*(0, 0.5f, 1f)*/, 1).SetRelative().SetLoops(-1).SetEase(Ease.Linear);
    }

    void Start()
	{
		DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
    }

    void Update()
    {
        
    }
}