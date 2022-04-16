using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary>
/// 表示専用Attribute
/// </summary>
public class ReadOnlyAttribute : PropertyAttribute
{

}

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof (ReadOnlyAttribute))]
public class ReadOnlyAttrybuteDrawer : PropertyDrawer
{
    public override void OnGUI( // 描画時に実行される
        Rect position,                  // Inspector上で表示される位置
        SerializedProperty property,    // シリアライズされたデータ
        GUIContent label)               // 表示される文字列やテクスチャ
    {
        EditorGUI.BeginDisabledGroup(true); // 操作できないようにするグループ開始
        EditorGUI.PropertyField(            // 複数の型を表示できるようにする。
            position,
            property,
            label,
            true
            );
        EditorGUI.EndDisabledGroup();       // グループ終了
    }
}

#endif