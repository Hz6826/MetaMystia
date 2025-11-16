using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02000459 RID: 1113
	public class SimpleNPCCharacterComponent : MonoBehaviour
	{
		// Token: 0x06007B16 RID: 31510 RVA: 0x00236D54 File Offset: 0x00234F54
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleNPCCharacterComponent()
		{
			Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "SimpleNPCCharacterComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr);
			SimpleNPCCharacterComponent.NativeFieldInfoPtr_m_CharacterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, "m_CharacterVisual");
			SimpleNPCCharacterComponent.NativeFieldInfoPtr_m_FaceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, "m_FaceDirection");
			SimpleNPCCharacterComponent.NativeFieldInfoPtr_m_SelectedFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, "m_SelectedFace");
			SimpleNPCCharacterComponent.NativeFieldInfoPtr_controllerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, "controllerUnit");
			SimpleNPCCharacterComponent.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, 100687937);
			SimpleNPCCharacterComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, 100687938);
			SimpleNPCCharacterComponent.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, 100687939);
			SimpleNPCCharacterComponent.NativeMethodInfoPtr_Set_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, 100687940);
			SimpleNPCCharacterComponent.NativeMethodInfoPtr_GetSpriteCode_Private_ValueTuple_2_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, 100687941);
			SimpleNPCCharacterComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, 100687942);
			SimpleNPCCharacterComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr, 100687943);
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x00236E60 File Offset: 0x00235060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295647, XrefRangeEnd = 295667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleNPCCharacterComponent.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x00236E94 File Offset: 0x00235094
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleNPCCharacterComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x00236EC8 File Offset: 0x002350C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295667, XrefRangeEnd = 295693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleNPCCharacterComponent.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B1A RID: 31514 RVA: 0x00236EFC File Offset: 0x002350FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295693, XrefRangeEnd = 295697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleNPCCharacterComponent.NativeMethodInfoPtr_Set_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B1B RID: 31515 RVA: 0x00236F30 File Offset: 0x00235130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295697, XrefRangeEnd = 295700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, int> GetSpriteCode(int orientation, int faceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orientation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceId;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SimpleNPCCharacterComponent.NativeMethodInfoPtr_GetSpriteCode_Private_ValueTuple_2_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<int, int>(pointer);
		}

		// Token: 0x06007B1C RID: 31516 RVA: 0x00236F84 File Offset: 0x00235184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleNPCCharacterComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x00236FC0 File Offset: 0x002351C0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleNPCCharacterComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleNPCCharacterComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleNPCCharacterComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B1E RID: 31518 RVA: 0x000426A1 File Offset: 0x000408A1
		public SimpleNPCCharacterComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x06007B1F RID: 31519 RVA: 0x00236FFC File Offset: 0x002351FC
		// (set) Token: 0x06007B20 RID: 31520 RVA: 0x000426AA File Offset: 0x000408AA
		public unsafe CharacterSpriteSetCompact m_CharacterVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleNPCCharacterComponent.NativeFieldInfoPtr_m_CharacterVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleNPCCharacterComponent.NativeFieldInfoPtr_m_CharacterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x06007B21 RID: 31521 RVA: 0x0023702C File Offset: 0x0023522C
		// (set) Token: 0x06007B22 RID: 31522 RVA: 0x000426C9 File Offset: 0x000408C9
		public unsafe int m_FaceDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleNPCCharacterComponent.NativeFieldInfoPtr_m_FaceDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleNPCCharacterComponent.NativeFieldInfoPtr_m_FaceDirection)) = value;
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x06007B23 RID: 31523 RVA: 0x00237054 File Offset: 0x00235254
		// (set) Token: 0x06007B24 RID: 31524 RVA: 0x000426E4 File Offset: 0x000408E4
		public unsafe int m_SelectedFace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleNPCCharacterComponent.NativeFieldInfoPtr_m_SelectedFace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleNPCCharacterComponent.NativeFieldInfoPtr_m_SelectedFace)) = value;
			}
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x06007B25 RID: 31525 RVA: 0x0023707C File Offset: 0x0023527C
		// (set) Token: 0x06007B26 RID: 31526 RVA: 0x000426FF File Offset: 0x000408FF
		public unsafe CharacterControllerUnit controllerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleNPCCharacterComponent.NativeFieldInfoPtr_controllerUnit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleNPCCharacterComponent.NativeFieldInfoPtr_controllerUnit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050FE RID: 20734
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterVisual;

		// Token: 0x040050FF RID: 20735
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceDirection;

		// Token: 0x04005100 RID: 20736
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedFace;

		// Token: 0x04005101 RID: 20737
		private static readonly IntPtr NativeFieldInfoPtr_controllerUnit;

		// Token: 0x04005102 RID: 20738
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005103 RID: 20739
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005104 RID: 20740
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04005105 RID: 20741
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_0;

		// Token: 0x04005106 RID: 20742
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteCode_Private_ValueTuple_2_Int32_Int32_Int32_Int32_0;

		// Token: 0x04005107 RID: 20743
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04005108 RID: 20744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
