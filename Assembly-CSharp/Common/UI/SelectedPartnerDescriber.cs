using System;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000377 RID: 887
	public class SelectedPartnerDescriber : MonoBehaviour
	{
		// Token: 0x06006958 RID: 26968 RVA: 0x001FE0D4 File Offset: 0x001FC2D4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedPartnerDescriber()
		{
			Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "SelectedPartnerDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr);
			SelectedPartnerDescriber.NativeFieldInfoPtr_multiPartnerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, "multiPartnerParent");
			SelectedPartnerDescriber.NativeFieldInfoPtr_partnerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, "partnerField");
			SelectedPartnerDescriber.NativeFieldInfoPtr_m_PartnerInstancesPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, "m_PartnerInstancesPool");
			SelectedPartnerDescriber.NativeFieldInfoPtr_m_ColorBgCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, "m_ColorBgCollection");
			SelectedPartnerDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, 100685164);
			SelectedPartnerDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, 100685165);
			SelectedPartnerDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, 100685166);
			SelectedPartnerDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, 100685167);
			SelectedPartnerDescriber.NativeMethodInfoPtr__Describe_b__4_0_Private_Void_UIElementCluster_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, 100685168);
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x001FE1B8 File Offset: 0x001FC3B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269031, RefRangeEnd = 269033, XrefRangeStart = 269019, XrefRangeEnd = 269031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> partnerSelection, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerSelection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x001FE214 File Offset: 0x001FC414
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x001FE248 File Offset: 0x001FC448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269033, XrefRangeEnd = 269039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedPartnerDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x001FE284 File Offset: 0x001FC484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269039, XrefRangeEnd = 269074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedPartnerDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600695D RID: 26973 RVA: 0x001FE2C0 File Offset: 0x001FC4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269074, XrefRangeEnd = 269140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Describe_b__4_0(UIElementCluster elementCluster, ValueTuple<int, PartnerBase.PartnerType> partnerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(partnerData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.NativeMethodInfoPtr__Describe_b__4_0_Private_Void_UIElementCluster_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x00038FD5 File Offset: 0x000371D5
		public SelectedPartnerDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x0600695F RID: 26975 RVA: 0x001FE31C File Offset: 0x001FC51C
		// (set) Token: 0x06006960 RID: 26976 RVA: 0x00038FDE File Offset: 0x000371DE
		public unsafe GameObject multiPartnerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.NativeFieldInfoPtr_multiPartnerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.NativeFieldInfoPtr_multiPartnerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x06006961 RID: 26977 RVA: 0x001FE34C File Offset: 0x001FC54C
		// (set) Token: 0x06006962 RID: 26978 RVA: 0x00038FFD File Offset: 0x000371FD
		public unsafe RectTransform partnerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.NativeFieldInfoPtr_partnerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.NativeFieldInfoPtr_partnerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x06006963 RID: 26979 RVA: 0x001FE37C File Offset: 0x001FC57C
		// (set) Token: 0x06006964 RID: 26980 RVA: 0x0003901C File Offset: 0x0003721C
		public unsafe List<GameObject> m_PartnerInstancesPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.NativeFieldInfoPtr_m_PartnerInstancesPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.NativeFieldInfoPtr_m_PartnerInstancesPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x06006965 RID: 26981 RVA: 0x001FE3AC File Offset: 0x001FC5AC
		// (set) Token: 0x06006966 RID: 26982 RVA: 0x0003903B File Offset: 0x0003723B
		public unsafe Il2CppStringArray m_ColorBgCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.NativeFieldInfoPtr_m_ColorBgCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.NativeFieldInfoPtr_m_ColorBgCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045DA RID: 17882
		private static readonly IntPtr NativeFieldInfoPtr_multiPartnerParent;

		// Token: 0x040045DB RID: 17883
		private static readonly IntPtr NativeFieldInfoPtr_partnerField;

		// Token: 0x040045DC RID: 17884
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerInstancesPool;

		// Token: 0x040045DD RID: 17885
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorBgCollection;

		// Token: 0x040045DE RID: 17886
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_CancellationToken_0;

		// Token: 0x040045DF RID: 17887
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0;

		// Token: 0x040045E0 RID: 17888
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040045E1 RID: 17889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045E2 RID: 17890
		private static readonly IntPtr NativeMethodInfoPtr__Describe_b__4_0_Private_Void_UIElementCluster_ValueTuple_2_Int32_PartnerType_0;

		// Token: 0x02000E86 RID: 3718
		[ObfuscatedName("Common.UI.SelectedPartnerDescriber+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x060107DF RID: 67551 RVA: 0x003D3554 File Offset: 0x003D1754
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_0>.NativeClassPtr);
				SelectedPartnerDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr_partnerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_0>.NativeClassPtr, "partnerData");
				SelectedPartnerDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_0>.NativeClassPtr, 100685169);
				SelectedPartnerDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__Describe_b__1_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_0>.NativeClassPtr, 100685170);
				SelectedPartnerDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__Describe_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_0>.NativeClassPtr, 100685171);
			}

			// Token: 0x060107E0 RID: 67552 RVA: 0x003D35D0 File Offset: 0x003D17D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107E1 RID: 67553 RVA: 0x003D360C File Offset: 0x003D180C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269004, XrefRangeEnd = 269008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__1(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__Describe_b__1_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107E2 RID: 67554 RVA: 0x003D3650 File Offset: 0x003D1850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__Describe_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107E3 RID: 67555 RVA: 0x0008FEA9 File Offset: 0x0008E0A9
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700561A RID: 22042
			// (get) Token: 0x060107E4 RID: 67556 RVA: 0x003D3694 File Offset: 0x003D1894
			// (set) Token: 0x060107E5 RID: 67557 RVA: 0x0008FEB2 File Offset: 0x0008E0B2
			public ValueTuple<int, PartnerBase.PartnerType> partnerData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr_partnerData);
					return new ValueTuple<int, PartnerBase.PartnerType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, PartnerBase.PartnerType>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr_partnerData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, PartnerBase.PartnerType>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A6F6 RID: 42742
			private static readonly IntPtr NativeFieldInfoPtr_partnerData;

			// Token: 0x0400A6F7 RID: 42743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6F8 RID: 42744
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__1_Internal_Void_RectTransform_0;

			// Token: 0x0400A6F9 RID: 42745
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__2_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000E87 RID: 3719
		[ObfuscatedName("Common.UI.SelectedPartnerDescriber+<>c__DisplayClass4_1")]
		public sealed class __c__DisplayClass4_1 : Il2CppSystem.Object
		{
			// Token: 0x060107E6 RID: 67558 RVA: 0x003D36C4 File Offset: 0x003D18C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_1()
			{
				Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectedPartnerDescriber>.NativeClassPtr, "<>c__DisplayClass4_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr);
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, "visual");
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr_enabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, "enabledColor");
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, "<>9__8");
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, 100685172);
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, 100685173);
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, 100685174);
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, 100685175);
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, 100685176);
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__7_Internal_Void_Il2CppReferenceArray_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, 100685177);
				SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr, 100685178);
			}

			// Token: 0x060107E7 RID: 67559 RVA: 0x003D37B8 File Offset: 0x003D19B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedPartnerDescriber.__c__DisplayClass4_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107E8 RID: 67560 RVA: 0x003D37F4 File Offset: 0x003D19F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107E9 RID: 67561 RVA: 0x003D3838 File Offset: 0x003D1A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107EA RID: 67562 RVA: 0x003D387C File Offset: 0x003D1A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107EB RID: 67563 RVA: 0x003D38C0 File Offset: 0x003D1AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107EC RID: 67564 RVA: 0x003D3904 File Offset: 0x003D1B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269008, XrefRangeEnd = 269019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__7(Il2CppReferenceArray<Image> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__7_Internal_Void_Il2CppReferenceArray_1_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107ED RID: 67565 RVA: 0x003D3948 File Offset: 0x003D1B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__8(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeMethodInfoPtr__Describe_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107EE RID: 67566 RVA: 0x0008FEE0 File Offset: 0x0008E0E0
			public __c__DisplayClass4_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700561B RID: 22043
			// (get) Token: 0x060107EF RID: 67567 RVA: 0x003D398C File Offset: 0x003D1B8C
			// (set) Token: 0x060107F0 RID: 67568 RVA: 0x0008FEE9 File Offset: 0x0008E0E9
			public unsafe CharacterSpriteSetCompact visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700561C RID: 22044
			// (get) Token: 0x060107F1 RID: 67569 RVA: 0x003D39BC File Offset: 0x003D1BBC
			// (set) Token: 0x060107F2 RID: 67570 RVA: 0x0008FF08 File Offset: 0x0008E108
			public unsafe string enabledColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr_enabledColor);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr_enabledColor), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700561D RID: 22045
			// (get) Token: 0x060107F3 RID: 67571 RVA: 0x003D39E4 File Offset: 0x003D1BE4
			// (set) Token: 0x060107F4 RID: 67572 RVA: 0x0008FF27 File Offset: 0x0008E127
			public unsafe Action<Image> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedPartnerDescriber.__c__DisplayClass4_1.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6FA RID: 42746
			private static readonly IntPtr NativeFieldInfoPtr_visual;

			// Token: 0x0400A6FB RID: 42747
			private static readonly IntPtr NativeFieldInfoPtr_enabledColor;

			// Token: 0x0400A6FC RID: 42748
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x0400A6FD RID: 42749
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6FE RID: 42750
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__3_Internal_Void_Image_0;

			// Token: 0x0400A6FF RID: 42751
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__4_Internal_Void_Image_0;

			// Token: 0x0400A700 RID: 42752
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__5_Internal_Void_Image_0;

			// Token: 0x0400A701 RID: 42753
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__6_Internal_Void_Image_0;

			// Token: 0x0400A702 RID: 42754
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__7_Internal_Void_Il2CppReferenceArray_1_Image_0;

			// Token: 0x0400A703 RID: 42755
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__8_Internal_Void_Image_0;
		}
	}
}
