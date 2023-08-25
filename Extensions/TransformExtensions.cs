using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace VExtensions {
public static class TransformExtensions 
{
    #region Serialized Fields
    #endregion

    #region Private Fields
    #endregion

    #region Public Properties
    #endregion

    
    
    #region PublicMethods
    /// <summary>
    /// Gets the child with tag, if more than one child have same tag
    /// returns the first child on the hieararchy
    /// </summary>
    /// <param name="father">Object to extend</param>
    /// <param name="tag">Tag on child</param>
    /// <returns>Child Transform</returns>
    /// <exception cref="Exception">Not found exception</exception>
    public static Transform GetChildWithTag(this Transform father,string tag)
    {
        foreach (Transform transform in father)
        {
            if (transform.gameObject.CompareTag(tag))
            {
                return transform;
            }
        }

        throw new Exception("Child couldn't found");
    }
    /// <summary>
    /// Gets all child of a transform
    /// </summary>
    /// <param name="father">Object to extend</param>
    /// <returns>Child Transform Array</returns>
    public static Transform[] GetAllChilds(this Transform father)
    {
        int arraySize = father.childCount;
        Transform[] childs = new Transform[arraySize];
        int counter = 0;
        foreach (Transform child in father)
        {
            childs[counter] = child;
            counter++;
        }

        return childs;
    }
    
    /// <summary>
    /// Gets all child gameobjects from given transform
    /// </summary>
    /// <param name="father">Object to extend</param>
    /// <returns>Child GameObject Array</returns>
    public static GameObject[] GetAllChildGameObjects(this Transform father)
    {
        var childTransforms = father.GetAllChilds();
        GameObject[] childs = new GameObject[childTransforms.Length];
        for (int i = 0; i < childTransforms.Length; i++)
        {
            childs[i] = childTransforms[i].gameObject;
        }

        return childs;
    }
    /// <summary>
    /// Gets all child gameobjects from given transform
    /// </summary>
    /// <param name="father">Object to extend</param>
    /// <returns>Child GameObject List</returns>
    public static List<GameObject> GetAllChildGameObjectsList(this Transform father)
    {
  

        return GetAllChildGameObjects(father).ToList();
    }

    #endregion
    
    #region PrivateMethods
    #endregion
}
}