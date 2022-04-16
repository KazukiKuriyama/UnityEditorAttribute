using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary>
/// �\����pAttribute
/// </summary>
public class ReadOnlyAttribute : PropertyAttribute
{

}

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof (ReadOnlyAttribute))]
public class ReadOnlyAttrybuteDrawer : PropertyDrawer
{
    public override void OnGUI( // �`�掞�Ɏ��s�����
        Rect position,                  // Inspector��ŕ\�������ʒu
        SerializedProperty property,    // �V���A���C�Y���ꂽ�f�[�^
        GUIContent label)               // �\������镶�����e�N�X�`��
    {
        EditorGUI.BeginDisabledGroup(true); // ����ł��Ȃ��悤�ɂ���O���[�v�J�n
        EditorGUI.PropertyField(            // �����̌^��\���ł���悤�ɂ���B
            position,
            property,
            label,
            true
            );
        EditorGUI.EndDisabledGroup();       // �O���[�v�I��
    }
}

#endif