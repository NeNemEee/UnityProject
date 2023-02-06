using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager instance = null;
    private int testNumber = 10;
    void Awake()
    {
        
        if(instance == null)
        {
            print("Create First");
            //이 클래스 인스턴스가 생성됐을 때, instance가 null이면 자신을 넣어줌
            instance = this;
            //Scene 전환이 되어도 파괴되지 않게 함
            //유지되어야 하는 정보
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            print("Destroy");
            //이 클래스 인스턴스가 생성됐을 때, instance 가 이미 존재하면 초기화하지 않고 파괴
            Destroy(this.gameObject);
        }

        
    }
    
    public static DataManager GetInstance() {
        if(instance!= null)
        {
            return instance;
        }
        else
        {
            print("Create Instance");
            instance = new DataManager();
            return instance;
        }
    }

    public int GetNumber()
    {
        return testNumber;
    }

    public void SetNumber(int _temp)
    {
        testNumber = _temp;
    }
    
}
