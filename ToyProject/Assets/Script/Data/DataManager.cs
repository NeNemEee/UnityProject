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
            //�� Ŭ���� �ν��Ͻ��� �������� ��, instance�� null�̸� �ڽ��� �־���
            instance = this;
            //Scene ��ȯ�� �Ǿ �ı����� �ʰ� ��
            //�����Ǿ�� �ϴ� ����
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            print("Destroy");
            //�� Ŭ���� �ν��Ͻ��� �������� ��, instance �� �̹� �����ϸ� �ʱ�ȭ���� �ʰ� �ı�
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
