using System;
using System.Runtime.InteropServices;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001CC RID: 460
	public class PartnerStateModuleUI : MonoBehaviour
	{
		// Token: 0x060039C8 RID: 14792 RVA: 0x00163A34 File Offset: 0x00161C34
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerStateModuleUI()
		{
			Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "PartnerStateModuleUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr);
			PartnerStateModuleUI.NativeFieldInfoPtr_partnerStatusElementParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "partnerStatusElementParent");
			PartnerStateModuleUI.NativeFieldInfoPtr_partnerStatusField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "partnerStatusField");
			PartnerStateModuleUI.NativeFieldInfoPtr_jobTextColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "jobTextColors");
			PartnerStateModuleUI.NativeFieldInfoPtr_allBgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "allBgs");
			PartnerStateModuleUI.NativeFieldInfoPtr_allFgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "allFgs");
			PartnerStateModuleUI.NativeFieldInfoPtr_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "handles");
			PartnerStateModuleUI.NativeFieldInfoPtr_allPartnerStatusElementInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "allPartnerStatusElementInstances");
			PartnerStateModuleUI.NativeFieldInfoPtr_partnerTypeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "partnerTypeColor");
			PartnerStateModuleUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, 100674062);
			PartnerStateModuleUI.NativeMethodInfoPtr_Initialize_Public_Void_IEnumerable_1_ValueTuple_3_Int32_Int32_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, 100674063);
			PartnerStateModuleUI.NativeMethodInfoPtr_InitializePartnerStatus_Private_Void_UIElementCluster_ValueTuple_3_Int32_Int32_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, 100674064);
			PartnerStateModuleUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_Nullable_1_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, 100674065);
			PartnerStateModuleUI.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, 100674066);
			PartnerStateModuleUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, 100674067);
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x00163B7C File Offset: 0x00161D7C
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x00163BB0 File Offset: 0x00161DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131681, RefRangeEnd = 131682, XrefRangeStart = 131636, XrefRangeEnd = 131681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(IEnumerable<ValueTuple<int, int, PartnerBase>> employeeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employeeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.NativeMethodInfoPtr_Initialize_Public_Void_IEnumerable_1_ValueTuple_3_Int32_Int32_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00163BF4 File Offset: 0x00161DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131682, XrefRangeEnd = 131781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializePartnerStatus(UIElementCluster component, ValueTuple<int, int, PartnerBase> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.NativeMethodInfoPtr_InitializePartnerStatus_Private_Void_UIElementCluster_ValueTuple_3_Int32_Int32_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x00163C50 File Offset: 0x00161E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131781, XrefRangeEnd = 131787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStatus(Nullable<int> deskCode, string data, int partnerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deskCode));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partnerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_Nullable_1_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x00163CB8 File Offset: 0x00161EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131787, XrefRangeEnd = 131797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerStateModuleUI.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x00163CF4 File Offset: 0x00161EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131797, XrefRangeEnd = 131863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerStateModuleUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x00020599 File Offset: 0x0001E799
		public PartnerStateModuleUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x00163D30 File Offset: 0x00161F30
		// (set) Token: 0x060039D1 RID: 14801 RVA: 0x000205A2 File Offset: 0x0001E7A2
		public unsafe GameObject partnerStatusElementParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_partnerStatusElementParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_partnerStatusElementParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x00163D60 File Offset: 0x00161F60
		// (set) Token: 0x060039D3 RID: 14803 RVA: 0x000205C1 File Offset: 0x0001E7C1
		public unsafe RectTransform partnerStatusField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_partnerStatusField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_partnerStatusField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060039D4 RID: 14804 RVA: 0x00163D90 File Offset: 0x00161F90
		// (set) Token: 0x060039D5 RID: 14805 RVA: 0x000205E0 File Offset: 0x0001E7E0
		public unsafe Il2CppStructArray<PartnerStateModuleUI.JobColorPair> jobTextColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_jobTextColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PartnerStateModuleUI.JobColorPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_jobTextColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060039D6 RID: 14806 RVA: 0x00163DC0 File Offset: 0x00161FC0
		// (set) Token: 0x060039D7 RID: 14807 RVA: 0x000205FF File Offset: 0x0001E7FF
		public unsafe Il2CppStringArray allBgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_allBgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_allBgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060039D8 RID: 14808 RVA: 0x00163DF0 File Offset: 0x00161FF0
		// (set) Token: 0x060039D9 RID: 14809 RVA: 0x0002061E File Offset: 0x0001E81E
		public unsafe Il2CppStringArray allFgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_allFgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_allFgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060039DA RID: 14810 RVA: 0x00163E20 File Offset: 0x00162020
		// (set) Token: 0x060039DB RID: 14811 RVA: 0x0002063D File Offset: 0x0001E83D
		public unsafe Dictionary<int, Action<Nullable<int>, string>> handles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_handles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Action<Nullable<int>, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_handles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060039DC RID: 14812 RVA: 0x00163E50 File Offset: 0x00162050
		// (set) Token: 0x060039DD RID: 14813 RVA: 0x0002065C File Offset: 0x0001E85C
		public unsafe List<GameObject> allPartnerStatusElementInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_allPartnerStatusElementInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_allPartnerStatusElementInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060039DE RID: 14814 RVA: 0x00163E80 File Offset: 0x00162080
		// (set) Token: 0x060039DF RID: 14815 RVA: 0x0002067B File Offset: 0x0001E87B
		public unsafe Dictionary<PartnerBase.PartnerType, Color32> partnerTypeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_partnerTypeColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PartnerBase.PartnerType, Color32>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.NativeFieldInfoPtr_partnerTypeColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026E2 RID: 9954
		private static readonly IntPtr NativeFieldInfoPtr_partnerStatusElementParent;

		// Token: 0x040026E3 RID: 9955
		private static readonly IntPtr NativeFieldInfoPtr_partnerStatusField;

		// Token: 0x040026E4 RID: 9956
		private static readonly IntPtr NativeFieldInfoPtr_jobTextColors;

		// Token: 0x040026E5 RID: 9957
		private static readonly IntPtr NativeFieldInfoPtr_allBgs;

		// Token: 0x040026E6 RID: 9958
		private static readonly IntPtr NativeFieldInfoPtr_allFgs;

		// Token: 0x040026E7 RID: 9959
		private static readonly IntPtr NativeFieldInfoPtr_handles;

		// Token: 0x040026E8 RID: 9960
		private static readonly IntPtr NativeFieldInfoPtr_allPartnerStatusElementInstances;

		// Token: 0x040026E9 RID: 9961
		private static readonly IntPtr NativeFieldInfoPtr_partnerTypeColor;

		// Token: 0x040026EA RID: 9962
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040026EB RID: 9963
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_IEnumerable_1_ValueTuple_3_Int32_Int32_PartnerBase_0;

		// Token: 0x040026EC RID: 9964
		private static readonly IntPtr NativeMethodInfoPtr_InitializePartnerStatus_Private_Void_UIElementCluster_ValueTuple_3_Int32_Int32_PartnerBase_0;

		// Token: 0x040026ED RID: 9965
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStatus_Public_Void_Nullable_1_Int32_String_Int32_0;

		// Token: 0x040026EE RID: 9966
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040026EF RID: 9967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000949 RID: 2377
		[Serializable]
		[StructLayout(2)]
		public struct JobColorPair
		{
			// Token: 0x0600BA06 RID: 47622 RVA: 0x002EEF10 File Offset: 0x002ED110
			// Note: this type is marked as 'beforefieldinit'.
			static JobColorPair()
			{
				Il2CppClassPointerStore<PartnerStateModuleUI.JobColorPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "JobColorPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerStateModuleUI.JobColorPair>.NativeClassPtr);
				PartnerStateModuleUI.JobColorPair.NativeFieldInfoPtr_partnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.JobColorPair>.NativeClassPtr, "partnerType");
				PartnerStateModuleUI.JobColorPair.NativeFieldInfoPtr_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.JobColorPair>.NativeClassPtr, "textColor");
			}

			// Token: 0x0600BA07 RID: 47623 RVA: 0x00064610 File Offset: 0x00062810
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PartnerStateModuleUI.JobColorPair>.NativeClassPtr, ref this));
			}

			// Token: 0x0400783B RID: 30779
			private static readonly IntPtr NativeFieldInfoPtr_partnerType;

			// Token: 0x0400783C RID: 30780
			private static readonly IntPtr NativeFieldInfoPtr_textColor;

			// Token: 0x0400783D RID: 30781
			[FieldOffset(0)]
			public PartnerBase.PartnerType partnerType;

			// Token: 0x0400783E RID: 30782
			[FieldOffset(4)]
			public Color32 textColor;
		}

		// Token: 0x0200094A RID: 2378
		[ObfuscatedName("NightScene.UI.HUDUtility.PartnerStateModuleUI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BA08 RID: 47624 RVA: 0x002EEF64 File Offset: 0x002ED164
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerStateModuleUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerStateModuleUI.__c>.NativeClassPtr);
				PartnerStateModuleUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c>.NativeClassPtr, "<>9");
				PartnerStateModuleUI.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c>.NativeClassPtr, "<>9__9_0");
				PartnerStateModuleUI.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c>.NativeClassPtr, "<>9__9_1");
				PartnerStateModuleUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c>.NativeClassPtr, 100674069);
				PartnerStateModuleUI.__c.NativeMethodInfoPtr__Initialize_b__9_0_Internal_PartnerType_JobColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c>.NativeClassPtr, 100674070);
				PartnerStateModuleUI.__c.NativeMethodInfoPtr__Initialize_b__9_1_Internal_Color32_JobColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c>.NativeClassPtr, 100674071);
			}

			// Token: 0x0600BA09 RID: 47625 RVA: 0x002EF008 File Offset: 0x002ED208
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerStateModuleUI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA0A RID: 47626 RVA: 0x002EF044 File Offset: 0x002ED244
			[CallerCount(0)]
			public unsafe PartnerBase.PartnerType _Initialize_b__9_0(PartnerStateModuleUI.JobColorPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c.NativeMethodInfoPtr__Initialize_b__9_0_Internal_PartnerType_JobColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA0B RID: 47627 RVA: 0x002EF090 File Offset: 0x002ED290
			[CallerCount(0)]
			public unsafe Color32 _Initialize_b__9_1(PartnerStateModuleUI.JobColorPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c.NativeMethodInfoPtr__Initialize_b__9_1_Internal_Color32_JobColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA0C RID: 47628 RVA: 0x00064622 File Offset: 0x00062822
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CED RID: 15597
			// (get) Token: 0x0600BA0D RID: 47629 RVA: 0x002EF0DC File Offset: 0x002ED2DC
			// (set) Token: 0x0600BA0E RID: 47630 RVA: 0x0006462B File Offset: 0x0006282B
			public unsafe static PartnerStateModuleUI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerStateModuleUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerStateModuleUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerStateModuleUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CEE RID: 15598
			// (get) Token: 0x0600BA0F RID: 47631 RVA: 0x002EF104 File Offset: 0x002ED304
			// (set) Token: 0x0600BA10 RID: 47632 RVA: 0x0006463D File Offset: 0x0006283D
			public unsafe static Func<PartnerStateModuleUI.JobColorPair, PartnerBase.PartnerType> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerStateModuleUI.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerStateModuleUI.JobColorPair, PartnerBase.PartnerType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerStateModuleUI.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CEF RID: 15599
			// (get) Token: 0x0600BA11 RID: 47633 RVA: 0x002EF12C File Offset: 0x002ED32C
			// (set) Token: 0x0600BA12 RID: 47634 RVA: 0x0006464F File Offset: 0x0006284F
			public unsafe static Func<PartnerStateModuleUI.JobColorPair, Color32> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerStateModuleUI.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerStateModuleUI.JobColorPair, Color32>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerStateModuleUI.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400783F RID: 30783
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007840 RID: 30784
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04007841 RID: 30785
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04007842 RID: 30786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007843 RID: 30787
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__9_0_Internal_PartnerType_JobColorPair_0;

			// Token: 0x04007844 RID: 30788
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__9_1_Internal_Color32_JobColorPair_0;
		}

		// Token: 0x0200094B RID: 2379
		[ObfuscatedName("NightScene.UI.HUDUtility.PartnerStateModuleUI+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BA13 RID: 47635 RVA: 0x002EF154 File Offset: 0x002ED354
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerStateModuleUI>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr);
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_enableIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "enableIndex");
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_partnerVisualData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "partnerVisualData");
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_operatingTypeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "operatingTypeColor");
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_thisDeskCodeBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "thisDeskCodeBG");
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_thisDeskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "thisDeskCode");
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_thisStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "thisStatus");
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "<>9__6");
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "<>9__7");
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100674072);
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__0_Internal_Void_Il2CppReferenceArray_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100674073);
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100674074);
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__1_Internal_Void_Il2CppReferenceArray_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100674075);
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100674076);
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100674077);
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100674078);
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100674079);
				PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_Void_Nullable_1_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100674080);
			}

			// Token: 0x0600BA14 RID: 47636 RVA: 0x002EF2E8 File Offset: 0x002ED4E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerStateModuleUI.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA15 RID: 47637 RVA: 0x002EF324 File Offset: 0x002ED524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131593, XrefRangeEnd = 131604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializePartnerStatus_b__0(Il2CppReferenceArray<Image> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__0_Internal_Void_Il2CppReferenceArray_1_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA16 RID: 47638 RVA: 0x002EF368 File Offset: 0x002ED568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131604, XrefRangeEnd = 131609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializePartnerStatus_b__6(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA17 RID: 47639 RVA: 0x002EF3AC File Offset: 0x002ED5AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131609, XrefRangeEnd = 131620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializePartnerStatus_b__1(Il2CppReferenceArray<Image> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__1_Internal_Void_Il2CppReferenceArray_1_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA18 RID: 47640 RVA: 0x002EF3F0 File Offset: 0x002ED5F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131620, XrefRangeEnd = 131625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializePartnerStatus_b__7(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA19 RID: 47641 RVA: 0x002EF434 File Offset: 0x002ED634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131625, XrefRangeEnd = 131626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializePartnerStatus_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA1A RID: 47642 RVA: 0x002EF478 File Offset: 0x002ED678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131626, XrefRangeEnd = 131627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializePartnerStatus_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA1B RID: 47643 RVA: 0x002EF4BC File Offset: 0x002ED6BC
			[CallerCount(0)]
			public unsafe void _InitializePartnerStatus_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializePartnerStatus_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA1C RID: 47644 RVA: 0x002EF500 File Offset: 0x002ED700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131627, XrefRangeEnd = 131636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Nullable_1_Int32_String_PDM_0(Nullable<int> deskCode, string status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deskCode));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerStateModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_Void_Nullable_1_Int32_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA1D RID: 47645 RVA: 0x00064661 File Offset: 0x00062861
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CF0 RID: 15600
			// (get) Token: 0x0600BA1E RID: 47646 RVA: 0x002EF55C File Offset: 0x002ED75C
			// (set) Token: 0x0600BA1F RID: 47647 RVA: 0x0006466A File Offset: 0x0006286A
			public unsafe PartnerStateModuleUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerStateModuleUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF1 RID: 15601
			// (get) Token: 0x0600BA20 RID: 47648 RVA: 0x002EF58C File Offset: 0x002ED78C
			// (set) Token: 0x0600BA21 RID: 47649 RVA: 0x00064689 File Offset: 0x00062889
			public unsafe int enableIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_enableIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_enableIndex)) = value;
				}
			}

			// Token: 0x17003CF2 RID: 15602
			// (get) Token: 0x0600BA22 RID: 47650 RVA: 0x002EF5B4 File Offset: 0x002ED7B4
			// (set) Token: 0x0600BA23 RID: 47651 RVA: 0x000646A4 File Offset: 0x000628A4
			public unsafe CharacterSpriteSetCompact partnerVisualData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_partnerVisualData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_partnerVisualData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF3 RID: 15603
			// (get) Token: 0x0600BA24 RID: 47652 RVA: 0x002EF5E4 File Offset: 0x002ED7E4
			// (set) Token: 0x0600BA25 RID: 47653 RVA: 0x000646C3 File Offset: 0x000628C3
			public unsafe Color32 operatingTypeColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_operatingTypeColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_operatingTypeColor)) = value;
				}
			}

			// Token: 0x17003CF4 RID: 15604
			// (get) Token: 0x0600BA26 RID: 47654 RVA: 0x002EF60C File Offset: 0x002ED80C
			// (set) Token: 0x0600BA27 RID: 47655 RVA: 0x000646DE File Offset: 0x000628DE
			public unsafe Image thisDeskCodeBG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_thisDeskCodeBG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_thisDeskCodeBG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF5 RID: 15605
			// (get) Token: 0x0600BA28 RID: 47656 RVA: 0x002EF63C File Offset: 0x002ED83C
			// (set) Token: 0x0600BA29 RID: 47657 RVA: 0x000646FD File Offset: 0x000628FD
			public unsafe TextMeshProUGUI thisDeskCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_thisDeskCode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_thisDeskCode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF6 RID: 15606
			// (get) Token: 0x0600BA2A RID: 47658 RVA: 0x002EF66C File Offset: 0x002ED86C
			// (set) Token: 0x0600BA2B RID: 47659 RVA: 0x0006471C File Offset: 0x0006291C
			public unsafe TextMeshProUGUI thisStatus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_thisStatus);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_thisStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF7 RID: 15607
			// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x002EF69C File Offset: 0x002ED89C
			// (set) Token: 0x0600BA2D RID: 47661 RVA: 0x0006473B File Offset: 0x0006293B
			public unsafe Action<Image> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF8 RID: 15608
			// (get) Token: 0x0600BA2E RID: 47662 RVA: 0x002EF6CC File Offset: 0x002ED8CC
			// (set) Token: 0x0600BA2F RID: 47663 RVA: 0x0006475A File Offset: 0x0006295A
			public unsafe Action<Image> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerStateModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007845 RID: 30789
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007846 RID: 30790
			private static readonly IntPtr NativeFieldInfoPtr_enableIndex;

			// Token: 0x04007847 RID: 30791
			private static readonly IntPtr NativeFieldInfoPtr_partnerVisualData;

			// Token: 0x04007848 RID: 30792
			private static readonly IntPtr NativeFieldInfoPtr_operatingTypeColor;

			// Token: 0x04007849 RID: 30793
			private static readonly IntPtr NativeFieldInfoPtr_thisDeskCodeBG;

			// Token: 0x0400784A RID: 30794
			private static readonly IntPtr NativeFieldInfoPtr_thisDeskCode;

			// Token: 0x0400784B RID: 30795
			private static readonly IntPtr NativeFieldInfoPtr_thisStatus;

			// Token: 0x0400784C RID: 30796
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x0400784D RID: 30797
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x0400784E RID: 30798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400784F RID: 30799
			private static readonly IntPtr NativeMethodInfoPtr__InitializePartnerStatus_b__0_Internal_Void_Il2CppReferenceArray_1_Image_0;

			// Token: 0x04007850 RID: 30800
			private static readonly IntPtr NativeMethodInfoPtr__InitializePartnerStatus_b__6_Internal_Void_Image_0;

			// Token: 0x04007851 RID: 30801
			private static readonly IntPtr NativeMethodInfoPtr__InitializePartnerStatus_b__1_Internal_Void_Il2CppReferenceArray_1_Image_0;

			// Token: 0x04007852 RID: 30802
			private static readonly IntPtr NativeMethodInfoPtr__InitializePartnerStatus_b__7_Internal_Void_Image_0;

			// Token: 0x04007853 RID: 30803
			private static readonly IntPtr NativeMethodInfoPtr__InitializePartnerStatus_b__2_Internal_Void_Image_0;

			// Token: 0x04007854 RID: 30804
			private static readonly IntPtr NativeMethodInfoPtr__InitializePartnerStatus_b__3_Internal_Void_Image_0;

			// Token: 0x04007855 RID: 30805
			private static readonly IntPtr NativeMethodInfoPtr__InitializePartnerStatus_b__4_Internal_Void_Image_0;

			// Token: 0x04007856 RID: 30806
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Nullable_1_Int32_String_PDM_0;
		}
	}
}
