using UnityEngine;

public class MonobehaviorScript : MonoBehaviour
{
    //CSharpClass_A m_ClassA = new CSharpClass_A(1);
    CSharpClass m_ClassA;
    CSharpAbstractClass m_ClassB;

    void Start()
    {
        m_ClassA = new CSharpClass(1);
        Debug.Log(m_ClassA.ParamInt);
        
        m_ClassA.ParamInt = 2;
        Debug.Log(m_ClassA.ParamInt);

        m_ClassA.ParamInt = CSharpStaticClass.StaticParamInt;
        Debug.Log(m_ClassA.ParamInt);

        //m_ClassB = new CSharpAbstractClass();
        //m_ClassB = new CSharpClass();
    }


    void Update()
    {
        
    }
}
