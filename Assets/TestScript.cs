using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public InheritedClass inheritedClass;
    public GenericClass<int> genericClassInt;

    // Start is called before the first frame update
    void Start()
    {
        inheritedClass = new InheritedClass();
        genericClassInt = new GenericClass<int>();
        Debug.Log($"The generic class singleton is null: {GenericClass<int>.singletonInstance == null}");
        Debug.Log($"The generic class singleton is null: {InheritedClass.singletonInstance == null}");
        Debug.Log($"The generic class instance field is: {genericClassInt.instanceField}");
    }
}

public class InheritedClass : GenericClass<int>
{
    public static new InheritedClass singletonInstance;

    public InheritedClass() : base()
    {
        singletonInstance = this;
    }
}

public class GenericClass<T>
{
    public static GenericClass<T> singletonInstance;
    public string instanceField = "test";

    public GenericClass()
    {
        singletonInstance = this;
    }
}
