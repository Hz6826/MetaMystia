using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NightScene
{
	// Token: 0x0200019B RID: 411
	public class DecorationConditionComponentInNight : MonoBehaviour
	{
		// Token: 0x06002C05 RID: 11269 RVA: 0x001308D8 File Offset: 0x0012EAD8
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationConditionComponentInNight()
		{
			Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene", "DecorationConditionComponentInNight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr);
			DecorationConditionComponentInNight.NativeFieldInfoPtr_s_AllComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr, "s_AllComponents");
			DecorationConditionComponentInNight.NativeFieldInfoPtr_decorationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr, "decorationId");
			DecorationConditionComponentInNight.NativeFieldInfoPtr_m_OverrideActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr, "m_OverrideActiveState");
			DecorationConditionComponentInNight.NativeMethodInfoPtr_ForceActivateFiltered_Public_Static_Void_Predicate_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr, 100670978);
			DecorationConditionComponentInNight.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr, 100670979);
			DecorationConditionComponentInNight.NativeMethodInfoPtr_UpdateGameObjectMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr, 100670980);
			DecorationConditionComponentInNight.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr, 100670981);
			DecorationConditionComponentInNight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr, 100670982);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x001309A8 File Offset: 0x0012EBA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98676, RefRangeEnd = 98677, XrefRangeStart = 98655, XrefRangeEnd = 98676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceActivateFiltered(Predicate<int> filter)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationConditionComponentInNight.NativeMethodInfoPtr_ForceActivateFiltered_Public_Static_Void_Predicate_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x001309E0 File Offset: 0x0012EBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98677, XrefRangeEnd = 98686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationConditionComponentInNight.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x00130A14 File Offset: 0x0012EC14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98708, RefRangeEnd = 98709, XrefRangeStart = 98686, XrefRangeEnd = 98708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGameObjectMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationConditionComponentInNight.NativeMethodInfoPtr_UpdateGameObjectMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x00130A48 File Offset: 0x0012EC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98709, XrefRangeEnd = 98717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationConditionComponentInNight.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00130A7C File Offset: 0x0012EC7C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationConditionComponentInNight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationConditionComponentInNight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationConditionComponentInNight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000199E8 File Offset: 0x00017BE8
		public DecorationConditionComponentInNight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06002C0C RID: 11276 RVA: 0x00130AB8 File Offset: 0x0012ECB8
		// (set) Token: 0x06002C0D RID: 11277 RVA: 0x000199F1 File Offset: 0x00017BF1
		public unsafe static List<DecorationConditionComponentInNight> s_AllComponents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecorationConditionComponentInNight.NativeFieldInfoPtr_s_AllComponents, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DecorationConditionComponentInNight>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecorationConditionComponentInNight.NativeFieldInfoPtr_s_AllComponents, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x00130AE0 File Offset: 0x0012ECE0
		// (set) Token: 0x06002C0F RID: 11279 RVA: 0x00019A03 File Offset: 0x00017C03
		public unsafe int decorationId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationConditionComponentInNight.NativeFieldInfoPtr_decorationId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationConditionComponentInNight.NativeFieldInfoPtr_decorationId)) = value;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x00130B08 File Offset: 0x0012ED08
		// (set) Token: 0x06002C11 RID: 11281 RVA: 0x00019A1E File Offset: 0x00017C1E
		public unsafe bool m_OverrideActiveState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationConditionComponentInNight.NativeFieldInfoPtr_m_OverrideActiveState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationConditionComponentInNight.NativeFieldInfoPtr_m_OverrideActiveState)) = value;
			}
		}

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeFieldInfoPtr_s_AllComponents;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeFieldInfoPtr_decorationId;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideActiveState;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr_ForceActivateFiltered_Public_Static_Void_Predicate_1_Int32_0;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGameObjectMode_Private_Void_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
