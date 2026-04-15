using System.IO;
using UnityEngine;

// ✅ fileName, menuName 명시 권장
[CreateAssetMenu(fileName = "StageData", menuName = "StageData")]
public class StageData : ScriptableObject 
{
    [SerializeField] private Vector2 limitMin;
    [SerializeField] private Vector2 limitMax;

    public Vector2 LimitMin => limitMin;
    public Vector2 LimitMax => limitMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/*
File : StageData.class StageData.cs
Desc 
: 현재 스테이지의 화면 내 범위
: 에셋데이터로 화면을 불러와서 저장
*/
